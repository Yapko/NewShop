namespace Shop.Views
{
    partial class ProductsListControl
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
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescribeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ManufacturerCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductsList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // NameCol
            // 
            this.NameCol.Text = "Name";
            // 
            // DescribeCol
            // 
            this.DescribeCol.Text = "Describe";
            // 
            // ManufacturerCol
            // 
            this.ManufacturerCol.Text = "Manufacturer";
            // 
            // PriceCol
            // 
            this.PriceCol.Text = "Price";
            // 
            // ProductsList
            // 
            this.ProductsList.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ProductsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCol,
            this.DescribeCol,
            this.ManufacturerCol,
            this.PriceCol});
            this.ProductsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ProductsList.FullRowSelect = true;
            this.ProductsList.GridLines = true;
            this.ProductsList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProductsList.Location = new System.Drawing.Point(0, 3);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(807, 695);
            this.ProductsList.TabIndex = 0;
            this.ProductsList.UseCompatibleStateImageBehavior = false;
            this.ProductsList.View = System.Windows.Forms.View.Details;
            this.ProductsList.DoubleClick += new System.EventHandler(this.ProductsList_DoubleClick);
            // 
            // ProductsListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.ProductsList);
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "ProductsListControl";
            this.Size = new System.Drawing.Size(810, 700);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.ColumnHeader DescribeCol;
        private System.Windows.Forms.ColumnHeader ManufacturerCol;
        private System.Windows.Forms.ColumnHeader PriceCol;
        private System.Windows.Forms.ListView ProductsList;

    }
}
