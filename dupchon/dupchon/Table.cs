/*
 * Created by SharpDevelop.
 * User: najnnjj
 * Date: 9/4/2563
 * Time: 11:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace dupchon
{
	/// <summary>
	/// Description of Table.
	/// </summary>
	public partial class Table : Form
	{
		public Table()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button14Click(object sender, EventArgs e)
		{
			Method form1 = new Method();
			form1.Show();
			this.Close();
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
				txt1.Text = "1";
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
				txt1.Text = "2";
		}
		
		void Button4Click(object sender, EventArgs e)
		{
				txt1.Text = "3";

		}
		
		void Button6Click(object sender, EventArgs e)
		{
				txt1.Text = "4";
			
		}
		
		
		void Button13Click(object sender, EventArgs e)
		{
			txt1.Text = "";
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			double value1 = double.Parse(txt1.Text);
			double result = value1 - 1;
			if(value1 > 1){
			txt1.Text = result.ToString();
			}
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			double value1 = double.Parse(txt1.Text);
			double result = value1 + 1;
			if(value1 < 4){
			txt1.Text = result.ToString();
			}
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			if(txt1.Text == ""| txt2.Text == ""){
				MessageBox.Show ("Please enter number of customers/table number");
			}
		
			else{
				Order form1 = new Order();
				form1.Show();
				this.Close();
			}
			
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			txt2.Text = "1";
			Global.tablenumber = 1;
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			txt2.Text = "2";
			Global.tablenumber = 2;
		}
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			txt2.Text = "3";
			Global.tablenumber = 3;
		}
		
		void PictureBox4Click(object sender, EventArgs e)
		{
			txt2.Text = "4";
			Global.tablenumber = 4;
		}
		
		void PictureBox5Click(object sender, EventArgs e)
		{
			txt2.Text = "5";
			Global.tablenumber = 5;
		}
		
		void PictureBox6Click(object sender, EventArgs e)
		{
			txt2.Text = "6";
			Global.tablenumber = 6;
		}
		
		void PictureBox7Click(object sender, EventArgs e)
		{
			txt2.Text = "7";
			Global.tablenumber = 7;
		}
		
		void PictureBox8Click(object sender, EventArgs e)
		{
			txt2.Text = "8";
			Global.tablenumber = 8;
		}
		
		void PictureBox9Click(object sender, EventArgs e)
		{
			txt2.Text = "9";
			Global.tablenumber = 9;
		}
		
		
		
		void Button17Click(object sender, EventArgs e)
		{
			LoginForm form1 = new LoginForm();
			form1.Show();
			this.Close();
		}
	}
}
