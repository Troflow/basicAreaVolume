using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14ClassWork
{
    class Rectangle //parent class
    {
        private double _length;
        private double _width;

        public Rectangle()
        {
            _length = 0.0;
            _width = 0.0;
        }

        public Rectangle(double l,double w)
        {
            _length = l;
            _width = w;
        }

        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public double Area()
        {
            //x = 10;
            return _length * _width;
        }
    }
}
