//Michali Zakutinsky
//T00399092

Console.WriteLine("Hello, World!");
Console.WriteLine("begin program 3.");
Console.WriteLine("testing commit.")
Console.WriteLine("N\tN^2\tN^3\tN^2+N^3");
Console.WriteLine();
while (Console.ReadLine() != null)
{
    for (int i = 10; i <= 10000000; i += 10)
    {
        for (int x = 1; x <= 3; x++)
            {
                Console.Write(i ^ x + "\t");
                if (x == 3)
                {
                    Console.Write((i ^ 2) + (i ^ 3));
                }
            }
    }
    
}