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
    }
}
