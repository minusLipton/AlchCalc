﻿namespace AlchCalc
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
            this.tbResult1 = new System.Windows.Forms.TextBox();
            this.tbResult2 = new System.Windows.Forms.TextBox();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
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
            this.lblAmount.Location = new System.Drawing.Point(216, 189);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(105, 13);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Ilość sztuk naczynia:";
            this.lblAmount.UseMnemonic = false;
            // 
            // tbResult1
            // 
            this.tbResult1.Location = new System.Drawing.Point(324, 254);
            this.tbResult1.Name = "tbResult1";
            this.tbResult1.Size = new System.Drawing.Size(100, 20);
            this.tbResult1.TabIndex = 6;
            // 
            // tbResult2
            // 
            this.tbResult2.Location = new System.Drawing.Point(324, 289);
            this.tbResult2.Name = "tbResult2";
            this.tbResult2.Size = new System.Drawing.Size(100, 20);
            this.tbResult2.TabIndex = 7;
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Location = new System.Drawing.Point(200, 254);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(120, 13);
            this.lblResult1.TabIndex = 8;
            this.lblResult1.Text = "Wynik objetości napoju:";
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(147, 292);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(174, 13);
            this.lblResult2.TabIndex = 9;
            this.lblResult2.Text = "Wynik objetości czystego spirytusu:";
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(349, 330);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 10;
            this.bt1.Text = "Oblicz!";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // cb1
            // 
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "(none)",
            "Piwo",
            "Wino czerwone",
            "Wino białe",
            "Wódka",
            "Likier smakowy"});
            this.cb1.Location = new System.Drawing.Point(442, 110);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(90, 21);
            this.cb1.TabIndex = 11;
            // 
            // cb2
            // 
            this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "(none)",
            "kieliszek 20 ml",
            "kieliszek 50 ml",
            "szklanaka 100ml",
            "szklanka piwo 380ml",
            "kieliszek biale wino 250 ml",
            "kieliszek biale wino 360 ml",
            "kieliszek czerwone wino 450 ml",
            "kieliszek czerwone wino 580 ml"});
            this.cb2.Location = new System.Drawing.Point(547, 110);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(184, 21);
            this.cb2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.tbResult2);
            this.Controls.Add(this.tbResult1);
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
        private System.Windows.Forms.TextBox tbResult1;
        private System.Windows.Forms.TextBox tbResult2;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.ComboBox cb2;
    }
}

