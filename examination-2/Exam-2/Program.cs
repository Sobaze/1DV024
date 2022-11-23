using System;
using System.Linq;
using System.Collections.Generic;

namespace Exam_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            // TestMyForms();
            // ZeroValueForms();
        }

        static void Menu () 
        {
            // List<string> shapes;
            // int enteredNumber;
            Console.WriteLine("Write '2' for 2D shapes \nWrite '3' for 3D shapes");
            string userResponse = Console.ReadLine();
            if (userResponse == "2")
            {
                 create2DList();
            }
            if(userResponse == "3")
            {
                create3DList();
            }
        }

        private static void create2DList()
        {
            List<Shape2D> shapesin2D = new List<Shape2D>();
            List<string> shapes = new List<string>();
            RandomeNumber randomNum = new RandomeNumber();
            
            for(int i = 0; i < 10; i++)
            {
                int numberOnShape = Convert.ToInt32(randomNum.RandomNumberGenerator(0,2));
                string nameOnType = Enum.GetName(typeof(ShapeType), numberOnShape);

                switch(nameOnType)
                {
                    case "Rectangle":
                    Rectangle rectangle = new Rectangle(randomNum.RandomNumberGenerator(1, 100), randomNum.RandomNumberGenerator(1,100));
                    shapesin2D.Add(rectangle);
                    break;

                    case "Ellipse":
                    Ellipse ellipse = new Ellipse(randomNum.RandomNumberGenerator(1,100), randomNum.RandomNumberGenerator(1,100));
                    shapesin2D.Add(ellipse);
                    break;
                }
            }

                shapesin2D = shapesin2D.OrderBy(n => n.ShapeType).ThenBy(n => n.Area).ToList();
                    foreach(var s in shapesin2D)
                    {
                        shapes.Add(s.ToString("R"));
                    }
                    Console.WriteLine("Shapetype Length Width Perimeter Area");
                    foreach(var item in shapes)
                    {
                        Console.WriteLine("______________________________________");
                        Console.WriteLine(item);
                    }
        }


        private static void create3DList()
        {
           List<Shape3D> shapesin3D = new List<Shape3D>();
            List<string> shapes = new List<string>();
            RandomeNumber randomNum = new RandomeNumber();
            
            for(int i = 0; i < 10; i++)
            {
                int numberOnShape = Convert.ToInt32(randomNum.RandomNumberGenerator(2,5));
                string nameOnType = Enum.GetName(typeof(ShapeType), numberOnShape);

                switch(nameOnType)
                {
                    case "Cuboid":
                    Cuboid cuboid = new Cuboid(randomNum.RandomNumberGenerator(1, 100), randomNum.RandomNumberGenerator(1,100), randomNum.RandomNumberGenerator(1,100));
                    shapesin3D.Add(cuboid);
                    break;

                    case "Cylinder":
                    Cylinder cylinder = new Cylinder(randomNum.RandomNumberGenerator(1,100), randomNum.RandomNumberGenerator(1,100), randomNum.RandomNumberGenerator(1,100));
                    shapesin3D.Add(cylinder);
                    break;

                    case "Sphere":
                    Sphere sphere = new Sphere(randomNum.RandomNumberGenerator(1,100));
                    shapesin3D.Add(sphere);
                    break;
                }
            }

                shapesin3D = shapesin3D.OrderBy(n => n.ShapeType).ThenBy(n => n.Volume).ToList();
                    foreach(var s in shapesin3D)
                    {
                        shapes.Add(s.ToString("R"));
                    }
                    Console.WriteLine("Shapetype Length Width Height Mantelarea Totalsurfacearea Volume");
                    foreach(var item in shapes)
                    {
                    Console.WriteLine("____________________________________________");
                        Console.WriteLine(item);
                    
                    } 
        }



        public static void TestMyForms()
        {
            Rectangle rec = new Rectangle(5.7, 34.5);
            Console.WriteLine(rec.ToString("R"));
            Console.WriteLine(rec.ToString("G"));

            Ellipse elip = new Ellipse(5.7, 34.5);
            Console.WriteLine(elip.ToString("G"));

            Cuboid cub = new Cuboid(29.6, 29.6, 29.6);
            Console.WriteLine(cub.ToString("G"));

            Cylinder cyl = new Cylinder(29.6, 29.6, 29.6);
            Console.WriteLine(cyl.ToString("G"));

            Sphere sph = new Sphere(29.6);
            Console.WriteLine(sph.ToString("G"));
        }


        public static void ZeroValueForms()
        {
            Rectangle rec1 = new Rectangle(0, 0);
            
        }
    }
}
