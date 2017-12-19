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
using CamadaDados;

namespace Dashboard1
{
    /// <summary>
    /// Lógica interna para FrmPesquisaProduto.xaml
    /// </summary>
    public partial class FrmPesquisaProduto : Window
    {
        public FrmPesquisaProduto()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            //O CODIGO ABAIXO FORCA O TEXTBOX (txtCodigo) ACEITAR APENAS NUMEROS
            KeyConverter key = new KeyConverter();

            if ((char.IsNumber((string)key.ConvertTo(e.Key, typeof(string)), 0) == false))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
