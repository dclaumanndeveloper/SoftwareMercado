using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Dashboard1
{
    /// <summary>
    /// Lógica interna para FrmProduto.xaml
    /// </summary>
    public partial class FrmProduto : Window
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void txtDescricaoCompleta_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void DatePicker_MouseEnter(object sender, MouseEventArgs e)
        {
           
        }

        private void btnAdicionarCodigo_Click(object sender, RoutedEventArgs e)
        {
            FrmCadastroCodigoBarra frmCadastroCodigoBarra = new FrmCadastroCodigoBarra();
            frmCadastroCodigoBarra.ShowDialog();
        }
    }
}
