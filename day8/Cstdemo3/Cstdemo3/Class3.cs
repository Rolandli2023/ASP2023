using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo3
{
    public class Rectangle:Shape
    {
        
        private double _length;

        public double Length 
        {
            get { return _length; }
            set { _length = value; }
        }
        private double _width;

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public Rectangle (double length,double width)
        {
            this.Length = length;
            this.Width = width;
        }
        public override double Getarea()
        {
            return  this.Length * this.Width;
        }
        public override double Getperimeter()
        {
            return this.Length *2+ this.Width*2;
        }


    }
}
