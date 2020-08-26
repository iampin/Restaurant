/*
 * Created by SharpDevelop.
 * User: najnnjj
 * Date: 8/4/2563
 * Time: 19:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace dupchon
{
	/// <summary>
	/// Description of LoginForm.
	/// </summary>
	public partial class LoginForm : Form
	{
		DataManager m1=new DataManager("localhost","food","root","");
		public LoginForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void CmdLoginClick(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;
			string sql = "select count(username) as count,role,id from employeee where username = 'd1' and password ='d2'";
			sql = sql.Replace("d1",username);
			sql = sql.Replace("d2",password);
			
			DataTable result = m1.GetDataTable(sql);
			string count = result.Rows[0][0].ToString();
			string role = result.Rows[0][1].ToString();
			string id = result.Rows[0][2].ToString();
			string username1 = result.Rows[0][1].ToString();

			Global.active_user_name = username;
			Global.active_user_role = role;
			Global.active_user_id = id;
		
			if(count =="1"){
				Task form1 = new Task();
				MenuManagement form2 = new MenuManagement();
				form1.Show();
			}
			else{
				txtUsername.Text = "";
				txtPassword.Text = "";
				MessageBox.Show("please re-enter your username and password");
			}
		
		}

	}
}
