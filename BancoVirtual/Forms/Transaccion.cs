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
    public partial class Transaccion : Form
    {
        public Transaccion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmBanco openPage02 = new frmBanco();
            this.Hide();
            openPage02.ShowDialog();
            this.Close();
        }
    }
}
