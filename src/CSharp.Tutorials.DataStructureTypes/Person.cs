namespace CSharp.Tutorials.DataStructureTypes
{
	public class Person
	{
		public string Name { get; }
		public int Age { get; set; }

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public void Greetings()
		{
			Console.WriteLine($"Hi, my name is {Name}.");
		}
	}
}
