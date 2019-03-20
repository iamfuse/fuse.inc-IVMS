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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(Path + "\\connect"))
            {
                login log = new login();
                MainClass.showWindow(log, this);
            }
            else
            {
                settings s = new settings();
                MainClass.showWindow(s, this);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings s = new settings();
            MainClass.showWindow(s, this);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login log = new login();
            MainClass.showWindow(log,this);
        }
    }
}
