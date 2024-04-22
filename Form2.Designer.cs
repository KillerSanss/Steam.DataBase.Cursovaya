namespace steam
{
    partial class Form2
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
            label2 = new Label();
            PasswordField = new TextBox();
            label1 = new Label();
            NickNameField = new TextBox();
            label3 = new Label();
            NameField = new TextBox();
            label5 = new Label();
            EmailField = new TextBox();
            label6 = new Label();
            PhoneField = new TextBox();
            EndRegistrationButton = new Button();
            BackButton = new Button();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            IsDeveloper = new CheckBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 146);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // PasswordField
            // 
            PasswordField.Location = new Point(14, 169);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(336, 27);
            PasswordField.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // NickNameField
            // 
            NickNameField.Location = new Point(12, 103);
            NickNameField.Name = "NickNameField";
            NickNameField.Size = new Size(337, 27);
            NickNameField.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 80);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 17;
            label3.Text = "NickName";
            // 
            // NameField
            // 
            NameField.Location = new Point(14, 37);
            NameField.Name = "NameField";
            NameField.Size = new Size(337, 27);
            NameField.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 214);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 19;
            label5.Text = "Email";
            // 
            // EmailField
            // 
            EmailField.Location = new Point(16, 237);
            EmailField.Name = "EmailField";
            EmailField.Size = new Size(336, 27);
            EmailField.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 279);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 21;
            label6.Text = "Phone";
            // 
            // PhoneField
            // 
            PhoneField.Location = new Point(16, 302);
            PhoneField.Name = "PhoneField";
            PhoneField.Size = new Size(336, 27);
            PhoneField.TabIndex = 20;
            // 
            // EndRegistrationButton
            // 
            EndRegistrationButton.Location = new Point(18, 361);
            EndRegistrationButton.Name = "EndRegistrationButton";
            EndRegistrationButton.Size = new Size(336, 29);
            EndRegistrationButton.TabIndex = 30;
            EndRegistrationButton.Text = "Регистрация";
            EndRegistrationButton.UseVisualStyleBackColor = true;
            EndRegistrationButton.Click += EndRegistrationButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(364, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(103, 29);
            BackButton.TabIndex = 31;
            BackButton.Text = "Вернуться";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // IsDeveloper
            // 
            IsDeveloper.AutoSize = true;
            IsDeveloper.Location = new Point(360, 364);
            IsDeveloper.Name = "IsDeveloper";
            IsDeveloper.Size = new Size(133, 24);
            IsDeveloper.TabIndex = 32;
            IsDeveloper.Text = "Я разработчик";
            IsDeveloper.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 407);
            Controls.Add(IsDeveloper);
            Controls.Add(BackButton);
            Controls.Add(EndRegistrationButton);
            Controls.Add(label6);
            Controls.Add(PhoneField);
            Controls.Add(label5);
            Controls.Add(EmailField);
            Controls.Add(label3);
            Controls.Add(NameField);
            Controls.Add(label2);
            Controls.Add(PasswordField);
            Controls.Add(label1);
            Controls.Add(NickNameField);
            Name = "Form2";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox PasswordField;
        private Label label1;
        private TextBox NickNameField;
        private Label label3;
        private TextBox NameField;
        private Label label5;
        private TextBox EmailField;
        private Label label6;
        private TextBox PhoneField;
        private Button EndRegistrationButton;
        private Button BackButton;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private CheckBox IsDeveloper;
    }
}