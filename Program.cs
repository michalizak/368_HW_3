//Michali Zakutinsky
//T00399092
//Michali Zakutinsky
//T00399092
namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N\tN^2\tN^3\tN^2+N^3");
            Console.WriteLine();
            for (int i = 10; i <= 50; i += 10)
            {
                for (int x = 1; x <= 3; x++)
                {
                    Console.Write((Math.Pow(i,x)) + "\t");
                    if (x == 3)
                    {
                        Console.WriteLine((Math.Pow(i, 2)) + (Math.Pow(i, 3)));
                    }
                }
            }


        }


    }
}