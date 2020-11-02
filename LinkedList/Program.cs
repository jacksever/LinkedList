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

			Console.WriteLine("--------------Compare Minions------------");
			
			Minions minionFirst = new Minions("Martin", 19, 3);
			Minions minionSecond = new Minions("Martin", 19, 3);

			Console.WriteLine(minionFirst.CompareTo(minionSecond)); // Output: 0

			MinionsComparator comparator = new MinionsComparator();
			Console.WriteLine(comparator.Compare(minionFirst, minionSecond)); // Output: 0

			Console.WriteLine("--------------Indexing------------");
			
			MyLinkedList<Minions> ListIndex = new MyLinkedList<Minions>();

			ListIndex.AddLast(minionFirst);
			ListIndex.AddLast(new Minions("Alex", 20, 1));

			Console.WriteLine(ListIndex[0].Name + " " + ListIndex[0].Age);
			Console.WriteLine(ListIndex[1].Name + " " + ListIndex[1].Age);

			Console.WriteLine("--------------Stack------------");
			StackTesting();

		}

		static void ReturnListItem(MyLinkedList<Minions> List)
		{
			foreach (var item in List)
			{
				Console.WriteLine("Minion: {0} {1} {2}", item.Name, item.Age, item.TownId);
			}
			Console.WriteLine("Size: " + List.Size());
		}

		static void StackTesting()
		{
			var list = new Stack<string>();

			list.Push("USA");
			list.Push("Russia");
			list.Push("Italy");
			list.Push("France");
			list.Push("Germany");
			list.Push("Canada");

			Console.WriteLine(list.Pop());
			Console.WriteLine(list.Pop());

			Console.WriteLine("---------");

			foreach (var l in list)
				Console.WriteLine(l);

			Console.WriteLine("Capacity: {0}", list.Capacity);
			Console.WriteLine("Size now: {0}", list.Size());
		}
	}
}
