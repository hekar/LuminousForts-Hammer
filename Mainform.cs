using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LuminousFortsHammer
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            help.Text = Const.Instance().HelpText;
            Logger.Instance.Write("Starting LuminousForts Hammer Autoconfigurator");
        }

        private void okay_Click(object sender, EventArgs e)
        {
            String fullpath = "";
            SteamSearch search = new SteamSearch();
            foreach (string drive in Const.Instance().PossibleSteamDrives)
            {
                foreach (string path in Const.Instance().PossibleSteamLocations)
                {                    
                    if (search.IsSteamFolder(drive + path))
                    {
                        fullpath = drive + path;
                    }
                }
            }

            bool found = Directory.Exists(fullpath);
            if (found)
            {
                MessageBox.Show(fullpath, "Found your Steam folder");
            }
            else
            {
                MessageBox.Show("Could not find your Steam folder. Please select it", "Cannot Find Steam Folder");
                Logger.Instance.Write("Failure to find Steam Directory");
                
                FolderBrowserDialog dlg = new FolderBrowserDialog();

                try
                {
                    dlg.SelectedPath = Environment.GetEnvironmentVariable("HOMEDRIVE");
                }
                catch (Exception)
                {
                    dlg.SelectedPath = "";
                }

                DialogResult result = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    fullpath = dlg.SelectedPath;
                }
            }

            if (Directory.Exists(fullpath))
            {
            	if (!fullpath.EndsWith(Path.DirectorySeparatorChar.ToString()))
            	{
            		fullpath += Path.DirectorySeparatorChar;
            	}
            	
                try
                {
                    String username = AskUserName();
                    if (username != "")
                    {
                        GameConfig gameconfig = new LuminousFortsGameConfig();
                        try
                        {
                            Boolean wrote = gameconfig.WriteGameConfig(fullpath, username);
                            
                            if (wrote)
                            {
                            	MessageBox.Show("Successfully wrote gameconfig", "Success");
                            	Application.Exit();
                            }
                            else
                            {
                            	throw new Exception();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failure to write gameconfig", "Failure");
                            Logger.Instance.Write("(Mainform::Okay_Click) Failure to write game config");
            				Logger.Instance.Write(ex.Message);
            				Logger.Instance.Write(ex.StackTrace);
                        }
                    }
                }
                catch (KeyNotFoundException ex)
                {
					Logger.Instance.Write("(Mainform::Okay_Click) KeyNotFoundException");
    				Logger.Instance.Write(ex.Message);
    				Logger.Instance.Write(ex.StackTrace);                    
                }
            }
            else
            {
                MessageBox.Show("Could not find valid Steam directory", "Invalid Steam directory");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string AskUserName()
        {
            AskUserName dlg = new AskUserName();
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (dlg.Username == "")
                {
                    throw new KeyNotFoundException();
                }

                return dlg.Username;
            }
            else
            {
                return "";
            }
        }
        
        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
        	Application.Exit();
        }
        
        void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
        	About dlg = new About();
        	dlg.Show();
        }
    }
}
