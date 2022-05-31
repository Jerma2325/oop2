using System;
namespace homework.lab2.Classes
{
	public class Seller:Person
	{

		public Seller(string name,int age):base (name,age)
		{
			Name = name;
			Age = age;
		}
		public override void Print(string prefix)
        {
			Console.WriteLine($"{prefix}Seller: {Name} ({Age} y.o.)");
        }
	}
}

