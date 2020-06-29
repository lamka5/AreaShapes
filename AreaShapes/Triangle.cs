using System;
namespace AreaShapes
{
    public class Triangle
    {
        public double TriangleArea(double side1, double side2, double side3)
        {
            double  area = 0;
            double PP = 0;

            // Является ли фигура треульником
            if ((side1 + side2) > side3 )
            {
                //Является ли треугольник прямоугольным

                if (Math.Pow(side1, 2) + Math.Pow(side2, 2) == Math.Pow(side3, 2))
                {
                    area = (side1 * side2) / 2;
                    return area;
                }
                else
                {
                    PP = (side1 + side2 + side3) / 2;
                    area = Math.Sqrt(PP * (PP - side1) * (PP - side2) * (PP - side3));
                    return area;
                }

            }
            else
            {
                throw new Exception("is not triangle");
            }
        }
    }
}
