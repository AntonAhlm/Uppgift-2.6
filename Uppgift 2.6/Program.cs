using System; 

namespace Program
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Skriv in 2 tal");
            Console.Write("Tal 1 : ");
            double tal1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Tal 2 : ");
            double tal2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Medelvärdet är "+((tal1+tal2)/2));


        }
    }
}