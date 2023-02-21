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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int first;
        int second;
        string? ope;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(Object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            text.Text += btn.Content.ToString();
            second=Int32.Parse(text.Text);

        }

        private void btndiv_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(text.Text);
            ope = "/";
            text.Clear();
        }

        private void btnmult_Click(object sender, RoutedEventArgs e)
        {
            first=Int32.Parse(text.Text);
            ope = "*";
            text.Clear();
        }

        private void btnsub_Click(object sender, RoutedEventArgs e)
        {
            first= Int32.Parse(text.Text);
            ope = "-";
            text.Clear();
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(text.Text);
            ope="+";
            text.Clear();
        }

        private void btnber_Click(object sender, RoutedEventArgs e)
        {
            second=Int32.Parse(text.Text);
            int result = 0;
            if (ope == "+")
            {
                result = first + second;
            }
            else if(ope == "-")
            {
                result=first-second;
            }
            else if (ope == "*")
            {
                _=result == first * second;
            }
            else if (ope == "/")
            {
                _ = result == first / second;
            }
            text.Text=result.ToString();

        }
    }
}
