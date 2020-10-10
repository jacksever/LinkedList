
namespace List
{
	public class Minions
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
	}
}
