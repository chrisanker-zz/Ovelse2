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

namespace Ovelse2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string textBox1 = lineBox1.Text;
            string textBox2 = lineBox2.Text;
            string textBox3 = lineBox3.Text;
            string textBox4 = lineBox4.Text;
            lineBox4.Text = textBox1;
            lineBox3.Text = textBox4;
            lineBox2.Text = textBox3;
            lineBox1.Text = textBox2;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string textBox1 = lineBox1.Text;
            string textBox2 = lineBox2.Text;
            string textBox3 = lineBox3.Text;
            string textBox4 = lineBox4.Text;
            lineBox4.Text = textBox3;
            lineBox3.Text = textBox2;
            lineBox2.Text = textBox1;
            lineBox1.Text = textBox4;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lineBox1.Text = "";
            lineBox2.Text = "";
            lineBox3.Text = "";
            lineBox4.Text = "";
        }
    }
}
