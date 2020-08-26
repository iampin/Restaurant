/*
 * Created by SharpDevelop.
 * User: 66969
 * Date: 16/04/2020
 * Time: 14:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace dupchon
{
	/// <summary>
	/// Description of Food.
	/// </summary>
	public class Menu
	{
		public int foodID;
		public string category;
		public string name;
		public double price;
		public string image;
		
		public Menu(){
		}
		
		public Menu(int foodID, string category, string name, double price, string image)
		{
			this.foodID = foodID;
			this.category = category;
			this.name = name;
			this.image = image;
		}
	}
}
