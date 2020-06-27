namespace Calculator.Wfa
{
    partial class DataBase
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ManufacturersDataGridView = new System.Windows.Forms.DataGridView();
            this.ShowManufacturersBtn = new System.Windows.Forms.Button();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.ShowProductsBtn = new System.Windows.Forms.Button();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.ShowOrdersBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ManufacturersDataGridView
            // 
            this.ManufacturersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManufacturersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ManufacturersDataGridView.Name = "ManufacturersDataGridView";
            this.ManufacturersDataGridView.Size = new System.Drawing.Size(298, 145);
            this.ManufacturersDataGridView.TabIndex = 14;
            // 
            // ShowManufacturersBtn
            // 
            this.ShowManufacturersBtn.Location = new System.Drawing.Point(316, 134);
            this.ShowManufacturersBtn.Name = "ShowManufacturersBtn";
            this.ShowManufacturersBtn.Size = new System.Drawing.Size(106, 23);
            this.ShowManufacturersBtn.TabIndex = 15;
            this.ShowManufacturersBtn.Text = "Manufacturers";
            this.ShowManufacturersBtn.UseVisualStyleBackColor = true;
            this.ShowManufacturersBtn.Click += new System.EventHandler(this.ShowManufacturersBtn_Click);
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Location = new System.Drawing.Point(12, 163);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.Size = new System.Drawing.Size(298, 132);
            this.ProductDataGridView.TabIndex = 16;
            // 
            // ShowProductsBtn
            // 
            this.ShowProductsBtn.Location = new System.Drawing.Point(316, 272);
            this.ShowProductsBtn.Name = "ShowProductsBtn";
            this.ShowProductsBtn.Size = new System.Drawing.Size(99, 23);
            this.ShowProductsBtn.TabIndex = 17;
            this.ShowProductsBtn.Text = "Products";
            this.ShowProductsBtn.UseVisualStyleBackColor = true;
            this.ShowProductsBtn.Click += new System.EventHandler(this.ShowProductsBtn_Click);
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Location = new System.Drawing.Point(12, 301);
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.Size = new System.Drawing.Size(298, 150);
            this.OrdersDataGridView.TabIndex = 18;
            // 
            // ShowOrdersBtn
            // 
            this.ShowOrdersBtn.Location = new System.Drawing.Point(316, 428);
            this.ShowOrdersBtn.Name = "ShowOrdersBtn";
            this.ShowOrdersBtn.Size = new System.Drawing.Size(99, 23);
            this.ShowOrdersBtn.TabIndex = 19;
            this.ShowOrdersBtn.Text = "Orders";
            this.ShowOrdersBtn.UseVisualStyleBackColor = true;
            this.ShowOrdersBtn.Click += new System.EventHandler(this.ShowOrdersBtn_Click);
            // 
            // DataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 525);
            this.Controls.Add(this.ShowOrdersBtn);
            this.Controls.Add(this.OrdersDataGridView);
            this.Controls.Add(this.ShowProductsBtn);
            this.Controls.Add(this.ProductDataGridView);
            this.Controls.Add(this.ShowManufacturersBtn);
            this.Controls.Add(this.ManufacturersDataGridView);
            this.Name = "DataBase";
            this.Text = "DataBase";
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ManufacturersDataGridView;
        private System.Windows.Forms.Button ShowManufacturersBtn;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Button ShowProductsBtn;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.Button ShowOrdersBtn;
    }
}