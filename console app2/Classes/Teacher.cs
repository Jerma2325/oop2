using System;
namespace console_app2.Classes
{
	public class Teacher : Person
	{
		public Teacher(string name, int age) : base	(name,age)
		{
			base.name = name;
			base.age = age;
		}

        public override string ToString()
        {
			return $"\t\nTeacher: {base.name} ({base.age} y.o)\n\t" ;
        }
    }
}

