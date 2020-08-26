/*
 * Created by SharpDevelop.
 * User: najnnjj
 * Date: 8/4/2563
 * Time: 21:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace dupchon
{
	partial class MenuManagement
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuManagement));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lable3 = new System.Windows.Forms.Label();
			this.txtCategory = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtImage = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblClear2 = new System.Windows.Forms.Label();
			this.lblClear5 = new System.Windows.Forms.Label();
			this.lblClear4 = new System.Windows.Forms.Label();
			this.lblClear3 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.lblRole = new System.Windows.Forms.Label();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button17 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(1, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(921, 50);
			this.label1.TabIndex = 3;
			this.label1.Text = "DUPCHON";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.Location = new System.Drawing.Point(263, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(388, 44);
			this.label2.TabIndex = 4;
			this.label2.Text = "MENU MANAGEMENT";
			// 
			// lable3
			// 
			this.lable3.BackColor = System.Drawing.Color.Transparent;
			this.lable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lable3.Location = new System.Drawing.Point(709, 75);
			this.lable3.Name = "lable3";
			this.lable3.Size = new System.Drawing.Size(179, 44);
			this.lable3.TabIndex = 5;
			this.lable3.Text = "Role: ";
			this.lable3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCategory
			// 
			this.txtCategory.Location = new System.Drawing.Point(151, 38);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.Size = new System.Drawing.Size(231, 34);
			this.txtCategory.TabIndex = 7;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(151, 87);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(231, 34);
			this.txtName.TabIndex = 8;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(151, 138);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(231, 34);
			this.txtPrice.TabIndex = 9;
			// 
			// txtImage
			// 
			this.txtImage.Location = new System.Drawing.Point(151, 188);
			this.txtImage.Name = "txtImage";
			this.txtImage.Size = new System.Drawing.Size(231, 34);
			this.txtImage.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(6, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 31);
			this.label4.TabIndex = 12;
			this.label4.Text = "Category :";
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(37, 87);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 31);
			this.label5.TabIndex = 13;
			this.label5.Text = "Name :";
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(46, 138);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 31);
			this.label6.TabIndex = 14;
			this.label6.Text = "Price :";
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(37, 188);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(99, 31);
			this.label7.TabIndex = 15;
			this.label7.Text = "Image :";
			// 
			// lblClear2
			// 
			this.lblClear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblClear2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblClear2.Location = new System.Drawing.Point(397, 44);
			this.lblClear2.Name = "lblClear2";
			this.lblClear2.Size = new System.Drawing.Size(69, 28);
			this.lblClear2.TabIndex = 18;
			this.lblClear2.Text = "clear";
			this.lblClear2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblClear2.UseCompatibleTextRendering = true;
			this.lblClear2.Click += new System.EventHandler(this.LblClear2Click);
			// 
			// lblClear5
			// 
			this.lblClear5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblClear5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblClear5.Location = new System.Drawing.Point(510, 194);
			this.lblClear5.Name = "lblClear5";
			this.lblClear5.Size = new System.Drawing.Size(69, 28);
			this.lblClear5.TabIndex = 19;
			this.lblClear5.Text = "clear";
			this.lblClear5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblClear5.UseCompatibleTextRendering = true;
			this.lblClear5.Click += new System.EventHandler(this.LblClear5Click);
			// 
			// lblClear4
			// 
			this.lblClear4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblClear4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblClear4.Location = new System.Drawing.Point(397, 144);
			this.lblClear4.Name = "lblClear4";
			this.lblClear4.Size = new System.Drawing.Size(69, 28);
			this.lblClear4.TabIndex = 20;
			this.lblClear4.Text = "clear";
			this.lblClear4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblClear4.UseCompatibleTextRendering = true;
			this.lblClear4.Click += new System.EventHandler(this.LblClear4Click);
			// 
			// lblClear3
			// 
			this.lblClear3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblClear3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblClear3.Location = new System.Drawing.Point(397, 93);
			this.lblClear3.Name = "lblClear3";
			this.lblClear3.Size = new System.Drawing.Size(69, 28);
			this.lblClear3.TabIndex = 21;
			this.lblClear3.Text = "clear";
			this.lblClear3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblClear3.UseCompatibleTextRendering = true;
			this.lblClear3.Click += new System.EventHandler(this.LblClear3Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Black;
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(791, 651);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(107, 43);
			this.btnAdd.TabIndex = 22;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Black;
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(678, 651);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(107, 43);
			this.btnCancel.TabIndex = 23;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.Button2Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(34, 139);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(843, 198);
			this.dataGridView1.TabIndex = 24;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.ForeColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(397, 185);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 43);
			this.button1.TabIndex = 25;
			this.button1.Text = "Browse";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// lblRole
			// 
			this.lblRole.BackColor = System.Drawing.Color.Transparent;
			this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblRole.Location = new System.Drawing.Point(781, 80);
			this.lblRole.Name = "lblRole";
			this.lblRole.Size = new System.Drawing.Size(117, 34);
			this.lblRole.TabIndex = 78;
			this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnBrowse
			// 
			this.btnBrowse.BackColor = System.Drawing.Color.Black;
			this.btnBrowse.ForeColor = System.Drawing.Color.White;
			this.btnBrowse.Location = new System.Drawing.Point(760, 353);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(107, 43);
			this.btnBrowse.TabIndex = 16;
			this.btnBrowse.Text = "Show";
			this.btnBrowse.UseVisualStyleBackColor = false;
			this.btnBrowse.Click += new System.EventHandler(this.BtnBrowseClick);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Navy;
			this.groupBox1.Controls.Add(this.txtImage);
			this.groupBox1.Controls.Add(this.txtPrice);
			this.groupBox1.Controls.Add(this.txtCategory);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.lblClear3);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.lblClear4);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.lblClear5);
			this.groupBox1.Controls.Add(this.lblClear2);
			this.groupBox1.Location = new System.Drawing.Point(147, 362);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(594, 271);
			this.groupBox1.TabIndex = 79;
			this.groupBox1.TabStop = false;
			this.groupBox1.Visible = false;
			// 
			// button17
			// 
			this.button17.BackColor = System.Drawing.Color.Black;
			this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.button17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button17.Location = new System.Drawing.Point(802, 22);
			this.button17.Margin = new System.Windows.Forms.Padding(4);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(112, 43);
			this.button17.TabIndex = 80;
			this.button17.Text = "Sign-out";
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += new System.EventHandler(this.Button17Click);
			// 
			// MenuManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(919, 706);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblRole);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.lable3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "MenuManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MenuManagement";
			this.Load += new System.EventHandler(this.MenuManagementLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lable3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label lblClear5;
		private System.Windows.Forms.Label lblClear2;
		private System.Windows.Forms.Label lblClear4;
		private System.Windows.Forms.Label lblClear3;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtImage;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtCategory;
		private System.Windows.Forms.Label lblRole;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		
	}
}
