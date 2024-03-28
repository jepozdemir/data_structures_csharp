namespace CSharp.Tutorials.DataStructureTypes
{
	public struct Square
	{
		public int Side { get; set; }

		public Square(int side)
		{
			Side = side;
		}

		public int Perimeter()
		{
			return 4 * Side;
		}
	}
}
