using System;
namespace homework.lab2.Classes
{
	public class Buyer: Person
	{
		protected List<Product> products = new List<Product>();

		public Buyer(string name, int age): base(name,age)
		{
			base.Age = age;
			base.Name = name;
		}

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(int index)
        {
            products.RemoveAt(index);
        }
        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + $"Buyer: {Name} ({Age} y.o.)");
            if (products.Count != 0)
            {
                Console.WriteLine(prefix + "\t" + "-- Products: --");
            }
            foreach (Product product in products)
            {
                product.Print(prefix + "\t");
            }
        }
    }
}

