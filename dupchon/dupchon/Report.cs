/*
 * Created by SharpDevelop.
 * User: najnnjj
 * Date: 29/4/2563
 * Time: 20:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using ZedGraph;

namespace dupchon
{
	/// <summary>
	/// Description of Report.
	/// </summary>
	public partial class Report : Form
	{
		
		DataManager m1 = new DataManager("localhost","food","root","");
		public Report()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void BtnBrowseClick(object sender, EventArgs e)
		{
			string sql = "select * from forderdetail";
			DataTable result = m1.GetDataTable(sql);
			dataGridView1.DataSource = result;
			//Show the pie graph at the same time
			
			string sql2 = "select * from menu";
			DataTable result2 = m1.GetDataTable(sql2);
			dataGridView2.DataSource = result2;
			
			
			
		}
		

		
		void Button15Click(object sender, EventArgs e)
		{
			Task form1 = new Task();
			form1.Show();
			this.Close();
		}
		void analytic1(){
			//make query from database
			string sql = "SELECT foodID, qty From forderdetail f, menu m Where f.foodname = m.name";
			DataTable t = m1.GetDataTable(sql);
			//create a list to store the data
			List<string> foodname = new List<string>();
			List<double> qty = new List<double>();
			foreach(DataRow r in t.Rows){
				foodname.Add(r[0].ToString());
				qty.Add(double.Parse(r[1].ToString()));
			}//eloop
			//turn list into array
			;
			
			GraphPane p1 = bchart1.GraphPane;
			p1.Title.Text = "Quantity of each food name ordered by customer in April";
			p1.XAxis.Title.Text = "Food ID";
			p1.YAxis.Title.Text = "Quantity";

			string[] labels = foodname.ToArray();
			
			double[] data = qty.ToArray();
			
			BarItem myBar = p1.AddBar( "Food ID", null, data,
			                          Color.Blue );
			
			myBar.Bar.Fill = new Fill( Color.Blue, Color.White,
			                          Color.Blue );
			
			// Set the XAxis labels
			p1.XAxis.Scale.TextLabels = labels;
			
			// Set the XAxis to Text type
			p1.XAxis.Type = AxisType.Text;
			
			
			
			bchart1.AxisChange();
		}//ef

		void Button17Click(object sender, EventArgs e)
		{
			LoginForm form1 = new LoginForm();
			form1.Show();
			this.Close();
		}
		
		
		
		void ReportLoad(object sender, EventArgs e)
		{
			lblRole.Text = Global.active_user_role.ToString();
			string role = Global.active_user_role;
			analytic1();
		}
	}
}//ec

