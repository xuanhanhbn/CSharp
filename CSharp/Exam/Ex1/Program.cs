using CSharp.Exam.Ex1;

namespace CSharp.Exam.Ex1
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            double radius;
            double height;
            Console.WriteLine("Enter the dimensions of the cylinder");
            Console.Write("Radius: ");
            var radiusInput = Console.ReadLine().ToString();
            Console.Write("Height: ");
            var heightInput = Console.ReadLine().ToString();
            try
            {
                radius = double.Parse(radiusInput);
                height = double.Parse(heightInput);
                var cylinder = new Cylinder(radius, height);
                cylinder.Process();
                cylinder.Result(out double baseArea, out double lateralArea, out double totalArea, out double volume);
                Console.WriteLine("Cylinder Characteristics");
                Console.WriteLine($"Raidus: {radius}, Height: {height}");
                Console.WriteLine($"Base: {baseArea}, ¦ Lateral: {lateralArea} ¦ Total: {totalArea} ¦ Volume: {volume}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid dimensions: {ex.Message}");
            }
        }
    }
}