using System.Collections.Generic;

namespace List
{
	class MinionsComparator : IComparer<Minions>
	{
		public int Compare(Minions x, Minions y)
		{
			var result = x.Name.CompareTo(y.Name);

			if (result == 0)
				result = x.Age.CompareTo(y.Age);

			return result;
		}
	}
}
