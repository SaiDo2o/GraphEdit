using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassLibrary
{
    [Serializable]
    public abstract class ClosedFigure : Geometry
    {
        private Color figureColor;

        public Color FigureColor { get { return figureColor; } }

        public ClosedFigure(int _lineWeight, Color _lineColor, Color _figureColor):base(_lineWeight,_lineColor)
        {
            figureColor = _figureColor;
        }
    }
}
