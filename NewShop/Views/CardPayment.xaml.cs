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
        /// <summary>
        /// main controler
        /// </summary>
        private MainController control;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardPayment" /> class.
        /// </summary>
        /// <param name="ctrl"> main controler</param>
        public CardPayment(MainController ctrl)
        {
            InitializeComponent();
            control = ctrl;
        }

        /// <summary>
        /// validate and write card 
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">param</param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!control.ValidateCardNumber(GetPart1(), GetPart2(), GetPart3(), GetPart4()))
            {
                MessageBox.Show("Wrong number", "error");
            }
            else
            { //control.PayAndWrite();
                MessageBox.Show("Ok", "WTF WPF?)");
            }
        }

        /// <summary>
        /// button cancel
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">param</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            control.DestroyPayment();
        }

        /// <summary>
        /// Get first part card code
        /// </summary>
        /// <returns>first part</returns>
        public string GetPart1()
        {
            return textBox2.Text;
        }

        /// <summary>
        /// Get second part card code
        /// </summary>
        /// <returns>second part</returns>
        public string GetPart2()
        {
            return textBox3.Text;
        }

        /// <summary>
        /// Get third part card code
        /// </summary>
        /// <returns>third part</returns>
        public string GetPart3()
        {
            return textBox4.Text;
        }

        /// <summary>
        /// Get fourth part card code
        /// </summary>
        /// <returns>fourth part</returns>
        public string GetPart4()
        {
            return textBox5.Text;
        }

        /// <summary>
        ///  Get CVN card code
        /// </summary>
        /// <returns>CVN</returns>
        public string GetCvn()
        {
            return textBox1.Text;
        }

        /// <summary>
        /// Get month
        /// </summary>
        /// <returns>month</returns>
        public string GetMonth()
        {
            return comboBox1.Text;
        }

        /// <summary>
        /// Get year
        /// </summary>
        /// <returns>year</returns>
        public string GetYear()
        {
            return comboBox2.Text;
        }

        /// <summary>
        /// Moves the cursor
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">param</param>
        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox2.Text.Count() == 4)
            {
                textBox3.Focus();
            }
        }

        /// <summary>
        /// Moves the cursor
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">param</param>
        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox3.Text.Count() == 4)
            {
                textBox4.Focus();
            }
        }

        /// <summary>
        /// Moves the cursor
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">param</param>
        private void TextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox4.Text.Count() == 4)
            {
                textBox5.Focus();
            }
        }

        /// <summary>
        /// Moves the cursor
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">param</param>
        private void TextBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox5.Text.Count() == 4)
            {
                textBox1.Focus();
            }
        }

        /// <summary>
        /// Moves the cursor and validate cvn code
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">param</param>
        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox1.Text.Count() == 3)
            {
                if (!control.ValidateCNVCode(GetCvn()))
                {
                    MessageBox.Show("Wrong code", "error");
                }
            }
        }

        /// <summary>
        /// Validate month
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">param</param>
        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox1.Text != string.Empty)
            {
                if (!control.ValidateExpDate(GetMonth(), GetYear()))
                {
                    MessageBox.Show("Wrong date", "error");
                }
            }
        }

        /// <summary>
        /// Validate year
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">param</param>
        private void ComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox2.Text != string.Empty)
            {
                if (!control.ValidateExpDate(GetMonth(), GetYear()))
                {
                    MessageBox.Show("Wrong date", "error");
                }
            }
        }
    }
}
