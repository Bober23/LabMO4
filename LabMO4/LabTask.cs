using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMO4
{
    class LabTask
    {
        MyVector x;
        double r;
        public LabTask(MyVector x, double r)
        {
            this.x = x;
            this.r = r;
        }
        public void DoTask()
        {
            double e = 0.05;
            int m = 100;
            double r = 1;
            double c = 4;
            for (int i = 0; i < 1000; i++)
            {
                x = GradientDescent.GetMinPoint(x.x1, x.x2, m, 0.15, 0.2, r);
                if (LabFuctions.GetPFunction(x,r)<=e)
                {
                    Console.WriteLine($"Ответ получен на {i+1} итерации:");
                    Console.WriteLine($"P = {LabFuctions.GetPFunction(x, r)}");
                    Console.WriteLine($"X = ({x.x1}, {x.x2})");
                    Console.WriteLine($"f(x) = {LabFuctions.GetDefaultFunction(x)}");
                    Console.WriteLine($"R = {r}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Конец итерации {i+1}");
                    Console.WriteLine($"P = {LabFuctions.GetPFunction(x, r)}");
                    Console.WriteLine($"X = ({x.x1}, {x.x2})");
                    Console.WriteLine($"f(x) = {LabFuctions.GetDefaultFunction(x)}");
                    Console.WriteLine($"R = {r}");
                    r *= c;
                }
            }
            

        }
    }
}
