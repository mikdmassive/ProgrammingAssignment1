namespace ProgrammingAssignment1Windform
{
    partial class DepositForm
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
            DepositGB = new GroupBox();
            ErrorMsg = new Label();
            DepositButton = new Button();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            DepositTextBox = new TextBox();
            DepositAmountLabel = new Label();
            radioButton1 = new RadioButton();
            DepositGB.SuspendLayout();
            SuspendLayout();
            // 
            // DepositGB
            // 
            DepositGB.Controls.Add(ErrorMsg);
            DepositGB.Controls.Add(DepositButton);
            DepositGB.Controls.Add(PasswordTextBox);
            DepositGB.Controls.Add(PasswordLabel);
            DepositGB.Controls.Add(DepositTextBox);
            DepositGB.Controls.Add(DepositAmountLabel);
            DepositGB.Location = new Point(12, 28);
            DepositGB.Name = "DepositGB";
            DepositGB.Size = new Size(357, 335);
            DepositGB.TabIndex = 0;
            DepositGB.TabStop = false;
            DepositGB.Text = "Deposit";
            // 
            // ErrorMsg
            // 
            ErrorMsg.AutoSize = true;
            ErrorMsg.Location = new Point(16, 207);
            ErrorMsg.Name = "ErrorMsg";
            ErrorMsg.Size = new Size(0, 25);
            ErrorMsg.TabIndex = 5;
            // 
            // DepositButton
            // 
            DepositButton.Location = new Point(85, 268);
            DepositButton.Name = "DepositButton";
            DepositButton.Size = new Size(182, 48);
            DepositButton.TabIndex = 4;
            DepositButton.Text = "Deposit";
            DepositButton.UseVisualStyleBackColor = true;
            DepositButton.Click += DepositButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(16, 151);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(329, 31);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.TextChanged += RemoveErrorMessage;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(16, 123);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(156, 25);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Confirm Password";
            // 
            // DepositTextBox
            // 
            DepositTextBox.Location = new Point(16, 72);
            DepositTextBox.Name = "DepositTextBox";
            DepositTextBox.Size = new Size(329, 31);
            DepositTextBox.TabIndex = 1;
            DepositTextBox.TextChanged += RemoveErrorMessage;
            // 
            // DepositAmountLabel
            // 
            DepositAmountLabel.AutoSize = true;
            DepositAmountLabel.Location = new Point(16, 44);
            DepositAmountLabel.Name = "DepositAmountLabel";
            DepositAmountLabel.Size = new Size(144, 25);
            DepositAmountLabel.TabIndex = 0;
            DepositAmountLabel.Text = "Deposit Amount";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(395, 192);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // DepositForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 388);
            Controls.Add(radioButton1);
            Controls.Add(DepositGB);
            Name = "DepositForm";
            Text = "Deposit Screen";
            Load += DepositForm_Load;
            DepositGB.ResumeLayout(false);
            DepositGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox DepositGB;
        private Button DepositButton;
        private TextBox PasswordTextBox;
        private Label PasswordLabel;
        private TextBox DepositTextBox;
        private Label DepositAmountLabel;
        private RadioButton radioButton1;
        private Label ErrorMsg;
    }
}