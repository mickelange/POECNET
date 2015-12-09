using FormationEF;
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

namespace FormationWpf
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Get_Book_Click(object sender, RoutedEventArgs e)
        {
            int idTemp = 1;
            if (Id_textBox.Text != null)
            {
                idTemp = int.Parse(Id_textBox.Text);
            }
            BookRepository bookRepo = new BookRepository();
            Book b = bookRepo.GetById(idTemp);

            Title_textBox.Text = b.Title;


        }
    }
}
