using System;
namespace console_app2.Classes
{
	public class Person
	{
		protected string name;
		protected int age;
		public string Name { get { return name; } set { name = value; } }
		public int Age { get { return age; } set { age = value; } }

		public Person(string name, int age)
		{
			this.name = name;
			this.age = age;
		}

        public virtual bool Equals(Person? other)
        {
			if ((other == null) || !this.GetType().Equals(other.GetType()))
			{
				return false;
			}
			else
			{
				Person p = (Person)other;
				return (name == p.name) && (age == p.age);
			}
		}
		public override string ToString()
        {
			return $"Name: {this.name}, Age: {this.age}";
        }
	}
}

