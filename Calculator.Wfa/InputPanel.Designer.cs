namespace Calculator.Wfa
{
    partial class InputPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LengthLbl = new System.Windows.Forms.Label();
            this.WidthLbl = new System.Windows.Forms.Label();
            this.InputNameLbl = new System.Windows.Forms.Label();
            this.LengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.WidthNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // LengthLbl
            // 
            this.LengthLbl.AutoSize = true;
            this.LengthLbl.Location = new System.Drawing.Point(283, 59);
            this.LengthLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LengthLbl.Name = "LengthLbl";
            this.LengthLbl.Size = new System.Drawing.Size(81, 17);
            this.LengthLbl.TabIndex = 0;
            this.LengthLbl.Text = "Length (m.)";
            // 
            // WidthLbl
            // 
            this.WidthLbl.AutoSize = true;
            this.WidthLbl.Location = new System.Drawing.Point(68, 59);
            this.WidthLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WidthLbl.Name = "WidthLbl";
            this.WidthLbl.Size = new System.Drawing.Size(73, 17);
            this.WidthLbl.TabIndex = 1;
            this.WidthLbl.Text = "Width (m.)";
            // 
            // InputNameLbl
            // 
            this.InputNameLbl.AutoSize = true;
            this.InputNameLbl.Location = new System.Drawing.Point(4, 12);
            this.InputNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputNameLbl.Name = "InputNameLbl";
            this.InputNameLbl.Size = new System.Drawing.Size(48, 17);
            this.InputNameLbl.TabIndex = 2;
            this.InputNameLbl.Text = "Type: ";
            // 
            // LengthNumeric
            // 
            this.LengthNumeric.Location = new System.Drawing.Point(229, 31);
            this.LengthNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.LengthNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LengthNumeric.Name = "LengthNumeric";
            this.LengthNumeric.Size = new System.Drawing.Size(133, 22);
            this.LengthNumeric.TabIndex = 5;
            this.LengthNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WidthNumeric
            // 
            this.WidthNumeric.Location = new System.Drawing.Point(8, 31);
            this.WidthNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.WidthNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthNumeric.Name = "WidthNumeric";
            this.WidthNumeric.Size = new System.Drawing.Size(133, 22);
            this.WidthNumeric.TabIndex = 6;
            this.WidthNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // InputPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WidthNumeric);
            this.Controls.Add(this.LengthNumeric);
            this.Controls.Add(this.InputNameLbl);
            this.Controls.Add(this.WidthLbl);
            this.Controls.Add(this.LengthLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InputPanel";
            this.Size = new System.Drawing.Size(367, 86);
            ((System.ComponentModel.ISupportInitialize)(this.LengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LengthLbl;
        public System.Windows.Forms.Label WidthLbl;
        public System.Windows.Forms.Label InputNameLbl;
        public System.Windows.Forms.NumericUpDown LengthNumeric;
        public System.Windows.Forms.NumericUpDown WidthNumeric;
    }
}
