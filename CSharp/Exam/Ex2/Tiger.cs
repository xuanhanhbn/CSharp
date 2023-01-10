using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Exam.Ex2;

namespace CSharp.Exam.Ex2
{
    internal class Tiger : Animal
    {
        public Tiger(double weight)
        {
            base.SetMe(weight, "Tiger");
        }
    }
}
