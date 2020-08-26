/*
 * Created by SharpDevelop.
 * User: 66969
 * Date: 08/04/2020
 * Time: 12:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using dupchon;

namespace dupchon
{
	/// <summary>
	/// Description of Membership.
	/// </summary>
	public partial class Membership : Form
	{
		DataManager m1 = new DataManager("localhost","food","root","");
		public Membership()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void MembershipLoad(object sender, EventArgs e)
		{
			 
//			try{
//				
//			string sql ="select count(MemberID) from member";
//				DataTable t = m1.GetDataTable(sql);
//				int count = int.Parse(t.Rows[0][0].ToString());
//				count++;
//				txtMemberId.Text = count.ToString();
//			}
//			catch(Exception ex){
//				MessageBox.Show(ex.Message);
//			}
			string FirstName = Global.active_member_firstname;
			textBox3.Text += FirstName;
			string LastName = Global.active_member_lastname;
			textBox4.Text += LastName;
			string PhoneNumber = Global.active_member_phone;
			textBox2.Text = PhoneNumber;
		    string MemberID = Global.active_member_id;
		    txtMemberId.Text += MemberID;
		}
		
		void Button14Click(object sender, EventArgs e)
		{
			Task form1 = new Task();
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
			
				textBox2.Text = textBox2.Text + "1";
			
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			
				textBox2.Text = textBox2.Text + "2";
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			
				textBox2.Text = textBox2.Text + "3";
			
		}
		
		void Button11Click(object sender, EventArgs e)
		{
				textBox2.Text = textBox2.Text + "4";
			
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			
				textBox2.Text = textBox2.Text + "5";
			
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			
				textBox2.Text = textBox2.Text + "6";
		
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			
				textBox2.Text = textBox2.Text + "7";
			
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			
				textBox2.Text = textBox2.Text + "8";
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
				textBox2.Text = textBox2.Text + "9";
		
		}
		
		void Button13Click(object sender, EventArgs e)
		{
			textBox2.Text = "";
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + "0";
		}
		
		void Label7Click(object sender, EventArgs e)
		{
			textBox2.Text = "";
		}
	
		
		void Button16Click(object sender, EventArgs e)
		{
			Out form1 = new Out();
				form1.Show();
				this.Close();

		}
		
		
		void Button10Click(object sender, EventArgs e)
		{
			string PhoneNumber = textBox2.Text;
			string sql = " select count(PhoneNumber) as count,MemberID,FirstName,LastName from member where PhoneNumber = 'd1'";
			sql = sql.Replace("d1",PhoneNumber);
			
			DataTable result = m1.GetDataTable(sql);
			string count = result.Rows[0][0].ToString();
			string MemberID = result.Rows[0][1].ToString();
			string FirstName = result.Rows[0][2].ToString();
			string LastName = result.Rows[0][3].ToString();
			
			Global.active_member_phone= PhoneNumber;
			Global.active_member_firstname= FirstName;
		    Global.active_member_lastname= LastName;
		    Global.active_member_id= MemberID;
			
		    if(count =="1"){
				Membership form1 = new Membership();
				form1.Show();
			}
			else{
				textBox2.Text = "";
				MessageBox.Show("please re-enter your mobile phon number");
		}
	}
		
		void Button20Click(object sender, EventArgs e)
		{
			LoginForm form1 = new LoginForm();
			form1.Show();
			this.Close();
		}
	}
}
	
