using System;
using System.Drawing;
using System.Net.NetworkInformation;

namespace ClassLibrary
{
    [Serializable]
    public abstract class Geometry : IDrawAble
    {
        private int lineWeight;
        private Color lineColor;
        private Point[] pointList;

        public int LineWeight { get { return lineWeight; } }

        public Color LineColor { get { return lineColor; } }
        public Point[] PointList { set { pointList = value; } get { return pointList; } } 

        public Geometry(int _lineWeight, Color _lineColor)
        {
            lineWeight = _lineWeight;
            lineColor = _lineColor;
        }

        public abstract void DrawIt(Graphics panel);
    }
}
