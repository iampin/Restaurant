/*
 * Created by SharpDevelop.
 * User: najnnjj
 * Date: 9/4/2563
 * Time: 11:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace dupchon
{
	/// <summary>
	/// Description of Method.
	/// </summary>
	public partial class Method : Form
	{
		public Method()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CmdEatInClick(object sender, EventArgs e)
		{
			Table form1 = new Table();
			form1.Show();
			this.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Task form2 = new Task();
			form2.Show();
			this.Close();
		}
		
		void CmdTakeAwayClick(object sender, EventArgs e)
		{
			Order form1 = new Order();
			form1.Show();
			this.Close();
		}
		
		
		
		void Button17Click(object sender, EventArgs e)
		{
			LoginForm form1 = new LoginForm();
			form1.Show();
			this.Close();
		}
	}
}
