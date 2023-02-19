//Michali Zakutinsky
//T00399092
//Extra Credit

Console.Write("Enter a length: ");
String len = Console.ReadLine();
double length = double.Parse(len);

Console.Write("Enter a width: ");
String wid = Console.ReadLine();
double width = double.Parse(wid);

//according to the instructions it was unclear whether is length and width was 10 and 15 or either one was.
if (length < 1 || width<1)
{
    length = 1;
    width=1;
}
if(length>15 && width>10)
{
    length = 15;
    width = 10;
}

for (int w = 1; w <= width; w++)
{
    //Console.WriteLine("*");
    for (int l=1;l<=length;l++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
