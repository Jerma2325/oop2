using System;
namespace homework.lab2.Classes
{
	public class Shop
	{
		public string Name { get; set; }
		private Person[] people;
		private Product[] products;
		public Shop(string name, Person[] people, Product[]products)
		{
			Name = name;
			this.people = people;
			this.products = products;
		}
		public void Print()
        {
			Console.WriteLine($"Shop: {Name}");
			var person1 = new Person("",0);
			person1.Print("");
            foreach (var person in people)
            {
				person.Print("\t");
            }
			var prodo = new Product("");
			prodo.Print("");
            foreach (var product in products)
            {
				product.Print("\t");
            }
        }
	}
}

