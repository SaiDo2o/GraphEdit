using System;
using System.Collections.Generic;
using System.Drawing;
using ClassLibrary;

namespace PolygonPlugin
{
    [Serializable]
    [NeedPoint(2, false)]
    class Polygon : ClosedFigure
    {
        public Polygon(int _lineWeight, Color _lineColor, List<Point> _pointList, Color _figureColor) : base(_lineWeight, _lineColor, _figureColor)
        {
            PointList = new Point[_pointList.Count];
            for (int i = 0; i < _pointList.Count; i++)
                PointList[i] = new Point(_pointList[i].X, _pointList[i].Y);
        }

        public override void DrawIt(Graphics panel)
        {
            // Установка цвета границы и заливки
            Pen pen = new Pen(LineColor, LineWeight);
            SolidBrush brush = new SolidBrush(FigureColor);

            panel.DrawPolygon(pen, PointList);
            panel.FillPolygon(brush, PointList);
        }
    }
}
