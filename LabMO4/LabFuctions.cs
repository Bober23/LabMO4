using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMO4
{
    static class LabFuctions
    {
        public static double GetDefaultFunction(MyVector x)
        {
            return 8*Math.Pow(x.x1,2)+Math.Pow(x.x2,2)-4;
        }
        public static double GetMainFunction(MyVector x, double r)
        {
            return GetDefaultFunction(x)+r/2*Math.Pow(x.x1+3*x.x2+6,2);
        }
        public static double GetX1Grad(MyVector x, double r)
        {
            return 16 * x.x1 + r * (x.x1 + 3 * x.x2 + 6);
        }
        public static double GetX2Grad(MyVector x, double r)
        {
            return 2 * x.x1 + 3 * r * (x.x1 + 3 * x.x2 + 6);
        }
        public static double GetPFunction(MyVector x,double r)
        {
            return r/2*Math.Pow(x.x1+3*x.x2+ 6,2);
        }
    }
}
