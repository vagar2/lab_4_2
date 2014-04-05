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

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt_OK_Click(object sender, RoutedEventArgs e)
        {
            if (radioButton1.IsChecked == true)
            {
                Treugol T = new Treugol();
                textBox1.Text = Convert.ToString(T.get_A());
                textBox2.Text = Convert.ToString(T.get_B());
                textBox3.Text = Convert.ToString(T.get_C());
            }
            if (radioButton2.IsChecked == true)
            {
                if (
                    (tx1.Text=="") || 
                    (tx2.Text=="") || 
                    (tx3.Text=="") || 
                    (ty1.Text=="") ||
                    (ty2.Text=="") ||
                    (ty3.Text=="")
                    )
                {
                    MessageBox.Show("Не все координаты заполнены");
                    return;
                }
                
                Treugol T = new Treugol(Convert.ToInt32(tx1.Text), Convert.ToInt32(ty1.Text), Convert.ToInt32(tx2.Text), Convert.ToInt32(ty2.Text), Convert.ToInt32(tx3.Text), Convert.ToInt32(ty3.Text));
                textBox1.Text = Convert.ToString(T.get_A());
                textBox2.Text = Convert.ToString(T.get_B());
                textBox3.Text = Convert.ToString(T.get_C());
            }
            if ((radioButton2.IsChecked == false) && (radioButton1.IsChecked == false))
            {
                MessageBox.Show("Выберите способ задания треугольника");
            }
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            textBox1.IsEnabled = false;
            textBox2.IsEnabled = false;
            textBox3.IsEnabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            tx1.IsEnabled = true;
            tx2.IsEnabled = true;
            tx3.IsEnabled = true;
            ty1.IsEnabled = true;
            ty2.IsEnabled = true;
            ty3.IsEnabled = true;
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            textBox1.IsEnabled = true;
            textBox2.IsEnabled = true;
            textBox3.IsEnabled = true;
            tx1.IsEnabled = false;
            tx2.IsEnabled = false;
            tx3.IsEnabled = false;
            ty1.IsEnabled = false;
            ty2.IsEnabled = false;
            ty3.IsEnabled = false;
            tx1.Text = "";
            tx2.Text = "";
            tx3.Text = "";
            ty1.Text = "";
            ty2.Text = "";
            ty3.Text = "";
        }
    }
}
