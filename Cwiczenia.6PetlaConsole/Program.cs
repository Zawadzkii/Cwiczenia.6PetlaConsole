using System;

class Program
{
	static double HarmonicSum(int n)
	{
		double total = 0.0;
		for (int i = 1; i <= n; i++)
		{
			total += 1.0 / i;
		}
		return total;
	}

	static void Main(string[] args)
	{
		for (int i = 1; i <= 20; i++)
		{
			double result = HarmonicSum(i);
			Console.WriteLine($"Suma dla {i} elementów: {result}");
		}
	}
}