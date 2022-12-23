namespace Ders_Ev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A-ni daxil et");

                double a = double.Parse(Console.ReadLine());
            Console.Write("B-ni daxil et");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");
            
            

            Console.WriteLine("Congurlations!");
        }
    }
}