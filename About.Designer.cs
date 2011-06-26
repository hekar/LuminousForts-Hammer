/*
 * Created by SharpDevelop.
 * User: hekar
 * Date: 6/26/2011
 * Time: 2:11 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LuminousFortsHammer
{
	partial class About
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
			this.author = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// author
			// 
			this.author.Location = new System.Drawing.Point(12, 54);
			this.author.Name = "author";
			this.author.Size = new System.Drawing.Size(227, 23);
			this.author.TabIndex = 0;
			this.author.Text = "Copyright © Hekar Khani 2011";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Licensed under the GPL v3";
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 101);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.author);
			this.Name = "About";
			this.Text = "About";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label author;
	}
}
