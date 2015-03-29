using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeforeLSP
{
    public class Square : Rectangle
    {
        public override void SetWidth(double newWidth)
        {
            width = newWidth;
            height = newWidth;
        }

        public override void SetHeight(double newHeight)
        {
            height = newHeight;
            width = newHeight;
        }
    }
}
