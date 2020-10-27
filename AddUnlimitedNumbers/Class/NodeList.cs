using System;

namespace AddUnlimitedNumbers.Class
{
	internal class NodeList
	{
		public int Value { get; set; }
		public NodeList Next { get; set; }
		public NodeList(int value = 0, NodeList next = null)
		{
			this.Next = next;
			this.Value = value;
		}

		public NodeList(string value)
		{
			NodeList node = ToNodeList(value);
			this.Next = node.Next;
			this.Value = node.Value;
		}

		private NodeList ToNodeList(string value)
		{
			NodeList first = new NodeList();
			NodeList current = first;
			NodeList next = first;

			foreach (var num in value)
			{
				current = next;
				current.Value = int.Parse(num.ToString());
				next = new NodeList();
				current.Next = next;
			}

			current.Next = null;

			return first;
		}
		 
		internal NodeList Add(NodeList firstList, NodeList secondList)
		{
			int sum = 0;
			int extra = 0;
			NodeList first = new NodeList();
			NodeList current = first;
			NodeList next = first;

			while (firstList != null || secondList != null)
			{
				current = next;
				sum = (firstList?.Value ?? 0) + (secondList?.Value ?? 0) + extra;
				current.Value = sum % 10;
				extra = sum > 9 ? 1 : 0;
				firstList = firstList?.Next;
				secondList = secondList?.Next;
				next = new NodeList();
				current.Next = next;
			}

			current.Next = null;

			if (extra == 1)
			{
				current.Next = new NodeList(1);
			}

			return first;
		}
	}
}
