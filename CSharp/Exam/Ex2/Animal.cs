using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Exam.Ex2
{
    internal class Animal
    {
        public double Weight { get; set; }
        public string Name { get; set; }
        public virtual void Show()
        {
            Console.WriteLine($"Name: {Name}, Weight: {Weight}");
        }

        public virtual void SetMe(double weight, string name)
        {
            Weight = weight;
            Name = name;
        }
    }
}
