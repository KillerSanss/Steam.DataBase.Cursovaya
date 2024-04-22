namespace steam
{
    partial class Form5
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
            NickNameField = new TextBox();
            PasswordField = new TextBox();
            EmailField = new TextBox();
            ReturnButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            PhoneField = new TextBox();
            AcceptButton = new Button();
            label5 = new Label();
            NameField = new TextBox();
            SuspendLayout();
            // 
            // NickNameField
            // 
            NickNameField.Location = new Point(32, 101);
            NickNameField.Name = "NickNameField";
            NickNameField.Size = new Size(182, 27);
            NickNameField.TabIndex = 0;
            // 
            // PasswordField
            // 
            PasswordField.Location = new Point(32, 173);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(182, 27);
            PasswordField.TabIndex = 1;
            // 
            // EmailField
            // 
            EmailField.Location = new Point(32, 245);
            EmailField.Name = "EmailField";
            EmailField.Size = new Size(182, 27);
            EmailField.TabIndex = 2;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(255, 23);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(94, 29);
            ReturnButton.TabIndex = 3;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 77);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 4;
            label1.Text = "NickName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 150);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 222);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 295);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Phone";
            // 
            // PhoneField
            // 
            PhoneField.Location = new Point(32, 318);
            PhoneField.Name = "PhoneField";
            PhoneField.Size = new Size(182, 27);
            PhoneField.TabIndex = 8;
            // 
            // AcceptButton
            // 
            AcceptButton.Location = new Point(32, 364);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(182, 29);
            AcceptButton.TabIndex = 9;
            AcceptButton.Text = "Подтвердить";
            AcceptButton.UseVisualStyleBackColor = true;
            AcceptButton.Click += AcceptButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 12);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 11;
            label5.Text = "Name";
            // 
            // NameField
            // 
            NameField.Location = new Point(32, 36);
            NameField.Name = "NameField";
            NameField.Size = new Size(182, 27);
            NameField.TabIndex = 10;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 405);
            Controls.Add(label5);
            Controls.Add(NameField);
            Controls.Add(AcceptButton);
            Controls.Add(PhoneField);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ReturnButton);
            Controls.Add(EmailField);
            Controls.Add(PasswordField);
            Controls.Add(NickNameField);
            Name = "Form5";
            Text = "Изменение данных об аккаунте";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NickNameField;
        private TextBox PasswordField;
        private TextBox EmailField;
        private Button ReturnButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox PhoneField;
        private Button AcceptButton;
        private Label label5;
        private TextBox NameField;
    }
}