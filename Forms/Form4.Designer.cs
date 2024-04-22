namespace steam
{
    partial class Form4
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
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            StartRegistrationButton = new Button();
            EnterButton = new Button();
            IsAdmin = new CheckBox();
            SuspendLayout();
            // 
            // NickNameField
            // 
            NickNameField.Location = new Point(12, 47);
            NickNameField.Name = "NickNameField";
            NickNameField.Size = new Size(259, 27);
            NickNameField.TabIndex = 23;
            // 
            // PasswordField
            // 
            PasswordField.Location = new Point(12, 110);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(259, 27);
            PasswordField.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 24);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 25;
            label5.Text = "NickName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 87);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 26;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 234);
            label2.Name = "label2";
            label2.Size = new Size(246, 20);
            label2.TabIndex = 28;
            label2.Text = "Нет аккаунта? Зарегистрируйтесь!\r\n";
            // 
            // StartRegistrationButton
            // 
            StartRegistrationButton.Location = new Point(12, 271);
            StartRegistrationButton.Name = "StartRegistrationButton";
            StartRegistrationButton.Size = new Size(259, 29);
            StartRegistrationButton.TabIndex = 29;
            StartRegistrationButton.Text = "Регистрация";
            StartRegistrationButton.UseVisualStyleBackColor = true;
            StartRegistrationButton.Click += StartRegistrationButton_Click;
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(12, 149);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(259, 29);
            EnterButton.TabIndex = 30;
            EnterButton.Text = "Войти";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += EnterButton_Click;
            // 
            // IsAdmin
            // 
            IsAdmin.AutoSize = true;
            IsAdmin.Location = new Point(12, 194);
            IsAdmin.Name = "IsAdmin";
            IsAdmin.Size = new Size(148, 24);
            IsAdmin.TabIndex = 31;
            IsAdmin.Text = "Войти как админ";
            IsAdmin.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 320);
            Controls.Add(IsAdmin);
            Controls.Add(EnterButton);
            Controls.Add(StartRegistrationButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(PasswordField);
            Controls.Add(NickNameField);
            Name = "Form4";
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NickNameField;
        private TextBox PasswordField;
        private Label label5;
        private Label label1;
        private Label label2;
        private Button StartRegistrationButton;
        private Button EnterButton;
        private CheckBox IsAdmin;
    }
}