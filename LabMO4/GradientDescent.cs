using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LabMO4
{
    static class GradientDescent
    {
        static double GetFunction(MyVector x, double r)
        {
            return 8 * Math.Pow(x.x1, 2) + Math.Pow(x.x2, 2) - 4 + r / 2 * Math.Pow(x.x1 + 3 * x.x2 + 6, 2);
        }
        static MyVector GetGradient(MyVector x,double r)
        {
            var gradient = new MyVector(16 * x.x1 + r * (x.x1 + 3 * x.x2 + 6), 2 * x.x2 + 3 * r * (x.x1 + 3 * x.x2 + 6));
            return gradient;
        }
        static double GetNorma(MyVector vector)
        {
            return Math.Sqrt(Math.Pow(vector.x1,2)+Math.Pow(vector.x2,2));
        }
        public static MyVector GetMinPoint(double x1,double x2, int maxNumberOfIterations, double e1,double e2, double r)
        {
            MyVector xCurrent = new MyVector(x1,x2); //1
            for (int k = 0; k < maxNumberOfIterations; k++) //2 and 5
            {
                MyVector gradient = GetGradient(xCurrent,r); //3
                if (GetNorma(gradient) < e1)
                {
                    return xCurrent; //4
                }
                double t = 0.5; //6
                MyVector xNext;
                do
                {
                    xNext = new MyVector(xCurrent.x1 - t * gradient.x1, xCurrent.x2 - t * gradient.x2); //7
                    t = t / 2;  //8
                } while (GetFunction(xNext,r) - GetFunction(xCurrent,r) >= 0);
                if (GetNorma(new MyVector(xNext.x1 - xCurrent.x1, xNext.x2 - xCurrent.x2)) < e2)
                {
                    if (Math.Abs(GetFunction(xNext, r) - GetFunction(xCurrent, r)) < e2)
                    {
                        return xNext;
                    }
                }
                xCurrent = xNext;
            }
            return xCurrent;
        }
    }
}
