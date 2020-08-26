/*
 * Created by SharpDevelop.
 * User: najnnjj
 * Date: 9/4/2563
 * Time: 11:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace dupchon
{
	partial class Method
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Method));
			this.cmdTakeAway = new System.Windows.Forms.Button();
			this.cmdEatIn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmdTakeAway
			// 
			this.cmdTakeAway.BackColor = System.Drawing.Color.White;
			this.cmdTakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.cmdTakeAway.ForeColor = System.Drawing.Color.Black;
			this.cmdTakeAway.Location = new System.Drawing.Point(295, 190);
			this.cmdTakeAway.Name = "cmdTakeAway";
			this.cmdTakeAway.Size = new System.Drawing.Size(189, 127);
			this.cmdTakeAway.TabIndex = 11;
			this.cmdTakeAway.Text = "Take away";
			this.cmdTakeAway.UseVisualStyleBackColor = false;
			this.cmdTakeAway.Click += new System.EventHandler(this.CmdTakeAwayClick);
			// 
			// cmdEatIn
			// 
			this.cmdEatIn.BackColor = System.Drawing.Color.White;
			this.cmdEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.cmdEatIn.ForeColor = System.Drawing.Color.Black;
			this.cmdEatIn.Location = new System.Drawing.Point(72, 190);
			this.cmdEatIn.Name = "cmdEatIn";
			this.cmdEatIn.Size = new System.Drawing.Size(189, 127);
			this.cmdEatIn.TabIndex = 10;
			this.cmdEatIn.Text = "Eat-in";
			this.cmdEatIn.UseVisualStyleBackColor = false;
			this.cmdEatIn.Click += new System.EventHandler(this.CmdEatInClick);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.Location = new System.Drawing.Point(191, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(181, 34);
			this.label2.TabIndex = 9;
			this.label2.Text = "METHOD";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(3, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(557, 50);
			this.label1.TabIndex = 8;
			this.label1.Text = "DUPCHON";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(440, 355);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 43);
			this.button1.TabIndex = 13;
			this.button1.Text = "Back";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button17
			// 
			this.button17.BackColor = System.Drawing.Color.Black;
			this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.button17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button17.Location = new System.Drawing.Point(440, 30);
			this.button17.Margin = new System.Windows.Forms.Padding(4);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(112, 43);
			this.button17.TabIndex = 80;
			this.button17.Text = "Sign-out";
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += new System.EventHandler(this.Button17Click);
			// 
			// Method
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(559, 411);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cmdTakeAway);
			this.Controls.Add(this.cmdEatIn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Method";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Method";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button cmdTakeAway;
		private System.Windows.Forms.Button cmdEatIn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}
