/*
 * Created by SharpDevelop.
 * User: najnnjj
 * Date: 8/4/2563
 * Time: 21:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace dupchon
{
	/// <summary>
	/// Description of Task.
	/// </summary>
	public partial class Task : Form
	{
		public Task()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CmdMenuManagementClick(object sender, EventArgs e)
		{
			MenuManagement form1 = new MenuManagement();
			form1.Show();
			this.Close();
		}
		
		void CmdSellingClick(object sender, EventArgs e)
		{
			Method form1 = new Method();
			form1.Show();
			this.Close();
		}
		
		
		void CmdReportManagementClick(object sender, EventArgs e)
		{
			Report form1 = new Report();
				form1.Show();
				this.Close();
		}
		
		void Button17Click(object sender, EventArgs e)
		{
			LoginForm form1 = new LoginForm();
			form1.Show();
			this.Close();
		}
		
		void TaskLoad(object sender, EventArgs e)
		{	
			lblRole.Text = Global.active_user_role.ToString();
			string role = Global.active_user_role;
			if(role == "manager"){
				cmdMenuManagement.Visible = true;
				cmdReportManagement.Visible = true;
			}
			
		}
	}
}
