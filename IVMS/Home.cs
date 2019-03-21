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
    public partial class Home : BaseUI
    {
        public Home()
        {
            InitializeComponent();
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Purchases p = new Purchases();
            MainClass.showWindow(p, MDI.ActiveForm);
        }
    }
}
