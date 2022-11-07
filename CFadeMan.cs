using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Constructor
{
    class CFadeMan
    {
        struct FadeObject
        {
            public object element;
            public double fade;
            public int time;

            public FadeObject(object e, double f, int t = 100)
            {
                this.element = e;
                this.fade = f;
                this.time = t;
            }
        }

        private List<FadeObject> m_objects = new List<FadeObject>();

        public void Add(object element)
        {

        }
    }
}
