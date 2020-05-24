using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassLibrary
{
    [NeedPoint(2)]
    [Serializable]
    public class Line : Geometry
    {
        public Line(int _lineWeight, Color _lineColor,List<Point> _pointList, Color? temp = null) : base(_lineWeight,_lineColor)
        {
            PointList = new Point[_pointList.Count];
            PointList[0] = _pointList[0];
            PointList[1] = _pointList[1];
        }

        public override void DrawIt(Graphics panel)
        {
            Pen pen = new Pen(LineColor, LineWeight);

            panel.DrawLine(pen, PointList[0].X, PointList[0].Y, PointList[1].X, PointList[1].Y);
        }
    }
}
