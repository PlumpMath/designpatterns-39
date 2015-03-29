using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSPSample
{
    public class Rectangle
    {
        protected double width;
        protected double height;

        public virtual void SetParameters(double newWidth, double newHeight)
        {
            width = newWidth;
            height = newHeight;
        }

        public double CalculateArea()
        {
            return width * height;
        }
    }
}
