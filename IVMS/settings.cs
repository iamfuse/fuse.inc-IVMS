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

namespace IVMS
{
    public partial class settings : BaseUI
    {
        public settings()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //checkbox verification

            if (isCB.Checked)
            {
                if (serverTxt.Text != "" && sdbTxt.Text != "")
                {
                    s = "Data Source = " + serverTxt.Text + "; Initial Catalog = " + sdbTxt.Text + "; Integrated Security = true ;";
                    File.WriteAllText(path + "\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings Saved Succesfully", "Information", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
                    if (dr == DialogResult)
                    {
                        login log = new login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                    else
                    {
                        MessageBox.Show("Please Give Complete Details!");
                    }
                }
                else
                {
                    if (serverTxt.Text != "" && sdbTxt.Text != "" && suidTxt.Text != "" && spwdTxt.Text != "")
                    {
                        s = "Data Source = " + serverTxt.Text + "; Initial Catalog = " + sdbTxt.Text + "; User ID = " + suidTxt.Text + "; Password = " + spwdTxt.Text + ";";
                        File.WriteAllText(path + "//connect", s);
                        DialogResult dr = MessageBox.Show("Settings Saved Succesfully", "Information", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
                        if (dr == DialogResult)
                        {
                            login log = new login();
                            MainClass.showWindow(log, this, MDI.ActiveForm);
                        }
                        else
                        {
                            MessageBox.Show("Please Give Complete Details!");
                        }
                    }
                }
            }
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                suidTxt.Enabled = false;
                spwdTxt.Enabled = false;
                suidTxt.Text = "";
                spwdTxt.Text = "";
            }
            else
            {
                suidTxt.Enabled = true;
                spwdTxt.Enabled = true;
            }
        }
    }
}
