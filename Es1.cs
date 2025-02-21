using static System.Console;

namespace es
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lung = 0;
            do
            {
                WriteLine("dimmi la lunghezza dell'array");
            } while (!Int32.TryParse(ReadLine(), out lung) || lung <= 0);
            int[] numeri = new int[lung];

            for (int i = 0; i < numeri.Length; i++)
            {
                do
                {
                    WriteLine("dimmi il numero");
                } while (!Int32.TryParse(ReadLine(), out numeri[i]));
            }

            for (int j = 0; j < numeri.Length; j++)
            {
                if (j != numeri.Length-1)
                {
                    if (numeri[j] == numeri[j+1])
                    {
                        WriteLine("0");
                        return;
                    }
                }
            }
            WriteLine("1");
        }
    }
}
