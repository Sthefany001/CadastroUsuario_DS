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

namespace _2___Aula_02
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Usuario> listaUsu = new List<Usuario>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Usuario x = new Usuario();
            x.Nome = tb_nome.Text;
            x.DataNasc = datepicker.SelectedDate.Value;
            x.Cpf = tb_cpf.Text;
            x.Telefone = tb_telefone.Text;
            x.Genero = cb_genero.Text;
            x.Email = tb_email.Text;
            x.Senha = tb_senha.Text;

            listaUsu.Add(x);
        }
    }
}
