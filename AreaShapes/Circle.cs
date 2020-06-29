using System;
namespace AreaShapes
{
    public class Circle
    {
        public double CircleArea(params double [] r)
        {
           
            return Math.PI * Math.Pow(r[0], 2);
        }
    }
}
