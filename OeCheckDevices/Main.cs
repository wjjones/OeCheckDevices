using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OeCheckDevices
{
    public partial class Main : Form
    {

        About aboutForm = new About();

        public Main()
        {
            InitializeComponent();

            tbIniFilePath.Text = "config.ini";
            tbSection.Text = "serverconfig";
            tbKey.Text = "";
            lblValue.Text = "";
            ReadIniFile();
            aboutForm.MdiParent = this;
            
        }

        private void btnReadValue_Click(object sender, EventArgs e)
        {
            string value = IniFileHelper.ReadValue(tbSection.Text, tbKey.Text, System.IO.Path.GetFullPath(tbIniFilePath.Text));
            tbIniFile.Text = value;
        }

        private void btnReadSection_Click(object sender, EventArgs e)
        {
            string[] values = IniFileHelper.ReadSections(System.IO.Path.GetFullPath(tbIniFilePath.Text));
            if (values != null)
            {
                string value = string.Join(Environment.NewLine, values);
                tbIniFile.Text = value;
            }
            else
            {
                tbIniFile.Text = "Reading sections failed.";
            }
        }

        private void btnReadKeys_Click(object sender, EventArgs e)
                {
                    string[] values = IniFileHelper.ReadKeys(tbSection.Text, System.IO.Path.GetFullPath(tbIniFilePath.Text));
                    if (values != null)
                    {
                        string value = string.Join(Environment.NewLine, values);
                        tbIniFile.Text = value;
                    }
                    else
                    {
                        tbIniFile.Text = "Reading keys failed.";
                    }
        }

        private void btnReadKeyValuePairs_Click(object sender, EventArgs e)
                {
                    string[] values = IniFileHelper.ReadKeyValuePairs(tbSection.Text, System.IO.Path.GetFullPath(tbIniFilePath.Text));
                    if (values != null)
                    {
                        string value = string.Join(Environment.NewLine, values);
                        tbIniFile.Text = value;
                    }
                    else
                    {
                        tbIniFile.Text = "Reading key value pairs failed.";
                    }
                }

        private void btnReadFile_Click(object sender, EventArgs e)
                {
                    ReadIniFile();
                }

        private void btnWriteValue_Click(object sender, EventArgs e)
                {
                    bool result = IniFileHelper.WriteValue(tbSection.Text, tbKey.Text, tbValue.Text, System.IO.Path.GetFullPath(tbIniFilePath.Text));
                    ReadIniFile();
                }

        private void btnDeleteSection_Click(object sender, EventArgs e)
                {
                    bool result = IniFileHelper.DeleteSection(tbSection.Text, System.IO.Path.GetFullPath(tbIniFilePath.Text));
                    ReadIniFile();
                }

        private void btnDeleteKey_Click(object sender, EventArgs e)
                {
                    bool result = IniFileHelper.DeleteKey(tbSection.Text, tbKey.Text, System.IO.Path.GetFullPath(tbIniFilePath.Text));
                    ReadIniFile();
                }

        private void ReadIniFile()
        {
            try
            {
                string text = File.ReadAllText(tbIniFilePath.Text);
                tbIniFile.Text = text;
            }
            catch (Exception)
            {
            }
        }

        private void btncheckini_Click(object sender, EventArgs e)
        {
            //string filePath = @"c:\Projects\sample.txt";

            if (File.Exists(tbIniFilePath.Text))
            {
                //Do something
                lblfileexists.Text = "File Exists";
            }
            else
            {
                lblfileexists.Text = "File Does not exist" ;
            }
        }

        private void btnCurrentDir_Click(object sender, EventArgs e)
        {
             string strCurrentDir = System.IO.Directory.GetCurrentDirectory();
            lblCurrentdir.Text = strCurrentDir;
        }

        private void tsAbout_Click(object sender, EventArgs e)
        {
            
            aboutForm.Show();
        }
    }
}
