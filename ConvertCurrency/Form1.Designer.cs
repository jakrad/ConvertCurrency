namespace ConvertCurrency
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            selectCurrency = new ComboBox();
            rateCurrency = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            amountToConvert = new TextBox();
            buttonConvert = new Button();
            resultConvert = new TextBox();
            label4 = new Label();
            radioButton_FromCurrencyToPLN = new RadioButton();
            radioButton_FromPLNToCurrency = new RadioButton();
            SuspendLayout();
            // 
            // selectCurrency
            // 
            selectCurrency.FormattingEnabled = true;
            selectCurrency.Location = new Point(8, 24);
            selectCurrency.Name = "selectCurrency";
            selectCurrency.Size = new Size(261, 23);
            selectCurrency.TabIndex = 0;
            selectCurrency.SelectedIndexChanged += selectCurrency_SelectedIndexChanged;
            // 
            // rateCurrency
            // 
            rateCurrency.Location = new Point(275, 24);
            rateCurrency.Name = "rateCurrency";
            rateCurrency.ReadOnly = true;
            rateCurrency.Size = new Size(100, 23);
            rateCurrency.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 6);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Kurs:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 6);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 3;
            label2.Text = "Waluta docelowa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 94);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 5;
            label3.Text = "Kwota do przeliczenia:";
            // 
            // amountToConvert
            // 
            amountToConvert.Location = new Point(8, 112);
            amountToConvert.Name = "amountToConvert";
            amountToConvert.Size = new Size(100, 23);
            amountToConvert.TabIndex = 4;
            amountToConvert.KeyPress += amountToConvert_KeyPress;
            // 
            // buttonConvert
            // 
            buttonConvert.Location = new Point(114, 112);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(155, 23);
            buttonConvert.TabIndex = 6;
            buttonConvert.Text = "Przelicz";
            buttonConvert.UseVisualStyleBackColor = true;
            buttonConvert.Click += buttonConvert_Click;
            // 
            // resultConvert
            // 
            resultConvert.Location = new Point(275, 112);
            resultConvert.Name = "resultConvert";
            resultConvert.ReadOnly = true;
            resultConvert.Size = new Size(100, 23);
            resultConvert.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(275, 94);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 8;
            label4.Text = "Wynik:";
            // 
            // radioButton_FromCurrencyToPLN
            // 
            radioButton_FromCurrencyToPLN.AutoSize = true;
            radioButton_FromCurrencyToPLN.Checked = true;
            radioButton_FromCurrencyToPLN.Location = new Point(10, 53);
            radioButton_FromCurrencyToPLN.Name = "radioButton_FromCurrencyToPLN";
            radioButton_FromCurrencyToPLN.Size = new Size(111, 19);
            radioButton_FromCurrencyToPLN.TabIndex = 9;
            radioButton_FromCurrencyToPLN.TabStop = true;
            radioButton_FromCurrencyToPLN.Text = "Z waluty na PLN";
            radioButton_FromCurrencyToPLN.UseVisualStyleBackColor = true;
            radioButton_FromCurrencyToPLN.CheckedChanged += radioButton_FromCurrencyToPLN_CheckedChanged;
            // 
            // radioButton_FromPLNToCurrency
            // 
            radioButton_FromPLNToCurrency.AutoSize = true;
            radioButton_FromPLNToCurrency.Location = new Point(135, 53);
            radioButton_FromPLNToCurrency.Name = "radioButton_FromPLNToCurrency";
            radioButton_FromPLNToCurrency.Size = new Size(111, 19);
            radioButton_FromPLNToCurrency.TabIndex = 10;
            radioButton_FromPLNToCurrency.Text = "Z PLN na walutę";
            radioButton_FromPLNToCurrency.UseVisualStyleBackColor = true;
            radioButton_FromPLNToCurrency.CheckedChanged += radioButton_FromPLNToCurrency_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 141);
            Controls.Add(radioButton_FromPLNToCurrency);
            Controls.Add(radioButton_FromCurrencyToPLN);
            Controls.Add(label4);
            Controls.Add(resultConvert);
            Controls.Add(buttonConvert);
            Controls.Add(label3);
            Controls.Add(amountToConvert);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rateCurrency);
            Controls.Add(selectCurrency);
            Name = "Form1";
            Text = "Kalkulator walutowy";
            Load += GetExchangeRates;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox selectCurrency;
        private TextBox rateCurrency;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox amountToConvert;
        private Button buttonConvert;
        private TextBox resultConvert;
        private Label label4;
        private RadioButton radioButton_FromCurrencyToPLN;
        private RadioButton radioButton_FromPLNToCurrency;
    }
}