using System;
namespace homework.lab2.Classes
{
	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public Person(string name,int age)
		{
			Name = name;
			Age = age;
		}
		public virtual void Print(string prefix)
        {
			Console.WriteLine($"{prefix}-- People: --");
        }
	}
}

