using System;
namespace homework.lab2.Classes
{
	public class Meat: Product
	{
		public double Weight { get; set; }

		public Meat(string name, double weight):base (name)
		{
			base.Name = name;
			Weight = weight;
		}
		public override void Print(string prefix)
        {
			Console.WriteLine($"{prefix}{Name} ({Weight} kg)");
        }
	}
}

