using System;
using System.Text;
namespace Figurs
{
    public abstract class Shape
    {
        public abstract void draw(string color);

        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Shape s = (Shape)obj;
            return true;
        }

        public override int GetHashCode()
        {
            return GetHashCode();
        }
    }

}

