using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Exam.Ex1
{
    internal class Cylinder
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        public double BaseArea { get; private set; }
        public double LateralArea { get; private set; }
        public double TotalArea { get; private set; }
        public double Volume { get; private set; }

        public Cylinder(double radius, double height)
        {
            if (radius == null || height == null || radius <= 0 || height <= 0) throw new ArgumentNullException("Invalid Dimensions");
            Radius = radius;
            Height = height;
        }
        public void Process()
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }
        public void Result(out double baseArea, out double lateralArea, out double totalArea, out double volume)
        {
            baseArea = Math.Round(BaseArea, 2);
            lateralArea = Math.Round(LateralArea, 2);
            totalArea = Math.Round(TotalArea, 2);
            volume = Math.Round(Volume, 2);
        }
    }
}
