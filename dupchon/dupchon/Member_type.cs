/*
 * Created by SharpDevelop.
 * User: 66969
 * Date: 08/04/2020
 * Time: 12:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace dupchon
{
	/// <summary>
	/// Description of Member_type.
	/// </summary>
	public partial class Member_type : Form
	{
		public Member_type()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			
				 
				Membership form2 = new Membership();
				form2.Show();
				this.Close();
   
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			    Member form1 = new Member();
				form1.Show();
				this.Close();
   
		}
		
		void Button4Click(object sender, EventArgs e)
		{
				Out form1 = new Out();
				form1.Show();this.Close();
		}
		
		
		
		void Button20Click(object sender, EventArgs e)
		{
			LoginForm form1 = new LoginForm();
			form1.Show();
			this.Close();
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			Order form1 = new Order();
			form1.Show();
			this.Close();
		}
	}
}
