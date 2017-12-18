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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dashboard1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FrmPesquisaProduto frmPesquisaProduto = new FrmPesquisaProduto();
            frmPesquisaProduto.ShowDialog();
        }

        private void btnCadProduto_Click(object sender, RoutedEventArgs e)
        {
           FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();
        }
    }
}
