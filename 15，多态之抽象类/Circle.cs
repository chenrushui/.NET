﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_多态之抽象类
{
    class Circle : Shape
    {
        private double _r;
        public double R
        {
            get { return _r; }
            set { _r = value; }
        }
        public Circle(double r)
        {
            this.R = r;
        }

        public override double GetArea()
        {
            return Math.PI * this.R * this.R;

        }

        public override double GetParameter()
        {
            return Math.PI * this.R * 2;
        }
    }
}
