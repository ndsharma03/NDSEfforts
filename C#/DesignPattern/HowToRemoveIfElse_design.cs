using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    #region Problem Statement

    // Suffix '"_Problem' added to each Type Name to differenciate it form solution example.
    public enum ShapeType { Circle,Rectangle}
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class Shape_problem
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
        public ShapeType Type { get; set; }
    }

    public class Canvas_Problem 
    {
        // Problem : Each time when a new Shape introduced 
        // Need to change this method, compile class and it's 
        // dependent classes if any.
        public void DrawShape(List<Shape_problem> shapes) 
        {
            foreach(Shape_problem s in shapes) {
                switch (s.Type)
                {
                    case ShapeType.Circle:
                        //Drawing logic for Circle;
                        break;
                    case ShapeType.Rectangle:
                        //Drawing Logic for Ractangle;
                        break;
                    default:                        // Need to change here if any new shape introduced in the system.
                        break;

                }
            }
        }
    }
    #endregion

    #region Solution 
    // 1.  Shape class should contain Drawing logic in itself.


    #endregion
   public abstract class Shape
    {
        public int Height { get; set; }
        public int Width {  get; set; }
        public Position MyProperty { get; set; }
        public abstract void Draw();
    }
    public class Rectangle : Shape
    {
        public Rectangle(int height,int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override void Draw()
        {
            Console.WriteLine($" Drawing Ractangle of width ={Width} and Height ={Height}");
        }
    }
    public class Circle : Shape
    {
        public Circle(int height, int width) // Assuming that we will draw a circle within given height and width ractangle 
                                             // We will calculate radius by ourselve ..just for time being ..it's not correct implementation.
        {
            this.Height = height;
            this.Width = width;
        }

        public override void Draw()
        {
            Console.WriteLine($" Drawing Circle within ractangle of  width ={Width} and Height ={Height}");
        }
    }
    /// <summary>
    /// By encapsulating logic of draw in Shape class we can remove conditions from Canvas Class 
    /// it's also use of polymorphism.
    /// </summary>
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach(Shape s in shapes)
            {
                s.Draw();
            }
        }
    }

    public class TestCanvas
    {
        //public static void Main()
        //{
        //    List<Shape> shapes = new List<Shape>
        //    {
        //        new Rectangle(30,50),
        //        new Circle(10,10)
        //    };

        //    Canvas canvas = new Canvas();
        //    canvas.DrawShapes(shapes);
        //    Console.Read();
        //}

        public static void Main()
        {
        
            Console.WriteLine(default(object) is null ? "Null":"Value");
            Console.Read();
        }
    }
}
