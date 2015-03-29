using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeforeLSP
{
    public class Rectangle
    {
        protected double width;
        protected double height;

        public virtual void SetWidth(double newWidth)
        {
            width = newWidth;
        }

        public virtual void SetHeight(double newHeight)
        {
            height = newHeight;
        }

        public double CalculateArea()
        {
            return width * height;
        }
    }
}
