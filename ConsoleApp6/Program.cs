using System;
namespace hej
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång hoppade Alma");
            string längd=Console.ReadLine();
            int I = int.Parse(längd);
            Console.WriteLine("Hur Mycket längre hoppade elin?");
            string Y = Console.ReadLine();
            int J = int.Parse(Y);
            double x = J + I;
            Console.WriteLine("Elin hoppade" +x);
            
             
        }
    }
}