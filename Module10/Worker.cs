using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public class Worker : IWorker
    {
        ISum Sum { get; }
        public Worker(ISum sum) 
        { 
            Sum = sum;
        }

        public void Work(int a, int b)
        {
            Sum.Sum(a, b);
        }
    }
}
