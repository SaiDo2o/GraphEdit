using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ClassLibrary;

namespace SquarePlugin
{
    [Serializable]
    [NeedPoint(2)]
    class Square : ClosedFigure
    {
        public Square(int _lineWeight, Color _lineColor, List<Point> _pointList, Color _figureColor) : base(_lineWeight, _lineColor, _figureColor)
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

            int delta = Math.Abs(PointList[1].X - PointList[0].X);

            // Формирование массива для отрисовки
            System.Drawing.Point[] pointList = new System.Drawing.Point[]
            {
                new Point(PointList[0].X - delta, PointList[0].Y - delta),
                new Point(PointList[0].X + delta, PointList[0].Y - delta),
                new Point(PointList[0].X + delta, PointList[0].Y + delta),
                new Point(PointList[0].X - delta, PointList[0].Y + delta)
            };


            panel.DrawPolygon(pen, pointList);
            panel.FillPolygon(brush, pointList);
        }
    }
}
