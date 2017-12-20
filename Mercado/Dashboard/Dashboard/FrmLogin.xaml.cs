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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Entity;

namespace Dashboard1
{
    /// <summary>
    /// Lógica interna para FrmLogin.xaml
    /// </summary>
    public partial class FrmLogin : Window
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSair_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAcessar_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=HOME-PC; Initial Catalog=dbMercado; Persist Security Info=True; User ID=sa; password=tecnologia");
            
            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                    sqlConnection.Open();
                string query = "SELECT COUNT(1) FROM TabelaCadUsuario WHERE login=@login AND senha=@senha";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@login", txtNome.Text);
                sqlCommand.Parameters.AddWithValue("@senha", txtSenha.Password);
                int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                if (count == 1)
                {
                    MainWindow dashboard1 = new MainWindow();
                    dashboard1.Show();
                    sqlConnection.Close();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Usuario ou Senha invalido!!");
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
