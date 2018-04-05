using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14ClassWork
{
    class Box : Rectangle // child class
    {
        private double _height;

        public Box()
        {
            _height = 0.0;
        }

        public Box(double l,double w,double h):base(l,w)
        {
            _height = h;
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double volume()
        {
            return Area() * _height;
        }
    }
}
