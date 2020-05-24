using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Reflection;
using System.CodeDom.Compiler;

namespace ClassLibrary
{
    public class Hierarchy
    {
        private List<Geometry> hierarchyList = new List<Geometry>();

        public void AddFigure(Geometry figure)
        {
            hierarchyList.Add(figure);
        }

        public Geometry LastFigure()
        {
            if (hierarchyList.Count != 0)
            {
                Geometry temp = hierarchyList[hierarchyList.Count - 1];
                DeleteLast();
                return temp;
            }
            else
                return null;
        }

        public void UpdatePanel(Graphics DPanel)
        {
            DPanel.Clear(SystemColors.Control);

            foreach(Geometry figure in hierarchyList)
            {
                figure.DrawIt(DPanel);
            }
        }

        public void DeleteLast()
        {
            if (hierarchyList.Count != 0)
                hierarchyList.RemoveAt(hierarchyList.Count - 1);
        }

        public void ClearHierarchy()
        {
            hierarchyList.Clear();
        }

        public void SaveHierarchy(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream fs = new FileStream(fileName, FileMode.Create);
            foreach (Geometry figure in hierarchyList)
                formatter.Serialize(fs, figure);

            fs.Close();
        }

        public void LoadHierarchy(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs;

            try
            {
                fs = new FileStream(fileName, FileMode.Open);
            }
            catch
            {
                throw new Exception("File not found!");
            }

            while (fs.Position < fs.Length)
            {
                try
                {
                    Geometry figure = (Geometry)formatter.Deserialize(fs);
                    hierarchyList.Add(figure);
                }
                catch
                {
                    fs.Close();
                    throw new Exception("Invalid file format!");
                }
            }

            fs.Close();
        }

        public List<Type> CreateTypeList()
        {
            List<Type> typeList = new List<Type>();

            // Загрузка фигур
            string findDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var dllFiles = Directory.GetFiles(findDir, "*.dll");
            foreach (var dllFile in dllFiles)
            {
                Type[] tempList = (Assembly.Load(System.IO.Path.GetFileNameWithoutExtension(dllFile))).GetTypes();

                foreach (Type sup in tempList)
                {
                    // Является ли рисуемой фигурой
                    if (((sup.GetInterface(typeof(IDrawAble).Name)) != null) && !(sup.IsAbstract))
                    {
                        typeList.Add(sup);
                    }
                }
            }

            return typeList;
        }
    }
}

