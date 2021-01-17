using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Triangle
    {
        public Triangle(decimal height, decimal bottom)
        {
            H = height;
            Bottom = bottom;
        }

        private decimal _h;
        private decimal _bottom;
        private decimal _left;
        private decimal _right;

        public decimal H
        {
            get { return _h; }
            set { _h = value; }
        }

        public decimal Bottom
        {
            get { return _bottom; }
            set { _bottom = value; }
        }

        public decimal Right
        {
            get { return _right; }
            set { _right = value; }
        }

        public decimal Left
        {
            get { return _left; }
            set { _left = value; }
        }

        public decimal area_triangle
        {
            get { return (_bottom * _h) / 2; }
        }

        public decimal perimeter_triangle(decimal a, decimal b, decimal c)
        {
            decimal per = a + b + c;
            return per;
        }

    }
}
