namespace Calculator.Wfa
{
    partial class OutputPanel
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
            this.ResultValueLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultValueLbl
            // 
            this.ResultValueLbl.AutoSize = true;
            this.ResultValueLbl.Location = new System.Drawing.Point(3, 29);
            this.ResultValueLbl.Name = "ResultValueLbl";
            this.ResultValueLbl.Size = new System.Drawing.Size(83, 13);
            this.ResultValueLbl.TabIndex = 0;
            this.ResultValueLbl.Text = "CoverageType: ";
            // 
            // OutputPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResultValueLbl);
            this.Name = "OutputPanel";
            this.Size = new System.Drawing.Size(275, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label ResultValueLbl;
    }
}
