using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using ClassLibrary;
using System.IO;
using System.Runtime.CompilerServices;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        // Хранение достпных для отрисовки элементов
        private List<Type> TypeList = new List<Type>();
        // Выбранный для отрисовки тип
        private Type NeedType;
        // Точки, указанные пользователем
        private List<Point> PointList = new List<Point>();
        // Взаимодествие между формами и фигурами
        private Hierarchy UHierarchy;
        // Отрисовка происходит тут:
        public Graphics DPanel;
        // Подтвердить отрисовку
        public bool EnterPushed = false;

        private byte LineWeigth = 5;
        private Color LineColor = Color.Black;
        private Color FigureColor = Color.White;

        // Определение типа, выбранного пользователем
        private Type DetermineType()
        {
            Type needType = null;

            foreach (Type sup in TypeList)
            {
                if (sup.Name == Convert.ToString(TypeCB.SelectedItem))
                    needType = sup;
            }

            return needType;
        }

        public Form1()
        {
            InitializeComponent();

            // Создание списка объектов
            UHierarchy = new Hierarchy();
            TypeList = UHierarchy.CreateTypeList();

            foreach (Type type in TypeList)
                TypeCB.Items.Add(type.Name);

            DPanel = DrawPanel.CreateGraphics();
            LineWeightLabel.Text = String.Format("Line weigth: {0}", LineWeigth);
        }

        private void DrawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            DrawPanel.Focus();
            PointList.Add(new Point(e.X, e.Y));

            CanCreateFigure();
        }

        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawPanel.Focus();
            NeedType = DetermineType();
            PointList.Clear();
        }

        private void LineWeigthTB_Scroll(object sender, EventArgs e)
        {
            LineWeigth = (byte)LineWeigthTB.Value;
            LineWeightLabel.Text = String.Format("Line weigth: {0}", LineWeigth);
        }

        private void LineColorBt_Click(object sender, EventArgs e)
        {
            DrawPanel.Focus();
            var temp = LineColorCD.ShowDialog();
            if (temp == System.Windows.Forms.DialogResult.OK)
            {
                LineColor = LineColorCD.Color;
            }
        }

        private void FigureColorBt_Click(object sender, EventArgs e)
        {
            DrawPanel.Focus();
            var temp = FigureColorCD.ShowDialog();
            if (temp == System.Windows.Forms.DialogResult.OK)
            {
                FigureColor = FigureColorCD.Color;
            }
        }

        private void UndoLastBt_Click(object sender, EventArgs e)
        {
            DrawPanel.Focus();
            UHierarchy.DeleteLast();
            DPanel.Clear(Panel.DefaultBackColor);
            UHierarchy.UpdatePanel(DPanel);
        }

        private void ClearBt_Click(object sender, EventArgs e)
        {
            DrawPanel.Focus();
            UHierarchy.ClearHierarchy();
            DPanel.Clear(Panel.DefaultBackColor);
            UHierarchy.UpdatePanel(DPanel);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string fileName = saveFileDialog1.FileName;
            UHierarchy.SaveHierarchy(fileName);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string fileName = openFileDialog1.FileName;

            try
            {
                UHierarchy.LoadHierarchy(fileName);
                UHierarchy.UpdatePanel(DPanel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! {ex.Message}");
                UHierarchy.ClearHierarchy();
            }
        }


        private void CanCreateFigure(bool EnterPushed = false)
        {
            // Определение количества точек, необходимых для отрисовки
            NeedPointAttribute attr = null;

            if (NeedType != null)
                attr = (NeedPointAttribute)Attribute.GetCustomAttribute(NeedType, typeof(NeedPointAttribute));

            if (attr != null)
            {
                try
                {
                    // Создание фигур с заранее известным числом сторон
                    if ((attr.KnowNeedPoint) && (PointList.Count == attr.NeedPoint))
                        DrawFigure(NeedType);
                    else if ((EnterPushed) && (PointList.Count > 1))
                        DrawFigure(NeedType);
                }
                catch
                {
                    MessageBox.Show("Ooops..I can't find figure construct!");
                }
            }
        }

        public void DrawFigure(Type needType)
        {
            ConstructorInfo CI = NeedType.GetConstructor(new[] { typeof(int), typeof(Color), typeof(List<Point>), typeof(Color) });
            object NewFigure = CI.Invoke(new object[] { LineWeigth, LineColor, PointList, FigureColor });
            UHierarchy.AddFigure((Geometry)NewFigure);
            UHierarchy.UpdatePanel(DPanel);
            PointList.Clear();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                CanCreateFigure(true);
                DrawPanel.Focus();
            }
        }
    }
}
