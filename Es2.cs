namespace es
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(Environment.TickCount);
            int[] a = new int[30];
            for (int i = 0; i<30; i++)
            {
                a[i] = random.Next(0, 101);
                Console.Write(a[i] + "\t");
                
            }
            Console.WriteLine();
            for (int i = 0; i<30; i++)
            {
                for (int j = 0; j<30; j += 2)
                {
                    if (a[i]*2 == a[j])
                    {
                        Console.WriteLine($"Coppia di numeri: {a[i]} e {a[j]}");
                    }
                }
            }
        }
    }
}
