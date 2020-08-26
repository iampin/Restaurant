/*
 * Created by SharpDevelop.
 * User: najnnjj
 * Date: 15/4/2563
 * Time: 14:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace dupchon
{
	/// <summary>
	/// Description of Order.
	/// </summary>
	public partial class Order : Form
	{
		string foodname = "";
		double foodprice = 0;
		double gtotal = 0;
		public Order()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Button17Click(object sender, EventArgs e)
		{
			if(listView1.Items.Count == 0){
				MessageBox.Show("Please select menu(s) to order");
			}
			else{
				Member_type form1 = new Member_type();
				form1.Show();
				this.Close();
			}
			
		}

		
		
		
		
		void Button18Click(object sender, EventArgs e)
		{
			Task form1 = new Task();
				form1.Show();
				this.Close();
		}
		
		void BtnOrder1Click(object sender, EventArgs e)
		{
			if(txtQty.Text == "0" && txtQty.Text != null){
				txtQty.Text = "1";
			}
			else{
				txtQty.Text = txtQty.Text + "1";
			}
		}
		
		void BtnOrder2Click(object sender, EventArgs e)
		{
			if(txtQty.Text == "0" && txtQty.Text != null){
				txtQty.Text = "2";
			}
			else{
				txtQty.Text = txtQty.Text + "2";
			}
		}
		
		void BtnOrder3Click(object sender, EventArgs e)
		{
			if(txtQty.Text == "0" && txtQty.Text != null){
				txtQty.Text = "3";
			}
			else{
				txtQty.Text = txtQty.Text + "3";
			}
		}
		
		void BtnOrder4Click(object sender, EventArgs e)
		{
			if(txtQty.Text == "0" && txtQty.Text != null){
				txtQty.Text = "4";
			}
			else{
				txtQty.Text = txtQty.Text + "4";
			}
		}
		
		void BtnOrder5Click(object sender, EventArgs e)
		{
			if(txtQty.Text == "0" && txtQty.Text != null){
				txtQty.Text = "5";
			}
			else{
				txtQty.Text = txtQty.Text + "5";
			}
		}
		
		void BtnOrder6Click(object sender, EventArgs e)
		{
			if(txtQty.Text == "0" && txtQty.Text != null){
				txtQty.Text = "6";
			}
			else{
				txtQty.Text = txtQty.Text + "6";
			}
		}
		
		void BtnOrder7Click(object sender, EventArgs e)
		{
			if(txtQty.Text == "0" && txtQty.Text != null){
				txtQty.Text = "7";
			}
			else{
				txtQty.Text = txtQty.Text + "7";
			}
		}
		
		void BtnOrder8Click(object sender, EventArgs e)
		{
			if(txtQty.Text == "0" && txtQty.Text != null){
				txtQty.Text = "8";
			}
			else{
				txtQty.Text = txtQty.Text + "8";
			}
		}
		
		void BtnOrder9Click(object sender, EventArgs e)
		{
			if(txtQty.Text == "0" && txtQty.Text != null){
				txtQty.Text = "9";
			}
			else{
				txtQty.Text = txtQty.Text + "9";
			}
		}
		
		void BtnOrderMinusClick(object sender, EventArgs e)
		{
			double value1 = double.Parse(txtQty.Text);
			double result = value1 - 1;
			if(value1 > 1){
			txtQty.Text = result.ToString();
			}
		}
		
		void BtnOrder0Click(object sender, EventArgs e)
		{
			txtQty.Text = txtQty.Text + "0";
		}
		
		void BtnOrderPlusClick(object sender, EventArgs e)
		{
			double value1 = double.Parse(txtQty.Text);
			double result = value1 + 1;
			txtQty.Text = result.ToString();
		}
		
		void BtnOrderDeleClick(object sender, EventArgs e)
		{
			txtQty.Text = "";
		}
		
		void TxtQtyTextChanged(object sender, EventArgs e)
		{
			txtQty.MaxLength = 2; 
			
		}
		
		void Button19Click(object sender, EventArgs e)
		{
			
			txtQty.Text = txtQty.Text.Substring(0,txtQty.Text.Length - 1);
	
		}
		
		
		
		void OrderLoad(object sender, EventArgs e)
		{
			string role = Global.active_user_role;
			txtRole.Text += role;
			string username = Global.active_user_name;
			txtName.Text += username;
			string id = Global.active_user_id;
			txtID.Text += id;
			
			label4.Text = Global.tablenumber.ToString();
			Global.orders.Clear();
			
		}
	
		
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			lbl44.Text = "WINGS(S)";
			Global.menu_order = "WINGS(S)-Ori";
			foodname = "Wings(S)-Ori";
			foodprice = 69;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			lbl44.Text = "WINGS(L)";
			Global.menu_order = "WINGS(L)-Ori";
			foodname = "Wings(L)-Ori";
			foodprice = 129;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			lbl44.Text = "BONELESS(S)";
			Global.menu_order = "BONELESS(S)-Ori";
			foodname = "Boneless(S)-Ori";
			foodprice = 69;
		}
		
		
		void Button4Click(object sender, EventArgs e)
		{
			lbl44.Text = "BONELESS(L)";
			Global.menu_order = "BONELESS(L)-Ori";
			foodname = "Boneless(L)-Ori";
			foodprice = 129;
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			lbl44.Text = "CHICKEN POP";
			Global.menu_order = "POP-Ori";
			foodname = "Chicken Pop-Ori";
			foodprice = 59;
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			lbl44.Text = "WINGS(S)";
			Global.menu_order = "WINGS(S)-Spi";
			foodname = "Wings(S)-Spi";
			foodprice = 69;
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			lbl44.Text = "WINGS(L)";
			Global.menu_order = "WINGS(L)-Spi";
			foodname = "Wings(L)-Spi";
			foodprice = 129;
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			lbl44.Text = "BONELESS(S)";
			Global.menu_order = "BONELESS(S)-Spi";
			foodname = "Boneless(S)-Spi";
			foodprice = 69;
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			lbl44.Text = "BONELESS(L)";
			Global.menu_order = "BONELESS(L)-Spi";
			foodname = "Boneless(L)-Spi";
			foodprice = 129;
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			lbl44.Text = "CHICKEN POP";
			Global.menu_order = "POP-Spi";
			foodname = "Chicken Pop-Spi";
			foodprice = 59;
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			lbl44.Text = "STREAM RICE";
			Global.menu_order = "STREAM RICE";
			foodname = "Stream Rice";
			foodprice = 19;
		}
		
		void Button13Click(object sender, EventArgs e)
		{
			lbl44.Text = "STICKY RICE";
			Global.menu_order = "STICKY RICE";
			foodname = "Sticky Rice";
			foodprice = 19;
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			lbl44.Text = "TTEOK-BOKKI";
			Global.menu_order = "TTEOK-BOKKI";
			foodname = "Tteok-Bokki";
			foodprice = 79;
		}
		
		void Button14Click(object sender, EventArgs e)
		{
			lbl44.Text = "DRINKING WATER";
			Global.menu_order = "DRINKING WATER";
			foodname = "Drinking Water";
			foodprice = 20;
		}
		
		void Button16Click(object sender, EventArgs e)
		{
			lbl44.Text = "GREEN TEA";
			Global.menu_order = "GREEN TEA";
			foodname = "Green Tea";
			foodprice = 259;
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			lbl44.Text = "COCA-COLA";
			Global.menu_order = "COCA-COLA";
			foodname = "Coca-cola";
			foodprice = 35;
		}
		
		
		
		void BtnOrderSubmitClick(object sender, EventArgs e)
		{
			string sqty= txtQty.Text;
			double qty = double.Parse(sqty);
			double total =qty*foodprice;
			ListViewItem r = new ListViewItem(foodname);
			r.SubItems.Add(sqty);
			r.SubItems.Add(foodprice.ToString());
			r.SubItems.Add(total.ToString());
			listView1.Items.Add(r);
			Global.orders.Add(new OrderItem(foodname, qty, foodprice, total));
			gtotal += total;
			
			lblTotal.Text = gtotal.ToString();
			txtQty.ResetText();
		}
		
		void CmdRemoveClick(object sender, EventArgs e)
		{
			listView1.SelectedItems[0].Remove();
		}
		
		
		
		
		
		void Button20Click(object sender, EventArgs e)
		{
			LoginForm form1 = new LoginForm();
			form1.Show();
			this.Close();
		}
	}
}


