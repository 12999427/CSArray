using System;
					
public class Program
{
	static bool find(int[,] matrice, int len, int i, int j)
	{
		for (int z = 0; z<len; z++)
		{
			if (matrice[z, 0] == j && matrice[z, 1] == i)
			{
				return false;
			}
		}
		return true;
	}
	
	public static void Main()
	{
		float[] a = new float[100];
		float somma = 0;
		int lung = 100;
		for (int i = 0; i<a.Length; i++)
		{
			do {
				Console.WriteLine("inserisci numero");
			} while (!float.TryParse(Console.ReadLine(), out a[i]));
			somma += a[i];
			if (somma >= 50)
			{
				lung = i+1;
				break;
			}
		}			
		if (lung<3)
		{
			Console.WriteLine("Meno di 3 valori");
			return;
		}
		Console.WriteLine($"Rapporto da trovare: {a[0]}");
		int[,] trovati = new int[100, 2];
		int lentrov = 0;
		
		for (int i = 0; i<a.Length; i++)
		{
			for (int j = 0; j<a.Length; j++)
			{
				if (a[i] / a[j] == a[0] && i!=j)
				{
					if (find(trovati, lentrov, i, j))
					{
						Console.WriteLine($"{a[i]} e {a[j]} (indici {i} e {j})");
						trovati[lentrov, 0] = i;
						trovati[lentrov, 1] = j;
						lentrov++;
					}
				}
			}
		}
	}
}
