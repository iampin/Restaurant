/*
 * Created by SharpDevelop.
 * User: najnnjj
 * Date: 16/4/2563
 * Time: 10:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace dupchon
{
	/// <summary>
	/// Description of Global.
	/// </summary>
	public class Global
	{
		 public static int tablenumber;
		 public static string active_user_role="";
		 public static string active_user_name="";
		 public static string active_user_id="";
		 public static string menu_order="";
		 public static string active_member_firstname="";
		 public static string active_member_lastname="";
		 public static string active_member_id="";
		 public static string active_member_phone="";
		 public static List<OrderItem> orders = new List<OrderItem>();
		 
	}
}
