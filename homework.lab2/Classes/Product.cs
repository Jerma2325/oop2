using System;
namespace homework.lab2.Classes
{
	public class Product :IThing
	{
		public string Name { get; set; }
		public Product(string name)
		{
			Name = name;
		}

		public virtual void Print(string prefix)
        {
			Console.WriteLine($"{prefix}-- Products: --");
        }
    }
}

