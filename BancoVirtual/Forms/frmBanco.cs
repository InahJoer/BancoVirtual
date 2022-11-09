using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoVirtual.Forms
{
    public partial class frmBanco : Form
    {
        public frmBanco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transaccion openPage02 = new Transaccion();
            this.Hide();
            openPage02.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReporte openPage03 = new frmReporte();
            this.Hide();
            openPage03.ShowDialog();
            this.Close();

        }
    }
}
