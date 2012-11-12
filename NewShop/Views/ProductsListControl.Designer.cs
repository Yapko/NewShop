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
            this.ProductsList = new System.Windows.Forms.ListView();
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescribeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ManufacturerCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ProductsList
            // 
            this.ProductsList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ProductsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCol,
            this.DescribeCol,
            this.ManufacturerCol,
            this.PriceCol});
            this.ProductsList.Location = new System.Drawing.Point(3, 3);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(571, 423);
            this.ProductsList.TabIndex = 0;
            this.ProductsList.UseCompatibleStateImageBehavior = false;
            this.ProductsList.View = System.Windows.Forms.View.Details;
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
            // ProductsListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.ProductsList);
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "ProductsListControl";
            this.Size = new System.Drawing.Size(577, 429);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ProductsList;
        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.ColumnHeader DescribeCol;
        private System.Windows.Forms.ColumnHeader ManufacturerCol;
        private System.Windows.Forms.ColumnHeader PriceCol;
    }
}
