namespace Shop.Views
{
    partial class UserControlView
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.YouRole = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.OpenBasketBtn = new System.Windows.Forms.Button();
            this.ProductsListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(83, 40);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(55, 13);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome ";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(156, 40);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(35, 13);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "label2";
            // 
            // YouRole
            // 
            this.YouRole.AutoSize = true;
            this.YouRole.Location = new System.Drawing.Point(83, 87);
            this.YouRole.Name = "YouRole";
            this.YouRole.Size = new System.Drawing.Size(58, 13);
            this.YouRole.TabIndex = 2;
            this.YouRole.Text = "Your role : ";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(156, 87);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(35, 13);
            this.RoleLabel.TabIndex = 3;
            this.RoleLabel.Text = "label1";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Location = new System.Drawing.Point(33, 181);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccountButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountButton.Location = new System.Drawing.Point(147, 181);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(123, 23);
            this.AccountButton.TabIndex = 6;
            this.AccountButton.Text = "Personal Cabinet";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // OpenBasketBtn
            // 
            this.OpenBasketBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenBasketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBasketBtn.Location = new System.Drawing.Point(33, 147);
            this.OpenBasketBtn.Name = "OpenBasketBtn";
            this.OpenBasketBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBasketBtn.TabIndex = 7;
            this.OpenBasketBtn.Text = "Basket";
            this.OpenBasketBtn.UseVisualStyleBackColor = false;
            this.OpenBasketBtn.Click += new System.EventHandler(this.OpenBasketBtn_Click);
            // 
            // ProductsListBtn
            // 
            this.ProductsListBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductsListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsListBtn.Location = new System.Drawing.Point(147, 147);
            this.ProductsListBtn.Name = "ProductsListBtn";
            this.ProductsListBtn.Size = new System.Drawing.Size(123, 23);
            this.ProductsListBtn.TabIndex = 8;
            this.ProductsListBtn.Text = "Products";
            this.ProductsListBtn.UseVisualStyleBackColor = false;
            this.ProductsListBtn.Click += new System.EventHandler(this.ProductsListBtn_Click);
            // 
            // UserControlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.ProductsListBtn);
            this.Controls.Add(this.OpenBasketBtn);
            this.Controls.Add(this.AccountButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.YouRole);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "UserControlView";
            this.Size = new System.Drawing.Size(294, 226);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label YouRole;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button OpenBasketBtn;
        private System.Windows.Forms.Button ProductsListBtn;
    }
}
