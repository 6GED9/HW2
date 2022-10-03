using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Shape
    {
        public override void draw(string color)
        {
            if (color == "черный")
                Form1.shape.DrawEllipse(Pens.Black, 300, 300, 100, 200);
            else if(color == "красный")
                Form1.shape.DrawEllipse(Pens.Red, 300, 300, 200, 200);
        }
        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Circle circle = (Circle)obj;
            return true;
        }

        public override int GetHashCode()
        {
            return GetHashCode();
        }
    }
}
