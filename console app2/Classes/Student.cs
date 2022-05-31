using System;

using System.Collections.Generic;

namespace console_app2.Classes
{
	public class Student:Person
	{
		protected string group;
		protected List<Task> tasks = new List<Task>();
		

		public Student(string name,int age,string group):base (null,0)
		{
			base.name = name;
			base.age = age;
			this.group = group;
		}
		public Student (string name, int age, string group,List<Task> tasks) : base(name, age)
		{
			base.name = name;
			base.age = age;
			this.group = group;
			this.tasks = tasks;
		}
		public void AddTask(string taskName,TaskStatus taskStatus)
        {
			tasks.Add(new Task(taskName, taskStatus));
        }
		public void RemoveTask(int index)
        {
			
			tasks.RemoveAt(index);
        }
		public void UpdateTask(int index,TaskStatus taskStatus)
        {
			tasks[index].Status = taskStatus;
			
		}
		public string RenderTasks(string prefix = "\t")
        {
			return prefix += tasks.ToString();
        }
		public override string ToString()
        {
			
			string result = $"\t\nStudent: {this.name} ({this.age} y.o.)\n";
			result += $"Group: {this.group}\n";
			result += "Tasks:";
			for (int i = 0; i < tasks.Count; i++)
			{
					result += $"{"\t\n "}{i + 1}. {this.tasks[i]}";
					
			}
			result += "\t\n";
			return result;
		}
		private bool SequanceEqual (List<Task>a,List<Task>b)
		{
			if (a != null)
			{
				return a.Equals(b);
			}
			else return false;
		}

		public bool Equals( Student stud)
        {
		return Object.Equals(stud.name, this.name) && Object.Equals(stud.age, this.age) && Object.Equals(this.group, stud.group);

		}
	}
}

