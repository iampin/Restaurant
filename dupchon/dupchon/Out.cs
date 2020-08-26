/*
 * Created by SharpDevelop.
 * User: 66969
 * Date: 15/04/2020
 * Time: 16:20
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
	/// Description of Out.
	/// </summary>
	public partial class Out : Form
	{
		double gtotal = 0;
		double vat = 0;
		//double pay = 0;
		DataManager m1 = new DataManager("localhost","food","root","");
		public Out()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Button13Click(object sender, EventArgs e)
		{
			txt2.Text = "0";
		}
		
		
		void Button20Click(object sender, EventArgs e)
		{
			
			txt2.Text = txt2.Text.Substring(0,txt2.Text.Length - 1);
			
		}
		
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			double total = double.Parse(txt2.Text);
			total += 10;
			txt2.Text = total.ToString();
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			double total = double.Parse(txt2.Text);
			total += 5;
			txt2.Text = total.ToString();
		}
		
		void PictureBox4Click(object sender, EventArgs e)
		{
			double total = double.Parse(txt2.Text);
			total += 2;
			txt2.Text = total.ToString();
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			double total = double.Parse(txt2.Text);
			total += 1;
			txt2.Text = total.ToString();
		}
		
		void PictureBox6Click(object sender, EventArgs e)
		{
			double total = double.Parse(txt2.Text);
			total += 0.50;
			txt2.Text = total.ToString();
		}
		
		void PictureBox5Click(object sender, EventArgs e)
		{
			double total = double.Parse(txt2.Text);
			total += 0.25;
			txt2.Text = total.ToString();
		}
		
		void Button14Click(object sender, EventArgs e)
		{
			double total = double.Parse(txt2.Text);
			total += 20;
			txt2.Text = total.ToString();
		}
		
		void Button19Click(object sender, EventArgs e)
		{
			double total = double.Parse(txt2.Text);
			total += 50;
			txt2.Text = total.ToString();
		}
		
		void Button18Click(object sender, EventArgs e)
		{
			double total = double.Parse(txt2.Text);
			total += 100;
			txt2.Text = total.ToString();
		}
		
		void Button16Click(object sender, EventArgs e)
		{
			double total = double.Parse(txt2.Text);
			total += 500;
			txt2.Text = total.ToString();
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			double total = double.Parse(txt2.Text);
			total += 1000;
			txt2.Text = total.ToString();
		}
		
		
		void Button22Click(object sender, EventArgs e)
		{
			string sql1 = "insert into forder(oid,MemberID,grandtotal) value(null,'d1','d2')";
			sql1=sql1.Replace("d1",Global.active_member_id);
			sql1=sql1.Replace("d2",txtTotal.Text);
			m1.ExecuteNonQuery(sql1);
			//2nd transaction
			string sql2 = "select count(oid) from forder";
			DataTable t = m1.GetDataTable(sql2);
			string num = t.Rows[0][0].ToString();
			string sql3 = "";
			string template = "insert into forderdetail(no,oid,foodname,qty,price,total,memo) value(null,'d1','d2','d3','d4','d5','');";
			foreach(OrderItem o in Global.orders){
				string tt = template;
				tt=tt.Replace("d1",num);
				tt=tt.Replace("d2",o.name);
				tt=tt.Replace("d3",o.qty.ToString());
				tt=tt.Replace("d4",o.each.ToString());
				tt=tt.Replace("d5",o.total.ToString());
				sql3 += tt;
			}
			
			m1.ExecuteNonQuery(sql3);
			MessageBox.Show("success");
			
			Task form1 = new Task();
			form1.Show();
			this.Close();
		}
		
		
		void OutLoad(object sender, EventArgs e)
		{
			
			string role = Global.active_user_role;
			label11.Text += role;
			string username = Global.active_user_name;
			label10.Text += username;
			string id = Global.active_user_id;
			label12.Text += id;
			
			label1.Text = Global.tablenumber.ToString();
			
			foreach(OrderItem v in Global.orders){
				ListViewItem r = new ListViewItem(v.name);
				r.SubItems.Add(v.qty.ToString());
				r.SubItems.Add(v.each.ToString());
				r.SubItems.Add(v.total.ToString());
				listView1.Items.Add(r);
				gtotal += v.total;
				
			}
			vat = gtotal*0.07;
			txtVat2.Text = vat.ToString();
			txtTotal.Text = (gtotal+vat).ToString();
			label16.Text = txtTotal.Text;
		}
		
		
		
		
		void Button2Click(object sender, EventArgs e)
		{
			Member_type form1 = new Member_type();
			form1.Show();
			this.Close();
		}
	
		void Button21Click(object sender, EventArgs e)
		{
			double total = double.Parse(label16.Text); 
			double amount = double.Parse(txt2.Text);
			double result = amount - total;
			label17.Text = result.ToString();
			
		}
		
		void Button17Click(object sender, EventArgs e)
		{
			LoginForm form1 = new LoginForm();
			form1.Show();
			this.Close();
		}
	}
}
