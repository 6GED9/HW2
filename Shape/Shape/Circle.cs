using System;
namespace Figurs
{
    public class Circle:Shape
    {
        
        public void CircleCord()
        {
            int[] center = new int[] { 0, 0 };
            int radius = 3;
        }

        public override void draw(string color)
        {
            Console.WriteLine("Квадрат будет {0} цвета", color);
            for (int i = 0;i<4; i++)
                Console.WriteLine("Рисую круг");
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

