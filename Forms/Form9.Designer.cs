namespace steam
{
    partial class Form9
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
            CardNumberField = new TextBox();
            NameOnCardField = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ExperationDateField = new DateTimePicker();
            label3 = new Label();
            CVVField = new TextBox();
            label4 = new Label();
            ConnectCardButton = new Button();
            ReturnButton = new Button();
            SuspendLayout();
            // 
            // CardNumberField
            // 
            CardNumberField.Location = new Point(12, 49);
            CardNumberField.Name = "CardNumberField";
            CardNumberField.Size = new Size(255, 27);
            CardNumberField.TabIndex = 0;
            // 
            // NameOnCardField
            // 
            NameOnCardField.Location = new Point(12, 204);
            NameOnCardField.Name = "NameOnCardField";
            NameOnCardField.Size = new Size(255, 27);
            NameOnCardField.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 181);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 2;
            label1.Text = "NameOnCard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 26);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 3;
            label2.Text = "CardNumber";
            // 
            // ExperationDateField
            // 
            ExperationDateField.Location = new Point(12, 125);
            ExperationDateField.Name = "ExperationDateField";
            ExperationDateField.Size = new Size(250, 27);
            ExperationDateField.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 5;
            label3.Text = "ExperationDate";
            // 
            // CVVField
            // 
            CVVField.Location = new Point(12, 281);
            CVVField.Name = "CVVField";
            CVVField.Size = new Size(94, 27);
            CVVField.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 258);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 7;
            label4.Text = "CVV";
            // 
            // ConnectCardButton
            // 
            ConnectCardButton.Location = new Point(17, 350);
            ConnectCardButton.Name = "ConnectCardButton";
            ConnectCardButton.Size = new Size(250, 29);
            ConnectCardButton.TabIndex = 8;
            ConnectCardButton.Text = "Привязать карту";
            ConnectCardButton.UseVisualStyleBackColor = true;
            ConnectCardButton.Click += ConnectCardButton_Click;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(229, 12);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(110, 29);
            ReturnButton.TabIndex = 9;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 417);
            Controls.Add(ReturnButton);
            Controls.Add(ConnectCardButton);
            Controls.Add(label4);
            Controls.Add(CVVField);
            Controls.Add(label3);
            Controls.Add(ExperationDateField);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NameOnCardField);
            Controls.Add(CardNumberField);
            Name = "Form9";
            Text = "Привязка карты";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CardNumberField;
        private TextBox NameOnCardField;
        private Label label1;
        private Label label2;
        private DateTimePicker ExperationDateField;
        private Label label3;
        private TextBox CVVField;
        private Label label4;
        private Button ConnectCardButton;
        private Button ReturnButton;
    }
}