using System;
using System.Globalization

public class Class1
{
	public Class1()
	{
		double b, a, area, perimetro, diagonal;

		b = double.Parse(Console.ReadLine), CultureInfo.InvariantCulture);
		a = double.Parse(Console.ReadLine), CultureInfo.InvariantCulture);

		area = b * a;
		perimetro = 2 * b + 2 * a; // ou = 2* (b+a);
		diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

        Console.WriteLine("ÁREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
		Console.WriteLine("PERÍMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

		Console.ReadLine();




	}
}
