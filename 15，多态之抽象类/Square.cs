using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_多态之抽象类
{
    class Square : Shape
    {
        private double _hei;
        private double _wid;

        public double Hei
        {
            get { return _hei; }
            set { _hei = value; }
        }
        public double Wid
        {
            get { return _wid; }
            set { _wid = value; }
        }
        public Square(double hei, double wid)
        {
            this.Hei = hei;
            this.Wid = wid;
        }

        public override double GetArea()
        {
            return Wid * Hei;
        }

        public override double GetParameter()
        {
            return Wid * 2 + 2 * Hei;
        }
    }
}
