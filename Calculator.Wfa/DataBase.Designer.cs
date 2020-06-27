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
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.Cost1Lbl = new System.Windows.Forms.Label();
            this.Cost1TextBox = new System.Windows.Forms.TextBox();
            this.CostOptTextBox = new System.Windows.Forms.TextBox();
            this.CostOptLbl = new System.Windows.Forms.Label();
            this.ManufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.ManufacturerLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CoverageTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AddProductPanel = new System.Windows.Forms.Panel();
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
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(736, 70);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(104, 21);
            this.AddProductBtn.TabIndex = 20;
            this.AddProductBtn.Text = "Add new product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // Cost1Lbl
            // 
            this.Cost1Lbl.AutoSize = true;
            this.Cost1Lbl.Location = new System.Drawing.Point(467, 48);
            this.Cost1Lbl.Name = "Cost1Lbl";
            this.Cost1Lbl.Size = new System.Drawing.Size(37, 13);
            this.Cost1Lbl.TabIndex = 21;
            this.Cost1Lbl.Text = "Cost1:";
            // 
            // Cost1TextBox
            // 
            this.Cost1TextBox.Location = new System.Drawing.Point(552, 45);
            this.Cost1TextBox.Name = "Cost1TextBox";
            this.Cost1TextBox.Size = new System.Drawing.Size(150, 20);
            this.Cost1TextBox.TabIndex = 22;
            // 
            // CostOptTextBox
            // 
            this.CostOptTextBox.Location = new System.Drawing.Point(552, 71);
            this.CostOptTextBox.Name = "CostOptTextBox";
            this.CostOptTextBox.Size = new System.Drawing.Size(150, 20);
            this.CostOptTextBox.TabIndex = 24;
            // 
            // CostOptLbl
            // 
            this.CostOptLbl.AutoSize = true;
            this.CostOptLbl.Location = new System.Drawing.Point(467, 74);
            this.CostOptLbl.Name = "CostOptLbl";
            this.CostOptLbl.Size = new System.Drawing.Size(48, 13);
            this.CostOptLbl.TabIndex = 23;
            this.CostOptLbl.Text = "CostOpt:";
            // 
            // ManufacturerComboBox
            // 
            this.ManufacturerComboBox.FormattingEnabled = true;
            this.ManufacturerComboBox.Location = new System.Drawing.Point(552, 97);
            this.ManufacturerComboBox.Name = "ManufacturerComboBox";
            this.ManufacturerComboBox.Size = new System.Drawing.Size(150, 21);
            this.ManufacturerComboBox.TabIndex = 25;
            // 
            // ManufacturerLbl
            // 
            this.ManufacturerLbl.AutoSize = true;
            this.ManufacturerLbl.Location = new System.Drawing.Point(467, 100);
            this.ManufacturerLbl.Name = "ManufacturerLbl";
            this.ManufacturerLbl.Size = new System.Drawing.Size(73, 13);
            this.ManufacturerLbl.TabIndex = 26;
            this.ManufacturerLbl.Text = "Manufacturer:";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(466, 22);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(38, 13);
            this.NameLbl.TabIndex = 27;
            this.NameLbl.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(552, 19);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 20);
            this.NameTextBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Coverage type:";
            // 
            // CoverageTypeComboBox
            // 
            this.CoverageTypeComboBox.FormattingEnabled = true;
            this.CoverageTypeComboBox.Location = new System.Drawing.Point(552, 124);
            this.CoverageTypeComboBox.Name = "CoverageTypeComboBox";
            this.CoverageTypeComboBox.Size = new System.Drawing.Size(150, 21);
            this.CoverageTypeComboBox.TabIndex = 30;
            // 
            // AddProductPanel
            // 
            this.AddProductPanel.Location = new System.Drawing.Point(457, 12);
            this.AddProductPanel.Name = "AddProductPanel";
            this.AddProductPanel.Size = new System.Drawing.Size(393, 145);
            this.AddProductPanel.TabIndex = 31;
            // 
            // DataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 525);
            this.Controls.Add(this.CoverageTypeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.ManufacturerLbl);
            this.Controls.Add(this.ManufacturerComboBox);
            this.Controls.Add(this.CostOptTextBox);
            this.Controls.Add(this.CostOptLbl);
            this.Controls.Add(this.Cost1TextBox);
            this.Controls.Add(this.Cost1Lbl);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.ShowOrdersBtn);
            this.Controls.Add(this.OrdersDataGridView);
            this.Controls.Add(this.ShowProductsBtn);
            this.Controls.Add(this.ProductDataGridView);
            this.Controls.Add(this.ShowManufacturersBtn);
            this.Controls.Add(this.ManufacturersDataGridView);
            this.Controls.Add(this.AddProductPanel);
            this.Name = "DataBase";
            this.Text = "DataBase";
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ManufacturersDataGridView;
        private System.Windows.Forms.Button ShowManufacturersBtn;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Button ShowProductsBtn;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.Button ShowOrdersBtn;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Label Cost1Lbl;
        private System.Windows.Forms.TextBox Cost1TextBox;
        private System.Windows.Forms.TextBox CostOptTextBox;
        private System.Windows.Forms.Label CostOptLbl;
        private System.Windows.Forms.ComboBox ManufacturerComboBox;
        private System.Windows.Forms.Label ManufacturerLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CoverageTypeComboBox;
        private System.Windows.Forms.Panel AddProductPanel;
    }
}