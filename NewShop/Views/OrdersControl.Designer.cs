namespace Shop.Views
{
    partial class OrdersControl
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
            this.OrdersList = new System.Windows.Forms.DataGridView();
            this.CardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersList)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersList
            // 
            this.OrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CardNumber,
            this.ID,
            this.ProductID,
            this.UserID,
            this.ExpDate,
            this.Date,
            this.CVN,
            this.Status});
            this.OrdersList.Location = new System.Drawing.Point(0, 3);
            this.OrdersList.Name = "OrdersList";
            this.OrdersList.Size = new System.Drawing.Size(807, 695);
            this.OrdersList.TabIndex = 0;
            this.OrdersList.DoubleClick += new System.EventHandler(this.OrdersList_DoubleClick);
            // 
            // CardNumber
            // 
            this.CardNumber.HeaderText = "CardNumber";
            this.CardNumber.Name = "CardNumber";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            // 
            // ExpDate
            // 
            this.ExpDate.HeaderText = "ExpDate";
            this.ExpDate.Name = "ExpDate";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // CVN
            // 
            this.CVN.HeaderText = "CVN";
            this.CVN.Name = "CVN";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // OrdersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.OrdersList);
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "OrdersControl";
            this.Size = new System.Drawing.Size(810, 700);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;

    }
}
