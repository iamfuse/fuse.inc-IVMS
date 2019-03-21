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
    public partial class Products : BaseUI1
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {

        }
        public override void backBtn_Click(object sender, EventArgs e)
        {
            Purchases p = new Purchases();
            MainClass.showWindow(p, this, MDI.ActiveForm);
        }
    }
}
