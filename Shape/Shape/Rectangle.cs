using System;
namespace Figurs
{
    public class Rectangle : Shape
    {


        public void RectangleCord()
        {
            int[] rec1 = new int[] { 0, 0 };
            int[] rec2 = new int[] { 0, 3 };
            int[] rec3 = new int[] { 3, 0 };
            int[] rec4 = new int[] { 3, 3 };
        }

        public override void draw(string color)
        {
            Console.WriteLine("Круг будет {0} цвета", color);
            for (int i = 0; i < 4; i++)
                Console.WriteLine("Рисую Квадрат");
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

