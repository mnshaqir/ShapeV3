using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Square: IShape
    {
    
        private double _len;

        public double Len
        {
            get { return _len; }
            set { _len = value; }
        }

        public Square()
        {
            _len = 0;
        }

        public Square(double len)
        {
            _len = len;
        }

        public double Area()
        {
            return _len * _len;
        }

        public double Circumference()
        {
            return 4 * _len;
        }
    }
}

