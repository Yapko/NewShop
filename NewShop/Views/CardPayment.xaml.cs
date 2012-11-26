using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Shop.Controllers;

namespace Shop.Views
{
    /// <summary>
    /// Interaction logic for CardPayment.xaml
    /// </summary>
    public partial class CardPayment : UserControl
    {
        private MainController control;

        public CardPayment(MainController ctrl)
        {
            InitializeComponent();
            control = ctrl;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!control.ValidateCardNumber(getPart1(), getPart2(), getPart3(), getPart4()))
                MessageBox.Show("Wrong number", "error");
            //control.PayAndWrite();
            MessageBox.Show("Ok", "WTF WPF?)");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            control.DestroyPayment();
        }

        public string getPart1()
        {
            return textBox2.Text;
        }

        public string getPart2()
        {
            return textBox3.Text;
        }

        public string getPart3()
        {
            return textBox4.Text;
        }

        public string getPart4()
        {
            return textBox5.Text;
        }

        public string getCvn()
        {
            return textBox1.Text;
        }

        public string getMonth()
        {
            return comboBox1.Text;
        }

        public string getYear()
        {
            return comboBox2.Text;
        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox2.Text.Count() == 4)
            {
                textBox3.Focus();
            }
        }

        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox3.Text.Count() == 4)
            {
                textBox4.Focus();
            }
        }

        private void TextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox4.Text.Count() == 4)
            {
                textBox5.Focus();
            }
        }

        private void TextBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox5.Text.Count() == 4)
            {
                textBox1.Focus();
            }
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox1.Text.Count() == 3)
            {
                if (!control.ValidateCNVCode(getCvn()))
                    MessageBox.Show("Wrong code", "error");
            }
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox1.Text != string.Empty)
            {
                if (!control.ValidateExpDate(getMonth(), getYear()))
                    MessageBox.Show("Wrong date", "error");
            }
        }

        private void ComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox2.Text != string.Empty)
            {
                if (!control.ValidateExpDate(getMonth(), getYear()))
                    MessageBox.Show("Wrong date", "error");
            }
        }
    }
}
