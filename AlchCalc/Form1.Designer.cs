namespace AlchCalc
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSize = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbContents = new System.Windows.Forms.TextBox();
            this.lblContents = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(220, 119);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(97, 13);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Wielkość naczyna:";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(324, 113);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(100, 20);
            this.tbSize.TabIndex = 1;
            // 
            // tbContents
            // 
            this.tbContents.Location = new System.Drawing.Point(324, 149);
            this.tbContents.Name = "tbContents";
            this.tbContents.Size = new System.Drawing.Size(100, 20);
            this.tbContents.TabIndex = 3;
            // 
            // lblContents
            // 
            this.lblContents.AutoSize = true;
            this.lblContents.Location = new System.Drawing.Point(112, 152);
            this.lblContents.Name = "lblContents";
            this.lblContents.Size = new System.Drawing.Size(209, 13);
            this.lblContents.TabIndex = 2;
            this.lblContents.Text = "Zawartość procentowa spirytusu w napoju:";
            this.lblContents.UseMnemonic = false;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(324, 186);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 20);
            this.tbAmount.TabIndex = 5;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(112, 189);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(209, 13);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Zawartość procentowa spirytusu w napoju:";
            this.lblAmount.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.tbContents);
            this.Controls.Add(this.lblContents);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.lblSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.TextBox tbContents;
        private System.Windows.Forms.Label lblContents;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lblAmount;
    }
}

