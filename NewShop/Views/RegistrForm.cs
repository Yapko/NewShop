using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Shop
{
    public partial class RegistrForm : Form
    {
        private Control control;        

        public RegistrForm(Control _ctrl)
        {
            control = _ctrl;
            InitializeComponent();           
        }

        public string getEmail()
        {
            return emailField.Text;
        }

        //public void enableRegistrationButton()
        //{
        //    button1.Enabled = true;
        //}

        //public void disableRegistrationButton()
        //{
        //    button1.Enabled = false;
        //}

        public Panel getPanel()
        {
            return panel1;
        }
        //email addresss validation
        private void emailField_LostFocus(object sender, EventArgs e)
        {            
            control.EmailAddressValidation(emailField, errorProvider2);
        }
        private void emailField_TextChanged(object sender, EventArgs e)
        {
            control.EmailTextChanged(emailField, errorProvider2);            
        }
        public ErrorProvider getErr2()
        {
            return errorProvider2;
        }
        public ErrorProvider getErr3()
        {
            return errorProvider3;
        }
        public TextBox getPass1Field()
        {
            return pass1Field;
        }

        public TextBox getPass2Field()
        {
            return pass2Field;
        }

        public TextBox getTel1Field()
        {
            return tel1Field;
        }

        public TextBox getTel2Field()
        {
            return tel2Field;
        }
        //password validation
        private void pass1Field_LostFocus(object sender, EventArgs e)
        {
            control.PasswordValidation();            
        }

        public void close()
        {
            this.Close();
        }
        //confirming password
        private void pass2Field_TextChanged(object sender, EventArgs e)
        {
            control.ConfirmingPassword();           
        }
        private void pass2Field_LostFocus(object sender, EventArgs e)
        {
            control.ConfirmingPassword();
        }
        public TextBox getTextBox1()
        {
            return textBox1;
        }

        public TextBox getName1Field()
        {
            return name1Field;
        }

        public TextBox getName2Field()
        {
            return name2Field;
        }

        public TextBox getUserNameField()
        {
            return usernameField;
        }

        public TextBox getEmailField()
        {
            return emailField;
        }
        //registration
        private void button1_Click_1(object sender, EventArgs e)
        {
            control.Registration();            
        }
        //phone number validation
        private void tel1Field_TextChanged(object sender, EventArgs e)
        {
            if (tel1Field.Text.Length == tel1Field.MaxLength)
            {
                tel2Field.Focus(); 
            }
        }

        private void tel1Field_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tel2Field_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void button1_EnabledChanged(object sender, EventArgs e)
        {
            bool val = (emailField.Text.Contains('@') && emailField.Text.Contains('.') && (emailField.Text.Length - emailField.Text.IndexOf('.') == 3 || emailField.Text.Length - emailField.Text.IndexOf('.') == 4));
            if (pass1Field.Text.Length < 8 || !System.Text.RegularExpressions.Regex.IsMatch(pass1Field.Text, @"\d"))
            {
                val = false;
            }
            if (!val)
            {
                button1.Enabled = false;
            }
        }

        private void pass1Field_TextChanged(object sender, EventArgs e)
        {
            pass1Field.ForeColor = Color.Black;
            errorProvider2.SetError(pass1Field, "");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            control.RefreshCaptcha();
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (control.ValidateCaptcha(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "");
            }
            else
            {
                errorProvider1.SetError(textBox1, "Wrong");
            }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            //captcha.ShowCaptcha();
            control.ShowCaptcha();
        }
    }
}
