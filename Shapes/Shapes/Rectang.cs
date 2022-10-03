using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public  class Rectang : Shape
    {
        
        public override void draw(string color)
        {
            if (color == "черный")
                Form1.shape.DrawRectangle(Pens.Black, 100, 100, 100, 200);
            else if (color == "красный")
                Form1.shape.DrawRectangle(Pens.Red, 100, 100, 100, 200);
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Rectangle rectangle = (Rectangle)obj;
            return true;
        }

        public override int GetHashCode()
        {
            return GetHashCode();
        }
    }
}
