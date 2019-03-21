using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVMS
{
    public partial class login : BaseUI
    {
        public login()
        {
            InitializeComponent();
        }

        private void bleftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stngsBtn_Click(object sender, EventArgs e)
        {
            settings s = new settings();
            MainClass.showWindow(s, MDI.ActiveForm);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            MainClass.showWindow(h, this, MDI.ActiveForm);
        }
    }
}
