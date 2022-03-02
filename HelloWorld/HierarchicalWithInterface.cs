using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class HierarchicalWithInterface
    {
        public interface IArea
        {
            void findArea();    //Signature or Declaration
        }

        class Circle : IArea
        {
            float rad, area;
            public Circle(float r)
            {
                rad = r;
            }

            public void DisplayRad()
            {
                Console.WriteLine("Radius is {0}", rad);
            }

            public void findArea()
            {
                area = 3.14f * (rad * rad);
                Console.WriteLine("Area of Circle {0}", area);
            }
        }

        class Cylinder : IArea
        {
            float rad, height, area;
            public Cylinder(float r, float h)
            {
                rad = r;
                height = h;
            }
            public void DisplayRadHgt()
            {
                Console.WriteLine("Radius is {0}", rad);
                Console.WriteLine("Height is {0}", height);
            }

            public void findArea()
            {
                area = 3.14f * (rad * rad) * height;
                Console.WriteLine("Area of cylinder {0}", area);
            }
        }

        static void Main(String[] args)
        {
            Circle cir = new Circle(10f);
            cir.DisplayRad();
            cir.findArea();

            Cylinder cyl = new Cylinder(8f, 4f);
            cyl.DisplayRadHgt();
            cyl.findArea();

            Console.ReadKey();
        }
    }
}
