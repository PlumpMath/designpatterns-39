using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSPSample
{
    public class Square : Rectangle
    {
        public override void SetParameters(double newWidth, double newHeight)
        {
            if (newWidth != newHeight)
                throw new ApplicationException("Sides must be equal - Kenarlar eşit olmalı");
            
            width = newWidth;
            height = newHeight;
        }
    }
}
