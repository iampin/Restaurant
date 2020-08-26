/*
 * Created by SharpDevelop.
 * User: 66969
 * Date: 08/04/2020
 * Time: 12:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace dupchon
{
	partial class Member_type
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member_type));
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button20 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.button4.ForeColor = System.Drawing.SystemColors.Control;
			this.button4.Location = new System.Drawing.Point(541, 153);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(232, 154);
			this.button4.TabIndex = 7;
			this.button4.Text = "Non member";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.MidnightBlue;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.button3.ForeColor = System.Drawing.SystemColors.Control;
			this.button3.Location = new System.Drawing.Point(285, 153);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(236, 154);
			this.button3.TabIndex = 6;
			this.button3.Text = "Member registration";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.DarkGreen;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.button2.ForeColor = System.Drawing.SystemColors.Control;
			this.button2.Location = new System.Drawing.Point(13, 153);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(240, 154);
			this.button2.TabIndex = 5;
			this.button2.Text = "Member";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(-3, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(807, 50);
			this.label1.TabIndex = 78;
			this.label1.Text = "DUPCHON";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button20
			// 
			this.button20.BackColor = System.Drawing.Color.Black;
			this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.button20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button20.Location = new System.Drawing.Point(689, 34);
			this.button20.Margin = new System.Windows.Forms.Padding(4);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(112, 43);
			this.button20.TabIndex = 243;
			this.button20.Text = "Sign-out";
			this.button20.UseVisualStyleBackColor = false;
			this.button20.Click += new System.EventHandler(this.Button20Click);
			// 
			// button15
			// 
			this.button15.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.button15.ForeColor = System.Drawing.SystemColors.Control;
			this.button15.Location = new System.Drawing.Point(13, 352);
			this.button15.Margin = new System.Windows.Forms.Padding(4);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(107, 43);
			this.button15.TabIndex = 244;
			this.button15.Text = "Back";
			this.button15.UseVisualStyleBackColor = false;
			this.button15.Click += new System.EventHandler(this.Button15Click);
			// 
			// Member_type
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(804, 408);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.button20);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Member_type";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Member_type";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}
