using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NeedPointAttribute : Attribute
    {
        // Заведомо известное кол-во точек
        private int needPoint;
        // Не знаем сколько точек понадобиться
        private bool knowNeedPoint;

        public int NeedPoint
        {
            get { return needPoint; }
        }

        public bool KnowNeedPoint
        {
            get { return knowNeedPoint; }
        }

        public NeedPointAttribute(int _needPoint, bool _knowNeedPoint = true)
        {
            needPoint = _needPoint;
            knowNeedPoint = _knowNeedPoint;
        }
        
    }
}
