using LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;

namespace List
{
	public class MyLinkedList<T> : IEnumerable<T>
	{
		private Node<T> head;
		private Node<T> tail;
		private int size;

		public MyLinkedList() 
		{
			this.head = null;
			this.tail = null;
			this.size = 0;
		}

		public void AddLast(T element)
		{
			Node<T> newNodes = new Node<T>(element);

			if (element == null)
			{
				Console.WriteLine("Error: The entered value is null");
				return;
			}

			if (this.head == null)
			{
				this.head = newNodes;
				this.tail = newNodes;
			}
			else
			{
				this.tail.Next = newNodes;
				newNodes.Previous = this.tail;
			}

			this.tail = newNodes;
			this.size++;
		}

		public void AddFirst(T element)
		{
			Node<T> newNodes = new Node<T>(element);

			if (element == null)
			{
				Console.WriteLine("Error: The entered value is null");
				return;
			}

			if (this.head != null)
			{
				newNodes.Next = this.head;
				this.head.Previous = newNodes;
			}

			if (size == 0)
			{
				this.head = newNodes;
				this.tail = newNodes;
			}

			this.head = newNodes;
			this.size++;
		}

		public void RemoveFirst()
		{
			if (this.size == 0)
			{
				Console.WriteLine("Error: List is empty");
				return;
			}

			if (this.size == 1)
			{
				this.head = null;
				this.tail = null;
			}

			if (this.size > 1)
			{
				Node<T> newNodes = this.head.Next;
				this.head = newNodes;
			}
			this.size--;
		}

		public void RemoveLast()
		{
			if (this.size == 0)
			{
				Console.WriteLine("Error: List is empty");
				return;
			}
		
			if (this.size == 1)
			{
				this.head = null;
				this.tail = null;
			}

			if (this.size > 1)
			{
				Node<T> newNodes = this.tail;
				if (newNodes.Next == null)
				{
					this.tail = newNodes.Previous;
					this.tail.Next = null;
					this.tail.Previous = this.tail.Previous.Previous;
				}
			}
			this.size--;
		}

		public void EditByObject(T elementOld, T elementNew)
		{
			if (elementOld == null)
			{
				Console.WriteLine("Error: The entered value is null");
				return;
			}

			if (elementNew == null)
			{
				Console.WriteLine("Error: The entered value is null");
				return;
			}

			Node<T> newNodes = this.head;
			while (newNodes != null)
			{
				if (newNodes.Element.Equals(elementOld))
				{
					newNodes.Element = elementNew;
				}
				newNodes = newNodes.Next;
			}
		}

		public void EditByIndex(int index, T element)
		{

			if (element == null)
			{
				Console.WriteLine("Error: The entered value is null");
				return;
			}

			if (this.size == 0)
			{
				Console.WriteLine("Error: List is empty");
				return;
			}

			if (index > this.size)
			{
				Console.WriteLine("Error: Index too large");
				return;
			}

			if (index == 0 || index < 0)
			{
				Console.WriteLine("Error: Index <= 0");
				return;
			}

			Node<T> headNodes = this.head;

			for (int i = 0; i < index - 1; i++)
			{
				headNodes = headNodes.Next;
			}

			headNodes.Element = element;
		}

		public void Clear()
		{
			this.head = null;
			this.tail = null;
			this.size = 0;
		}

		public int Size()
		{
			return this.size;
		}

		public IEnumerator<T> GetEnumerator()
		{
			Node<T> newNodes = head;

			while (newNodes != null)
			{
				yield return newNodes.Element;
				newNodes = newNodes.Next;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)this).GetEnumerator();
		}
	}
}
