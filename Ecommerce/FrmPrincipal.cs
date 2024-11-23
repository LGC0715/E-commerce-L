using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ecommerce.Formularios;

namespace Ecommerce
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void blaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            FrmProdutos s = new FrmProdutos();
            s.ShowDialog();
        }

        private void vENDASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendas s = new FrmVendas();
            s.ShowDialog();
        }
    }
}
