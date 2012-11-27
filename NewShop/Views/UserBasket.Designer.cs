namespace Shop.Views
{
    partial class UserBasket
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
            this.UserProductsList = new System.Windows.Forms.ListView();
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescribeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ManufacturerCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // UserProductsList
            // 
            this.UserProductsList.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UserProductsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCol,
            this.DescribeCol,
            this.ManufacturerCol,
            this.PriceCol});
            this.UserProductsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserProductsList.FullRowSelect = true;
            this.UserProductsList.GridLines = true;
            this.UserProductsList.Location = new System.Drawing.Point(0, 3);
            this.UserProductsList.Name = "UserProductsList";
            this.UserProductsList.Size = new System.Drawing.Size(807, 695);
            this.UserProductsList.TabIndex = 0;
            this.UserProductsList.UseCompatibleStateImageBehavior = false;
            this.UserProductsList.View = System.Windows.Forms.View.Details;
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
            // UserBasked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.UserProductsList);
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "UserBasked";
            this.Size = new System.Drawing.Size(810, 700);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView UserProductsList;
        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.ColumnHeader DescribeCol;
        private System.Windows.Forms.ColumnHeader ManufacturerCol;
        private System.Windows.Forms.ColumnHeader PriceCol;
    }
}
