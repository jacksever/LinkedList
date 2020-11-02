using System;

namespace List
{
	public class Minions : IComparable<Minions>
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public int TownId { get; set; }

		public Minions()
		{

		}
		public Minions(string name, int age, int townId)
		{
			Name = name;
			Age = age;
			TownId = townId;
		}

		public int CompareTo(Minions other)
		{
			int result = this.Name.CompareTo(other.Name);

			if (result == 0)
				result = this.Age.CompareTo(other.Age);

			return result;
		}
	}
}
