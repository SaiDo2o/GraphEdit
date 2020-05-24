using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassLibrary
{
    [Serializable]
    [NeedPoint(2)]
    class Ellipse : ClosedFigure
    {
        public Ellipse(int _lineWeight, Color _lineColor, List<Point> _pointList, Color _figureColor) : base(_lineWeight, _lineColor, _figureColor)
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

            if ((PointList[0].X > PointList[1].X) || (PointList[0].Y > PointList[1].Y))
            {
                var _point = PointList[0];
                PointList[0] = PointList[1];
                PointList[1] = _point;
            }

            var width = PointList[1].X - PointList[0].X;
            var heigth = PointList[1].Y - PointList[0].Y;

            panel.DrawEllipse(pen, PointList[0].X, PointList[0].Y, width, heigth);
            panel.FillEllipse(brush, PointList[0].X, PointList[0].Y, width, heigth);
        }
    }
}