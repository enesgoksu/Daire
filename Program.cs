class Program
{
    static void Main(string[] args)
    {
       Console.Write("Dairenin yarı çapını girin: ");
       int radius = int.Parse(Console.ReadLine());

       DrawCircle(radius);

       static void DrawCircle(int radius)
       {
        for (double x = -radius; x <= radius; x++)
        {
            for (double y = -radius; y <= radius; y++)
            {
                if (x * x + y * y >= radius * radius)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
       }
    }
}
