/*
 * Created by SharpDevelop.
 * User: hekar
 * Date: 6/23/2011
 * Time: 6:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LuminousFortsHammer
{
	/// <summary>
	/// Description of AskUserName.
	/// </summary>
	public partial class AskUserName : Form
	{
		public AskUserName()
		{
			InitializeComponent();
		}
		
		public string Username
		{
            get
            {
			    return username.Text;
            }
		}
		
		private DialogResult result = DialogResult.Cancel;
		void OkayClick(object sender, EventArgs e)
		{
			result = DialogResult.OK;
			Hide();
		}
		
		void CancelClick(object sender, EventArgs e)
		{
			result = DialogResult.Cancel;
			Hide();
		}
		
		public new DialogResult ShowDialog()
		{
			base.ShowDialog();
			return result;
		}
	}
}
