/*
 * Created by SharpDevelop.
 * User: 66969
 * Date: 08/04/2020
 * Time: 12:20
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
	/// Description of Member.
	/// </summary>
	public partial class Member : Form
	{
		DataManager m1 = new DataManager("localhost","food","root","");
		public Member()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MemberLoad(object sender, EventArgs e)
		{
			
			string sql ="select count(MemberID) from member";
			DataTable t = m1.GetDataTable(sql);
			int count = int.Parse(t.Rows[0][0].ToString());
			count++;
			txt4.Text = count.ToString();
		
		}
		
		void Button14Click(object sender, EventArgs e)
		{
			Membership form1 = new Membership();
				form1.Show();
				this.Close();
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			Member_type form1 = new Member_type();
				form1.Show();
				this.Close();
		}
		
		
		
		void Button3Click(object sender, EventArgs e)
		{
				txt1.Text = txt1.Text + "1";
			
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			
				txt1.Text = txt1.Text + "2";
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			
				txt1.Text = txt1.Text + "3";
			
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			
				txt1.Text = txt1.Text + "4";
			
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			
				txt1.Text = txt1.Text + "5";
			
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			
				txt1.Text = txt1.Text + "6";
			
		}
		
		void Button12Click(object sender, EventArgs e)
		{
				txt1.Text = txt1.Text + "7";
			
		}
		
		void Button8Click(object sender, EventArgs e)
		{
				txt1.Text = txt1.Text + "8";
		}
		
		void Button2Click(object sender, EventArgs e)
		{
		
				txt1.Text = txt1.Text + "9";
		
		}
		
		void Button13Click(object sender, EventArgs e)
		{
			txt1.Text = "";
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			txt1.Text = txt1.Text + "0";
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			
			txt1.Text = txt1.Text.Substring(0,txt1.Text.Length - 1);
		}
		
		void Label7Click(object sender, EventArgs e)
		{
			txt2.Text = "";
		}
		
		void Label8Click(object sender, EventArgs e)
		{
			txt3.Text = "";
		}
		
		void Label9Click(object sender, EventArgs e)
		{
			txt1.Text = "";
		}
		
		
		
		
		
		void Button16Click(object sender, EventArgs e)
		{
			string sql = "insert into member(MemberID,FirstName,LastName,PhoneNumber) value(null,'d1','d2','d3');";
			sql = sql.Replace("d1",txt2.Text);
			sql = sql.Replace("d2",txt3.Text);
			sql = sql.Replace("d3",txt1.Text);
			
			m1.ExecuteNonQuery(sql);
			MessageBox.Show("done");
			
		}
		
		
		
		void Button17Click(object sender, EventArgs e)
		{
			LoginForm form1 = new LoginForm();
			form1.Show();
			this.Close();
		}
		
		
	}
}
