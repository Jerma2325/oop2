using System;
namespace console_app2.Classes
{
	public class Classroom
	{
		private string name;
		private string Name { get { return name; } set { name = value; } }
		private Person[] persons;
		public Classroom(string name,Person [] persons)
		{
			this.name = name;
			this.persons = persons;

		}
		public override string ToString()
		{
			string result = "";
			result += $"Classroom: {this.name}\n";
			for (int i = 0; i < persons.Length; i++)
			{
				result += persons[i].ToString();
			}
			result += "\n\t";
			return result;
		}
	}
}

