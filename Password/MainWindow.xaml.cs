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
//using System.Windows.Forms;
//using System.Windows.Forms.Integration;

namespace Password
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string copy_string = " ";
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            if(Pass1.Password == "" || TextB.Text == "")
            {
                MessageBox.Show("Ошибка Данные поля пусты");
            }
            else
            {
                Pass1.Clear();
                TextB.Clear();
            }
            count++;
            CountLbl.Content = count;
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            if(TextB.Text == "")
            {
                MessageBox.Show("Поле пусто");
            }
            else
            {
                copy_string = TextB.Text.ToString();
            }
            count++;
            CountLbl.Content = count;
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            //ComboBoxItem selectedItem = (ComboBoxItem)Masks.SelectedItem;
            //string item = selectedItem.ToString();
            //Pass1.PasswordChar = Convert.ToChar(item);
            Pass1.PasswordChar = ((ComboBoxItem)Masks.SelectedItem).Content.ToString().ToCharArray()[0];
            Pass1.Password = copy_string;
            count++;
            CountLbl.Content = count;
        }
    }
}
