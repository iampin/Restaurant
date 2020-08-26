/*
 * Created by SharpDevelop.
 * User: najnnjj
 * Date: 8/4/2563
 * Time: 21:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace dupchon
{
	partial class Task
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task));
			this.label1 = new System.Windows.Forms.Label();
			this.cmdMenuManagement = new System.Windows.Forms.Button();
			this.cmdSelling = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cmdReportManagement = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.lable3 = new System.Windows.Forms.Label();
			this.lblRole = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(1, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(685, 50);
			this.label1.TabIndex = 2;
			this.label1.Text = "DUPCHON";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmdMenuManagement
			// 
			this.cmdMenuManagement.BackColor = System.Drawing.Color.MidnightBlue;
			this.cmdMenuManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.cmdMenuManagement.ForeColor = System.Drawing.Color.White;
			this.cmdMenuManagement.Location = new System.Drawing.Point(21, 165);
			this.cmdMenuManagement.Name = "cmdMenuManagement";
			this.cmdMenuManagement.Size = new System.Drawing.Size(189, 127);
			this.cmdMenuManagement.TabIndex = 7;
			this.cmdMenuManagement.Text = "Menu Management";
			this.cmdMenuManagement.UseVisualStyleBackColor = false;
			this.cmdMenuManagement.Visible = false;
			this.cmdMenuManagement.Click += new System.EventHandler(this.CmdMenuManagementClick);
			// 
			// cmdSelling
			// 
			this.cmdSelling.BackColor = System.Drawing.Color.MidnightBlue;
			this.cmdSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.cmdSelling.ForeColor = System.Drawing.Color.White;
			this.cmdSelling.Location = new System.Drawing.Point(242, 165);
			this.cmdSelling.Name = "cmdSelling";
			this.cmdSelling.Size = new System.Drawing.Size(189, 127);
			this.cmdSelling.TabIndex = 6;
			this.cmdSelling.Text = "Selling";
			this.cmdSelling.UseVisualStyleBackColor = false;
			this.cmdSelling.Click += new System.EventHandler(this.CmdSellingClick);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.Location = new System.Drawing.Point(294, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 34);
			this.label2.TabIndex = 5;
			this.label2.Text = "TASK";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// cmdReportManagement
			// 
			this.cmdReportManagement.BackColor = System.Drawing.Color.MidnightBlue;
			this.cmdReportManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.cmdReportManagement.ForeColor = System.Drawing.Color.White;
			this.cmdReportManagement.Location = new System.Drawing.Point(467, 165);
			this.cmdReportManagement.Name = "cmdReportManagement";
			this.cmdReportManagement.Size = new System.Drawing.Size(189, 127);
			this.cmdReportManagement.TabIndex = 78;
			this.cmdReportManagement.Text = "Report Management";
			this.cmdReportManagement.UseVisualStyleBackColor = false;
			this.cmdReportManagement.Visible = false;
			this.cmdReportManagement.Click += new System.EventHandler(this.CmdReportManagementClick);
			// 
			// button17
			// 
			this.button17.BackColor = System.Drawing.Color.Black;
			this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.button17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button17.Location = new System.Drawing.Point(562, 24);
			this.button17.Margin = new System.Windows.Forms.Padding(4);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(112, 43);
			this.button17.TabIndex = 79;
			this.button17.Text = "Sign-out";
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += new System.EventHandler(this.Button17Click);
			// 
			// lable3
			// 
			this.lable3.BackColor = System.Drawing.Color.Transparent;
			this.lable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lable3.Location = new System.Drawing.Point(482, 75);
			this.lable3.Name = "lable3";
			this.lable3.Size = new System.Drawing.Size(179, 44);
			this.lable3.TabIndex = 80;
			this.lable3.Text = "Role: ";
			this.lable3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRole
			// 
			this.lblRole.BackColor = System.Drawing.Color.Transparent;
			this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblRole.Location = new System.Drawing.Point(556, 80);
			this.lblRole.Name = "lblRole";
			this.lblRole.Size = new System.Drawing.Size(117, 34);
			this.lblRole.TabIndex = 87;
			this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Task
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(682, 380);
			this.Controls.Add(this.lblRole);
			this.Controls.Add(this.lable3);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.cmdReportManagement);
			this.Controls.Add(this.cmdMenuManagement);
			this.Controls.Add(this.cmdSelling);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Task";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Task";
			this.Load += new System.EventHandler(this.TaskLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblRole;
		private System.Windows.Forms.Label lable3;
		private System.Windows.Forms.Button cmdReportManagement;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button cmdSelling;
		private System.Windows.Forms.Button cmdMenuManagement;
		private System.Windows.Forms.Label label1;
	}
}
