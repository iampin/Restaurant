/*
 * Created by SharpDevelop.
 * User: najnnjj
 * Date: 29/4/2563
 * Time: 20:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace dupchon
{
	partial class Report
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.bchart1 = new ZedGraph.ZedGraphControl();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.lblRole = new System.Windows.Forms.Label();
			this.lable3 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(2, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1427, 50);
			this.label1.TabIndex = 3;
			this.label1.Text = "DUPCHON";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.Location = new System.Drawing.Point(634, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(235, 33);
			this.label2.TabIndex = 79;
			this.label2.Text = "REPORT";
			// 
			// bchart1
			// 
			this.bchart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.bchart1.Location = new System.Drawing.Point(13, 398);
			this.bchart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.bchart1.Name = "bchart1";
			this.bchart1.ScrollGrace = 0;
			this.bchart1.ScrollMaxX = 0;
			this.bchart1.ScrollMaxY = 0;
			this.bchart1.ScrollMaxY2 = 0;
			this.bchart1.ScrollMinX = 0;
			this.bchart1.ScrollMinY = 0;
			this.bchart1.ScrollMinY2 = 0;
			this.bchart1.Size = new System.Drawing.Size(1307, 520);
			this.bchart1.TabIndex = 80;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(601, 182);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(715, 198);
			this.dataGridView1.TabIndex = 81;
			// 
			// btnBrowse
			// 
			this.btnBrowse.BackColor = System.Drawing.Color.Black;
			this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.btnBrowse.ForeColor = System.Drawing.Color.White;
			this.btnBrowse.Location = new System.Drawing.Point(1322, 348);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(107, 43);
			this.btnBrowse.TabIndex = 82;
			this.btnBrowse.Text = "Show";
			this.btnBrowse.UseVisualStyleBackColor = false;
			this.btnBrowse.Click += new System.EventHandler(this.BtnBrowseClick);
			// 
			// button17
			// 
			this.button17.BackColor = System.Drawing.Color.Black;
			this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.button17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button17.Location = new System.Drawing.Point(1314, 33);
			this.button17.Margin = new System.Windows.Forms.Padding(4);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(112, 43);
			this.button17.TabIndex = 83;
			this.button17.Text = "Sign-out";
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += new System.EventHandler(this.Button17Click);
			// 
			// button15
			// 
			this.button15.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.button15.ForeColor = System.Drawing.SystemColors.Control;
			this.button15.Location = new System.Drawing.Point(1314, 929);
			this.button15.Margin = new System.Windows.Forms.Padding(4);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(107, 43);
			this.button15.TabIndex = 84;
			this.button15.Text = "Back";
			this.button15.UseVisualStyleBackColor = false;
			this.button15.Click += new System.EventHandler(this.Button15Click);
			// 
			// lblRole
			// 
			this.lblRole.BackColor = System.Drawing.Color.Transparent;
			this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblRole.Location = new System.Drawing.Point(1300, 89);
			this.lblRole.Name = "lblRole";
			this.lblRole.Size = new System.Drawing.Size(117, 34);
			this.lblRole.TabIndex = 86;
			this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lable3
			// 
			this.lable3.BackColor = System.Drawing.Color.Transparent;
			this.lable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lable3.Location = new System.Drawing.Point(1228, 84);
			this.lable3.Name = "lable3";
			this.lable3.Size = new System.Drawing.Size(179, 44);
			this.lable3.TabIndex = 85;
			this.lable3.Text = "Role: ";
			this.lable3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label3.Location = new System.Drawing.Point(13, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(209, 32);
			this.label3.TabIndex = 92;
			this.label3.Text = "Menu information";
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(13, 182);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(570, 198);
			this.dataGridView2.TabIndex = 87;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label4.Location = new System.Drawing.Point(601, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(209, 32);
			this.label4.TabIndex = 93;
			this.label4.Text = "Order detail";
			// 
			// Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1429, 985);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblRole);
			this.Controls.Add(this.lable3);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.bchart1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Report";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Report";
			this.Load += new System.EventHandler(this.ReportLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label lable3;
		private System.Windows.Forms.Label lblRole;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button17;
		private ZedGraph.ZedGraphControl bchart1;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
