using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class Items
    {
		private String Item;

		public String ItemName
		{
			get { return Item; }
			set { Item = value; }
		}

		private float Price;

		public float TotalPrice
		{
			get { return Price; }
			set { Price = value; }
		}


		private int Amount;

		public int AmountRequested
		{
			get { return Amount; }
			set { Amount = value; }
		}

		public Items()
		{

			this.items = new List<string>();
		}

		public List<string> items { get; set; }


		



	}
}
