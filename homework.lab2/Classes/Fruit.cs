using System;
namespace homework.lab2.Classes
{
	public class Fruit: Product
	{
		public int Count { get; set; }
		public Fruit(string name, int count ): base(name)
		{
			base.Name = name;
			Count = count;
		}
		public override void Print(string prefix)
        {
			Console.WriteLine(prefix + $"{this.Name} ({Count} {(Count > 1 ? "fruit" : "fruits")})");
        }
	}
}

