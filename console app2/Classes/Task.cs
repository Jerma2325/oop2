using System;
namespace console_app2.Classes
{
	public class Task
	{
		private string name;
		private TaskStatus status;
		public string Name { get { return name; } set { name = value; } }
		public TaskStatus Status { get { return status; } set { status = value; } }

		public Task(string name,TaskStatus status)
		{
			this.name = name;
			this.status = status;
		}
        public override string ToString()
        {
			return $"{name} [{status}]";
        }
    }
}

