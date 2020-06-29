using System;

namespace AreaShapes
{
    public class Shapes
    {
        public static double Area(params double[] arg)

        { 
            double area = 0;

            if (arg.Length == 1)
            {
                if (arg[0] > 0)
                {
                    Circle circle = new Circle();
                    area = circle.CircleArea(arg);
                }
                else {
                    throw new Exception("Invalid value");
                }
            }
            else if (arg.Length == 3)
            {
                if (arg[0] > 0 && arg[1] > 0 && arg[2] > 0)
                {
                    Triangle triangle = new Triangle();

                    // Сортировка для последующей проверки является ли треугольник прямоугольным

                    Array.Sort(arg);

                    var a = arg[0];
                    var b = arg[1];
                    var c = arg[2];
                    area = triangle.TriangleArea(a, b, c);
                }
                else
                {
                    throw new Exception("Invalid value");
                }
              

            }
            return area;
        }
    }
}
