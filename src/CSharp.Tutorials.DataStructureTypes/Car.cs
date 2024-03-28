namespace CSharp.Tutorials.DataStructureTypes
{
	public abstract record Vehicle
	{
		public string Brand { get; set; }
	}

	public record Car : Vehicle
	{
		public int MaxSpeed { get; set; }

		public int Speed { get; set; }

		public void SpeedUp()
		{
			Speed += 10;
		}
	}

	public record LuxuryCar(string brand, int maxSpeed);
}
