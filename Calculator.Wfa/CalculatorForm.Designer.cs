namespace Calculator.Wfa
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.FloorLengthLbl = new System.Windows.Forms.Label();
            this.FloorWidthLbl = new System.Windows.Forms.Label();
            this.FloorWidthTextBox = new System.Windows.Forms.TextBox();
            this.FloorLengthTextBox = new System.Windows.Forms.TextBox();
            this.MinExpenseResultLbl = new System.Windows.Forms.Label();
            this.ResultBtn = new System.Windows.Forms.Button();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.CovTypesPanel = new System.Windows.Forms.Panel();
            this.CovTypesInfoLbl = new System.Windows.Forms.Label();
            this.LaminateCheckBox = new System.Windows.Forms.CheckBox();
            this.CarpetCheckBox = new System.Windows.Forms.CheckBox();
            this.ParquetBoardCheckBox = new System.Windows.Forms.CheckBox();
            this.ParquetCheckBox = new System.Windows.Forms.CheckBox();
            this.LinoleumCheckBox = new System.Windows.Forms.CheckBox();
            this.CeramicTileCheckBox = new System.Windows.Forms.CheckBox();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.AreaLbl = new System.Windows.Forms.Label();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.ResultLogLbl = new System.Windows.Forms.Label();
            this.ResultLogPanel = new System.Windows.Forms.Panel();
            this.ClearCheckBoxesBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CatalogBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.CovTypesPanel.SuspendLayout();
            this.ResultLogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FloorLengthLbl
            // 
            this.FloorLengthLbl.AutoSize = true;
            this.FloorLengthLbl.Location = new System.Drawing.Point(314, 15);
            this.FloorLengthLbl.Name = "FloorLengthLbl";
            this.FloorLengthLbl.Size = new System.Drawing.Size(82, 13);
            this.FloorLengthLbl.TabIndex = 3;
            this.FloorLengthLbl.Text = "Floor length (m.)";
            // 
            // FloorWidthLbl
            // 
            this.FloorWidthLbl.AutoSize = true;
            this.FloorWidthLbl.Location = new System.Drawing.Point(500, 15);
            this.FloorWidthLbl.Name = "FloorWidthLbl";
            this.FloorWidthLbl.Size = new System.Drawing.Size(78, 13);
            this.FloorWidthLbl.TabIndex = 4;
            this.FloorWidthLbl.Text = "Floor width (m.)";
            // 
            // FloorWidthTextBox
            // 
            this.FloorWidthTextBox.Location = new System.Drawing.Point(596, 12);
            this.FloorWidthTextBox.Name = "FloorWidthTextBox";
            this.FloorWidthTextBox.Size = new System.Drawing.Size(75, 20);
            this.FloorWidthTextBox.TabIndex = 6;
            this.FloorWidthTextBox.TextChanged += new System.EventHandler(this.FloorWidthTextBox_TextChanged);
            // 
            // FloorLengthTextBox
            // 
            this.FloorLengthTextBox.Location = new System.Drawing.Point(404, 12);
            this.FloorLengthTextBox.Name = "FloorLengthTextBox";
            this.FloorLengthTextBox.Size = new System.Drawing.Size(75, 20);
            this.FloorLengthTextBox.TabIndex = 9;
            this.FloorLengthTextBox.TextChanged += new System.EventHandler(this.FloorLengthTextBox_TextChanged);
            // 
            // MinExpenseResultLbl
            // 
            this.MinExpenseResultLbl.AutoSize = true;
            this.MinExpenseResultLbl.Location = new System.Drawing.Point(192, 314);
            this.MinExpenseResultLbl.Name = "MinExpenseResultLbl";
            this.MinExpenseResultLbl.Size = new System.Drawing.Size(0, 13);
            this.MinExpenseResultLbl.TabIndex = 10;
            // 
            // ResultBtn
            // 
            this.ResultBtn.Location = new System.Drawing.Point(940, 267);
            this.ResultBtn.Name = "ResultBtn";
            this.ResultBtn.Size = new System.Drawing.Size(75, 23);
            this.ResultBtn.TabIndex = 12;
            this.ResultBtn.Text = "Get result";
            this.ResultBtn.UseVisualStyleBackColor = true;
            this.ResultBtn.Click += new System.EventHandler(this.ResultBtn_Click);
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(233, 20);
            this.ProjectNameTextBox.TabIndex = 13;
            // 
            // CovTypesPanel
            // 
            this.CovTypesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CovTypesPanel.Controls.Add(this.CovTypesInfoLbl);
            this.CovTypesPanel.Controls.Add(this.LaminateCheckBox);
            this.CovTypesPanel.Controls.Add(this.CarpetCheckBox);
            this.CovTypesPanel.Controls.Add(this.ParquetBoardCheckBox);
            this.CovTypesPanel.Controls.Add(this.ParquetCheckBox);
            this.CovTypesPanel.Controls.Add(this.LinoleumCheckBox);
            this.CovTypesPanel.Controls.Add(this.CeramicTileCheckBox);
            this.CovTypesPanel.Location = new System.Drawing.Point(12, 59);
            this.CovTypesPanel.Name = "CovTypesPanel";
            this.CovTypesPanel.Size = new System.Drawing.Size(115, 180);
            this.CovTypesPanel.TabIndex = 14;
            // 
            // CovTypesInfoLbl
            // 
            this.CovTypesInfoLbl.AutoSize = true;
            this.CovTypesInfoLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.CovTypesInfoLbl.Location = new System.Drawing.Point(0, 0);
            this.CovTypesInfoLbl.Name = "CovTypesInfoLbl";
            this.CovTypesInfoLbl.Size = new System.Drawing.Size(84, 13);
            this.CovTypesInfoLbl.TabIndex = 6;
            this.CovTypesInfoLbl.Text = "Covering Types:";
            // 
            // LaminateCheckBox
            // 
            this.LaminateCheckBox.AutoSize = true;
            this.LaminateCheckBox.Location = new System.Drawing.Point(3, 140);
            this.LaminateCheckBox.Name = "LaminateCheckBox";
            this.LaminateCheckBox.Size = new System.Drawing.Size(69, 17);
            this.LaminateCheckBox.TabIndex = 5;
            this.LaminateCheckBox.Text = "Laminate";
            this.LaminateCheckBox.UseVisualStyleBackColor = true;
            this.LaminateCheckBox.CheckedChanged += new System.EventHandler(this.LaminateCheckBox_CheckedChanged);
            // 
            // CarpetCheckBox
            // 
            this.CarpetCheckBox.AutoSize = true;
            this.CarpetCheckBox.Location = new System.Drawing.Point(3, 117);
            this.CarpetCheckBox.Name = "CarpetCheckBox";
            this.CarpetCheckBox.Size = new System.Drawing.Size(57, 17);
            this.CarpetCheckBox.TabIndex = 4;
            this.CarpetCheckBox.Text = "Carpet";
            this.CarpetCheckBox.UseVisualStyleBackColor = true;
            this.CarpetCheckBox.CheckedChanged += new System.EventHandler(this.CarpetCheckBox_CheckedChanged);
            // 
            // ParquetBoardCheckBox
            // 
            this.ParquetBoardCheckBox.AutoSize = true;
            this.ParquetBoardCheckBox.Location = new System.Drawing.Point(3, 94);
            this.ParquetBoardCheckBox.Name = "ParquetBoardCheckBox";
            this.ParquetBoardCheckBox.Size = new System.Drawing.Size(94, 17);
            this.ParquetBoardCheckBox.TabIndex = 3;
            this.ParquetBoardCheckBox.Text = "Parquet Board";
            this.ParquetBoardCheckBox.UseVisualStyleBackColor = true;
            this.ParquetBoardCheckBox.CheckedChanged += new System.EventHandler(this.ParquetBoardCheckBox_CheckedChanged);
            // 
            // ParquetCheckBox
            // 
            this.ParquetCheckBox.AutoSize = true;
            this.ParquetCheckBox.Location = new System.Drawing.Point(3, 71);
            this.ParquetCheckBox.Name = "ParquetCheckBox";
            this.ParquetCheckBox.Size = new System.Drawing.Size(63, 17);
            this.ParquetCheckBox.TabIndex = 2;
            this.ParquetCheckBox.Text = "Parquet";
            this.ParquetCheckBox.UseVisualStyleBackColor = true;
            this.ParquetCheckBox.CheckedChanged += new System.EventHandler(this.ParquetCheckBox_CheckedChanged);
            // 
            // LinoleumCheckBox
            // 
            this.LinoleumCheckBox.AutoSize = true;
            this.LinoleumCheckBox.Location = new System.Drawing.Point(3, 48);
            this.LinoleumCheckBox.Name = "LinoleumCheckBox";
            this.LinoleumCheckBox.Size = new System.Drawing.Size(68, 17);
            this.LinoleumCheckBox.TabIndex = 1;
            this.LinoleumCheckBox.Text = "Linoleum";
            this.LinoleumCheckBox.UseVisualStyleBackColor = true;
            this.LinoleumCheckBox.CheckedChanged += new System.EventHandler(this.LinoleumCheckBox_CheckedChanged);
            // 
            // CeramicTileCheckBox
            // 
            this.CeramicTileCheckBox.AutoSize = true;
            this.CeramicTileCheckBox.Location = new System.Drawing.Point(3, 25);
            this.CeramicTileCheckBox.Name = "CeramicTileCheckBox";
            this.CeramicTileCheckBox.Size = new System.Drawing.Size(84, 17);
            this.CeramicTileCheckBox.TabIndex = 0;
            this.CeramicTileCheckBox.Text = "Ceramic Tile";
            this.CeramicTileCheckBox.UseVisualStyleBackColor = true;
            this.CeramicTileCheckBox.CheckedChanged += new System.EventHandler(this.CeramicTileCheckBox_CheckedChanged);
            // 
            // InputPanel
            // 
            this.InputPanel.AutoSize = true;
            this.InputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPanel.Location = new System.Drawing.Point(133, 59);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(290, 75);
            this.InputPanel.TabIndex = 15;
            // 
            // AreaLbl
            // 
            this.AreaLbl.AutoSize = true;
            this.AreaLbl.Location = new System.Drawing.Point(722, 15);
            this.AreaLbl.Name = "AreaLbl";
            this.AreaLbl.Size = new System.Drawing.Size(60, 13);
            this.AreaLbl.TabIndex = 16;
            this.AreaLbl.Text = "Floor area: ";
            // 
            // OutputPanel
            // 
            this.OutputPanel.AutoSize = true;
            this.OutputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputPanel.Location = new System.Drawing.Point(429, 59);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(290, 75);
            this.OutputPanel.TabIndex = 16;
            // 
            // ResultLogLbl
            // 
            this.ResultLogLbl.AutoSize = true;
            this.ResultLogLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultLogLbl.Location = new System.Drawing.Point(0, 0);
            this.ResultLogLbl.Name = "ResultLogLbl";
            this.ResultLogLbl.Size = new System.Drawing.Size(0, 13);
            this.ResultLogLbl.TabIndex = 17;
            // 
            // ResultLogPanel
            // 
            this.ResultLogPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultLogPanel.Controls.Add(this.ResultLogLbl);
            this.ResultLogPanel.Location = new System.Drawing.Point(725, 59);
            this.ResultLogPanel.Name = "ResultLogPanel";
            this.ResultLogPanel.Size = new System.Drawing.Size(290, 125);
            this.ResultLogPanel.TabIndex = 18;
            // 
            // ClearCheckBoxesBtn
            // 
            this.ClearCheckBoxesBtn.Location = new System.Drawing.Point(12, 304);
            this.ClearCheckBoxesBtn.Name = "ClearCheckBoxesBtn";
            this.ClearCheckBoxesBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearCheckBoxesBtn.TabIndex = 19;
            this.ClearCheckBoxesBtn.Text = "Clear";
            this.ClearCheckBoxesBtn.UseVisualStyleBackColor = true;
            this.ClearCheckBoxesBtn.Click += new System.EventHandler(this.ClearCheckBoxesBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(725, 267);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 20;
            this.SaveBtn.Text = "Save to file";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CatalogBtn
            // 
            this.CatalogBtn.Location = new System.Drawing.Point(832, 267);
            this.CatalogBtn.Name = "CatalogBtn";
            this.CatalogBtn.Size = new System.Drawing.Size(75, 23);
            this.CatalogBtn.TabIndex = 21;
            this.CatalogBtn.Text = "Catalog";
            this.CatalogBtn.UseVisualStyleBackColor = true;
            this.CatalogBtn.Click += new System.EventHandler(this.CatalogBtn_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 519);
            this.Controls.Add(this.CatalogBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ClearCheckBoxesBtn);
            this.Controls.Add(this.ResultLogPanel);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.AreaLbl);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.CovTypesPanel);
            this.Controls.Add(this.ProjectNameTextBox);
            this.Controls.Add(this.ResultBtn);
            this.Controls.Add(this.MinExpenseResultLbl);
            this.Controls.Add(this.FloorLengthTextBox);
            this.Controls.Add(this.FloorWidthTextBox);
            this.Controls.Add(this.FloorWidthLbl);
            this.Controls.Add(this.FloorLengthLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculatorForm";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.CovTypesPanel.ResumeLayout(false);
            this.CovTypesPanel.PerformLayout();
            this.ResultLogPanel.ResumeLayout(false);
            this.ResultLogPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FloorLengthLbl;
        private System.Windows.Forms.Label FloorWidthLbl;
        private System.Windows.Forms.TextBox FloorWidthTextBox;
        private System.Windows.Forms.TextBox FloorLengthTextBox;
        private System.Windows.Forms.Label MinExpenseResultLbl;
        private System.Windows.Forms.Button ResultBtn;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.Panel CovTypesPanel;
        private System.Windows.Forms.CheckBox LaminateCheckBox;
        private System.Windows.Forms.CheckBox CarpetCheckBox;
        private System.Windows.Forms.CheckBox ParquetBoardCheckBox;
        private System.Windows.Forms.CheckBox ParquetCheckBox;
        private System.Windows.Forms.CheckBox LinoleumCheckBox;
        private System.Windows.Forms.CheckBox CeramicTileCheckBox;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Label AreaLbl;
        private System.Windows.Forms.Label CovTypesInfoLbl;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Label ResultLogLbl;
        private System.Windows.Forms.Panel ResultLogPanel;
        private System.Windows.Forms.Button ClearCheckBoxesBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CatalogBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

