using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetaguardaTelas
{
    public partial class FrmCadastroProduto : Form
    {
        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionarCodigoBarra_MouseHover(object sender, EventArgs e)
        {
            btnAdicionarCodigoBarra.BackColor = Color.Lavender;
        }

        private void btnAdicionarCodigoBarra_MouseLeave(object sender, EventArgs e)
        {
            btnAdicionarCodigoBarra.BackColor = Color.Transparent;

        }

        private void btnAdicionarCodigoBarra_MouseClick(object sender, MouseEventArgs e)
        {
            btnAdicionarCodigoBarra.BackColor = Color.Fuchsia;

        }

        private void btnAdicionarCodigoBarra_Click(object sender, EventArgs e)
        {
            bool _found = false;

            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FrmCadastroCodigoBarra)
                {
                    _openForm.Focus();

                    _found = true;
                }
            }
            if (!_found)
            {
                FrmCadastroCodigoBarra frmCadastroCodigoBarra = new FrmCadastroCodigoBarra();
                frmCadastroCodigoBarra.ShowDialog();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste Ricardo");
        }
    }
}
