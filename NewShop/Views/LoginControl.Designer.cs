namespace Shop.Views
{
    partial class LoginControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SignBtn = new System.Windows.Forms.Button();
            this.RegistrBtn = new System.Windows.Forms.Button();
            this.lab1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignBtn
            // 
            this.SignBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SignBtn.Location = new System.Drawing.Point(46, 124);
            this.SignBtn.Name = "SignBtn";
            this.SignBtn.Size = new System.Drawing.Size(75, 23);
            this.SignBtn.TabIndex = 0;
            this.SignBtn.Text = "Sign in";
            this.SignBtn.UseVisualStyleBackColor = true;
            // 
            // RegistrBtn
            // 
            this.RegistrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrBtn.Location = new System.Drawing.Point(173, 124);
            this.RegistrBtn.Name = "RegistrBtn";
            this.RegistrBtn.Size = new System.Drawing.Size(75, 23);
            this.RegistrBtn.TabIndex = 1;
            this.RegistrBtn.Text = "Registration";
            this.RegistrBtn.UseVisualStyleBackColor = true;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(20, 46);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(78, 13);
            this.lab1.TabIndex = 2;
            this.lab1.Text = "E-mail address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password:";
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(104, 43);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(159, 20);
            this.EmailTxt.TabIndex = 4;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(104, 84);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(159, 20);
            this.PasswordTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.RegistrBtn);
            this.Controls.Add(this.SignBtn);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(294, 171);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignBtn;
        private System.Windows.Forms.Button RegistrBtn;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label label2;
    }
}
