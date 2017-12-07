using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDados;

namespace RetaguardaTelas
{
    public partial class FrmConsultarProduto : Form
    {
        public FrmConsultarProduto()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            bool _found = false;

            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FrmCadastroProduto)
                {
                    _openForm.Focus();

                    _found = true;
                }
            }
            if (!_found)
            {
                FrmCadastroProduto frmCadastroProduto = new FrmCadastroProduto();
                frmCadastroProduto.MdiParent = this.ParentForm;
                frmCadastroProduto.Show();
            }
        }
    }
}
