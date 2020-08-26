/*
 * Created by SharpDevelop.
 * User: najnnjj
 * Date: 8/4/2563
 * Time: 21:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dupchon
{
	/// <summary>
	/// Description of MenuManagement.
	/// </summary>
	public partial class MenuManagement : Form
	{
		DataManager m1 = new DataManager("localhost","food","root","");
		public MenuManagement()
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
			Task form1 = new Task();
			form1.Show();
			this.Close();
		}
		
		void updateGrid(){
			string sql = "select * from menu";
			DataTable result = m1.GetDataTable(sql);
			dataGridView1.DataSource = result;
		}
		
		void BtnBrowseClick(object sender, EventArgs e)
		{
			//get data from product table
			//and then put the data result into gridview
			//create a query string in sql
			updateGrid();
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
		}
		
		
		
		
		void MenuManagementLoad(object sender, EventArgs e)
		{
			string sql ="select count(foodID) from menu";
			DataTable t = m1.GetDataTable(sql);
			int count = int.Parse(t.Rows[0][0].ToString());
			count++;
			
			lblRole.Text = Global.active_user_role.ToString();
			string role = Global.active_user_role;
			if(role == "manager"){
				groupBox1.Visible = true;
			}
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
		}
		
		
		
		
	
		void BtnAddClick(object sender, EventArgs e)
		{
			//insert new row in to database
			string sql = "insert into menu(foodID,category,name,price,image) value(null,'d1','d2','d3','d4');";
			sql = sql.Replace("d1",txtCategory.Text);
			sql = sql.Replace("d2",txtName.Text);
			sql = sql.Replace("d3",txtPrice.Text);
			sql = sql.Replace("d4",txtImage.Text);
			m1.ExecuteNonQuery(sql);
			MessageBox.Show("done");
			updateGrid();
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				
				string filePath = openFileDialog1.SafeFileName;
				txtImage.Text  = filePath;
				
			}
			
		}//ef
		
		void LblClear2Click(object sender, EventArgs e)
		{
			txtCategory.Text = "";
		}
		
		void LblClear3Click(object sender, EventArgs e)
		{
			txtName.Text = "";
		}
		
		void LblClear4Click(object sender, EventArgs e)
		{
			txtPrice.Text = "";
		}
		
		void LblClear5Click(object sender, EventArgs e)
		{
			txtImage.Text = "";
		}
		
		
		
		
		void Button17Click(object sender, EventArgs e)
		{
			LoginForm form1 = new LoginForm();
			form1.Show();
			this.Close();
		}
	}//ec
}//en
