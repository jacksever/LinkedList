using System;

namespace List
{
	public class Program
	{
		static void Main(string[] args)
		{
			MyLinkedList<Minions> List = new MyLinkedList<Minions>();

			Minions minion = new Minions("Ivan", 44, 5);

			Console.WriteLine("-----------Add----------");
			List.AddFirst(new Minions("Alvin", 18, 1));
			List.AddFirst(new Minions("Mash", 12, 4));
			List.AddLast(minion);
			List.AddFirst(new Minions("Den", 21, 1));
			ReturnListItem(List);

			Console.WriteLine("--------------Remove first------------");
			List.RemoveFirst();
			ReturnListItem(List);

			Console.WriteLine("--------------Add new items------------");
			List.AddLast(new Minions("Boris", 18, 1));
			List.AddFirst(new Minions("Clava", 44, 3));
			ReturnListItem(List);

			Console.WriteLine("--------------Remove last------------");
			List.RemoveLast();
			ReturnListItem(List);

			Console.WriteLine("--------------Edit By Object------------");
			List.EditByObject(minion, new Minions("Roman", 20, 4));
			ReturnListItem(List);

			Console.WriteLine("--------------Edit By Index------------");
			List.EditByIndex(2, new Minions("Dima", 10, 2));
			ReturnListItem(List);

			Console.WriteLine("--------------Clear List------------");
			List.Clear();
			ReturnListItem(List);
		}

		static void ReturnListItem(MyLinkedList<Minions> List)
		{
			foreach (var item in List)
			{
				Console.WriteLine("Minion: {0} {1} {2}", item.Name, item.Age, item.TownId);
			}
			Console.WriteLine("Size: " + List.Size());
		}
	}
}
