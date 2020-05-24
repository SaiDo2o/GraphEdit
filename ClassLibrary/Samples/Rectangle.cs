﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassLibrary
{
    [Serializable]
    [NeedPoint(2)]
    class Rectangle : ClosedFigure
    {
        public Rectangle(int _lineWeight, Color _lineColor, List<Point> _pointList, Color _figureColor) : base(_lineWeight, _lineColor, _figureColor)
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

            // Формирование массива для отрисовки
            System.Drawing.Point[] pointList = new System.Drawing.Point[]
            {
                new Point(PointList[0].X, PointList[0].Y),
                new Point(PointList[1].X, PointList[0].Y),
                new Point(PointList[1].X, PointList[1].Y),
                new Point(PointList[0].X, PointList[1].Y)
            };


            panel.DrawPolygon(pen, pointList);
            panel.FillPolygon(brush, pointList);
        }
    }
}
