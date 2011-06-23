/*
 * Created by SharpDevelop.
 * User: hekar
 * Date: 6/23/2011
 * Time: 6:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LuminousFortsHammer
{
	partial class AskUserName
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
            this.okay = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okay
            // 
            this.okay.Location = new System.Drawing.Point(352, 79);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(90, 31);
            this.okay.TabIndex = 0;
            this.okay.Text = "&OK";
            this.okay.UseVisualStyleBackColor = true;
            this.okay.Click += new System.EventHandler(this.OkayClick);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(448, 79);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(90, 31);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "&Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.CancelClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Steam Username";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(146, 34);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(392, 22);
            this.username.TabIndex = 3;
            // 
            // AskUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 116);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.okay);
            this.Name = "AskUserName";
            this.Text = "Steam Username";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Button okay;
	}
}
