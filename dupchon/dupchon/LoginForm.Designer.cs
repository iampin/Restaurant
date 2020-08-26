using System.Data;
using System.Windows.Forms;

/*
 * Created by SharpDevelop.
 * User: najnnjj
 * Date: 8/4/2563
 * Time: 19:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace dupchon
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmdLogin = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.Location = new System.Drawing.Point(132, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(257, 69);
			this.label1.TabIndex = 0;
			this.label1.Text = "DUPCHON";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(35, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 42);
			this.label2.TabIndex = 1;
			this.label2.Text = "username";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.txtUsername);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(67, 113);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(369, 199);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(170, 121);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(175, 34);
			this.txtPassword.TabIndex = 5;
			this.txtPassword.Text = "naj";
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(170, 48);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(175, 34);
			this.txtUsername.TabIndex = 4;
			this.txtUsername.Text = "naj";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(35, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 45);
			this.label3.TabIndex = 3;
			this.label3.Text = "password";
			// 
			// cmdLogin
			// 
			this.cmdLogin.BackColor = System.Drawing.Color.Black;
			this.cmdLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdLogin.Location = new System.Drawing.Point(199, 337);
			this.cmdLogin.Name = "cmdLogin";
			this.cmdLogin.Size = new System.Drawing.Size(107, 43);
			this.cmdLogin.TabIndex = 3;
			this.cmdLogin.Text = "Log-in";
			this.cmdLogin.UseVisualStyleBackColor = false;
			this.cmdLogin.Click += new System.EventHandler(this.CmdLoginClick);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(508, 434);
			this.Controls.Add(this.cmdLogin);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Button cmdLogin;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		
		}
}


