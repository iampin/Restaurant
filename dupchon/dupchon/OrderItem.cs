/*
 * Created by SharpDevelop.
 * User: najnnjj
 * Date: 28/4/2563
 * Time: 14:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace dupchon
{
	/// <summary>
	/// Description of OrderItem.
	/// </summary>
	public class OrderItem
	{
		public string name;
		public double qty;
		public double each;
		public double total;
		public OrderItem(string name, double qty, double each, double total)
		{
			this.name = name;
			this.qty = qty;
			this.each = each;
			this.total = total;
		}
		
		public OrderItem()
		{
		}
	}
}
