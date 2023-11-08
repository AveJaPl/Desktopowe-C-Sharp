namespace Etap1
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
            mainLabel = new Label();
            hugeTextInput = new RichTextBox();
            textLenLabel = new Label();
            isAnyLetterLabel = new Label();
            isAnySpecialCharLabel = new Label();
            isAnyDigitLabel = new Label();
            textLenInput = new TextBox();
            isAnyLetterInput = new TextBox();
            isAnyDigitInput = new TextBox();
            isAnySpecialCharInput = new TextBox();
            analyzeButton = new Button();
            timeElapsedInput = new TextBox();
            timeElapsedLabel = new Label();
            SuspendLayout();
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            mainLabel.Location = new Point(12, 9);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(220, 28);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "Tekst wejściowy:";
            // 
            // hugeTextInput
            // 
            hugeTextInput.Location = new Point(12, 40);
            hugeTextInput.Name = "hugeTextInput";
            hugeTextInput.Size = new Size(612, 398);
            hugeTextInput.TabIndex = 1;
            hugeTextInput.Text = "";
            // 
            // textLenLabel
            // 
            textLenLabel.AutoSize = true;
            textLenLabel.Location = new Point(630, 40);
            textLenLabel.Name = "textLenLabel";
            textLenLabel.Size = new Size(88, 15);
            textLenLabel.TabIndex = 2;
            textLenLabel.Text = "Długość tekstu:";
            // 
            // isAnyLetterLabel
            // 
            isAnyLetterLabel.AutoSize = true;
            isAnyLetterLabel.Location = new Point(630, 100);
            isAnyLetterLabel.Name = "isAnyLetterLabel";
            isAnyLetterLabel.Size = new Size(94, 15);
            isAnyLetterLabel.TabIndex = 3;
            isAnyLetterLabel.Text = "Występują litery:";
            // 
            // isAnySpecialCharLabel
            // 
            isAnySpecialCharLabel.AutoSize = true;
            isAnySpecialCharLabel.Location = new Point(630, 220);
            isAnySpecialCharLabel.Name = "isAnySpecialCharLabel";
            isAnySpecialCharLabel.Size = new Size(147, 15);
            isAnySpecialCharLabel.TabIndex = 4;
            isAnySpecialCharLabel.Text = "Występują znaki specjalne:";
            // 
            // isAnyDigitLabel
            // 
            isAnyDigitLabel.AutoSize = true;
            isAnyDigitLabel.Location = new Point(630, 160);
            isAnyDigitLabel.Name = "isAnyDigitLabel";
            isAnyDigitLabel.Size = new Size(94, 15);
            isAnyDigitLabel.TabIndex = 5;
            isAnyDigitLabel.Text = "Występują cyfry:";
            // 
            // textLenInput
            // 
            textLenInput.Location = new Point(630, 58);
            textLenInput.Name = "textLenInput";
            textLenInput.Size = new Size(158, 23);
            textLenInput.TabIndex = 6;
            // 
            // isAnyLetterInput
            // 
            isAnyLetterInput.Location = new Point(630, 118);
            isAnyLetterInput.Name = "isAnyLetterInput";
            isAnyLetterInput.Size = new Size(158, 23);
            isAnyLetterInput.TabIndex = 7;
            // 
            // isAnyDigitInput
            // 
            isAnyDigitInput.Location = new Point(630, 178);
            isAnyDigitInput.Name = "isAnyDigitInput";
            isAnyDigitInput.Size = new Size(158, 23);
            isAnyDigitInput.TabIndex = 8;
            // 
            // isAnySpecialCharInput
            // 
            isAnySpecialCharInput.Location = new Point(630, 238);
            isAnySpecialCharInput.Name = "isAnySpecialCharInput";
            isAnySpecialCharInput.Size = new Size(158, 23);
            isAnySpecialCharInput.TabIndex = 9;
            // 
            // analyzeButton
            // 
            analyzeButton.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            analyzeButton.ForeColor = Color.Red;
            analyzeButton.Location = new Point(630, 383);
            analyzeButton.Name = "analyzeButton";
            analyzeButton.Size = new Size(158, 55);
            analyzeButton.TabIndex = 10;
            analyzeButton.Text = "Przeprowadź analize";
            analyzeButton.UseVisualStyleBackColor = true;
            analyzeButton.Click += analyzeButton_Click;
            // 
            // timeElapsedInput
            // 
            timeElapsedInput.Location = new Point(630, 358);
            timeElapsedInput.Name = "timeElapsedInput";
            timeElapsedInput.Size = new Size(158, 23);
            timeElapsedInput.TabIndex = 11;
            // 
            // timeElapsedLabel
            // 
            timeElapsedLabel.AutoSize = true;
            timeElapsedLabel.Location = new Point(630, 340);
            timeElapsedLabel.Name = "timeElapsedLabel";
            timeElapsedLabel.Size = new Size(79, 15);
            timeElapsedLabel.TabIndex = 12;
            timeElapsedLabel.Text = "Time elapsed:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(timeElapsedLabel);
            Controls.Add(timeElapsedInput);
            Controls.Add(analyzeButton);
            Controls.Add(isAnySpecialCharInput);
            Controls.Add(isAnyDigitInput);
            Controls.Add(isAnyLetterInput);
            Controls.Add(textLenInput);
            Controls.Add(isAnyDigitLabel);
            Controls.Add(isAnySpecialCharLabel);
            Controls.Add(isAnyLetterLabel);
            Controls.Add(textLenLabel);
            Controls.Add(hugeTextInput);
            Controls.Add(mainLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainLabel;
        private RichTextBox hugeTextInput;
        private Label textLenLabel;
        private Label isAnyLetterLabel;
        private Label isAnySpecialCharLabel;
        private Label isAnyDigitLabel;
        private TextBox textLenInput;
        private TextBox isAnyLetterInput;
        private TextBox isAnyDigitInput;
        private TextBox isAnySpecialCharInput;
        private Button analyzeButton;
        private TextBox timeElapsedInput;
        private Label timeElapsedLabel;
    }
}