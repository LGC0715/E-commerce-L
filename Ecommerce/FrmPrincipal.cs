using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ecommerce.Classes;
using Ecommerce.Formularios;

namespace Ecommerce
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
           
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

       

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cADASTRARNOVOUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios s = new frmUsuarios();
           s.ShowDialog();
        }

        
    }
}
