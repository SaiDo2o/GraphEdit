using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Samples
{
    [Serializable]
    [NeedPoint(2)]
    class Circle : ClosedFigure
    {
        public Circle(int _lineWeight, Color _lineColor, List<Point> _pointList, Color _figureColor) : base(_lineWeight, _lineColor, _figureColor)
        {
            PointList = new Point[_pointList.Count];
            PointList[0] = _pointList[0];
            PointList[1] = _pointList[1];
        }

        public override void DrawIt(Graphics panel)
        {
            // Установка цвета границы и заливки
            Pen pen = new Pen(LineColor, LineWeight);
            SolidBrush brush = new SolidBrush(FigureColor);

            int radius = (int)Math.Sqrt((Math.Pow(PointList[1].X- PointList[0].X, 2) + Math.Pow(PointList[1].Y- PointList[0].Y, 2)));

            panel.DrawEllipse(pen, PointList[0].X - radius, PointList[0].Y - radius, 2*radius, 2*radius);
            panel.FillEllipse(brush, PointList[0].X - radius, PointList[0].Y - radius, 2 * radius, 2 * radius);
        }
    }
}
