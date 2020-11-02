using System;
using System.Collections;
using System.Collections.Generic;

namespace List
{
	class Stack<T> : IEnumerable<T>
	{
		private readonly int initialCapacity = 2;
		private T[] elements;
		private int count;

		public Stack()
		{
			this.count = 0;
			this.elements = new T[this.initialCapacity];
		}

		public int Capacity
		{
			get
			{
				return this.elements.Length;
			}
		}

		public void Push(T item)
		{
			this.elements[this.count] = item;
			this.count++;

			if (this.count == this.Capacity)
			{
				this.Expand();
			}
		}

		public T Pop()
		{
			if (this.Capacity == 0)
			{
				throw new Exception("Stack is empty..");
			}

			var element = this.elements[this.count - 1];
			count--;

			return element;
		}

		public T Peek()
		{
			if (this.Capacity == 0)
			{
				throw new Exception("Stack is empty..");
			}

			return this.elements[this.count - 1];
		}

		public int Size()
		{
			return this.count;
		}

		public void Clear()
		{
			this.elements = new T[this.initialCapacity];
			this.count = 0;
		}

		private void Expand()
		{
			var copy = new T[this.Capacity * 2];

			for (int i = 0; i < this.Capacity; i++)
			{
				copy[i] = elements[i];
			}

			this.elements = copy;
		}

		public IEnumerator<T> GetEnumerator()
		{
			for (int i = this.count - 1; i >= 0; i--)
			{
				yield return this.elements[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
