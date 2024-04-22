namespace steam
{
    partial class Form11
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
            menuStrip1 = new MenuStrip();
            NickNameField = new ToolStripMenuItem();
            ExitButton = new ToolStripMenuItem();
            StoreManagingButton = new ToolStripMenuItem();
            QuestionManagingButton = new ToolStripMenuItem();
            CardManagingButton = new ToolStripMenuItem();
            UserManagingButton = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { NickNameField, StoreManagingButton, QuestionManagingButton, CardManagingButton, UserManagingButton, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1013, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // NickNameField
            // 
            NickNameField.DropDownItems.AddRange(new ToolStripItem[] { ExitButton });
            NickNameField.Name = "NickNameField";
            NickNameField.Size = new Size(41, 24);
            NickNameField.Text = "///";
            // 
            // ExitButton
            // 
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(224, 26);
            ExitButton.Text = "Выйти из аккаунта";
            ExitButton.Click += ExitButton_Click;
            // 
            // StoreManagingButton
            // 
            StoreManagingButton.Name = "StoreManagingButton";
            StoreManagingButton.Size = new Size(178, 24);
            StoreManagingButton.Text = "Управлять магазином";
            StoreManagingButton.Click += StoreManagingButton_Click;
            // 
            // QuestionManagingButton
            // 
            QuestionManagingButton.Name = "QuestionManagingButton";
            QuestionManagingButton.Size = new Size(231, 24);
            QuestionManagingButton.Text = "Управлять списком вопросов";
            QuestionManagingButton.Click += QuestionManagingButton_Click;
            // 
            // CardManagingButton
            // 
            CardManagingButton.Name = "CardManagingButton";
            CardManagingButton.Size = new Size(193, 24);
            CardManagingButton.Text = "Управлять списком карт";
            CardManagingButton.Click += CardManagingButton_Click;
            // 
            // UserManagingButton
            // 
            UserManagingButton.Name = "UserManagingButton";
            UserManagingButton.Size = new Size(268, 24);
            UserManagingButton.Text = "Управлять списком пользователей";
            UserManagingButton.Click += UserManagingButton_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(14, 24);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(14, 24);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(14, 24);
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 30);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form11";
            Text = "Админ панель";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem NickNameField;
        private ToolStripMenuItem StoreManagingButton;
        private ToolStripMenuItem QuestionManagingButton;
        private ToolStripMenuItem ExitButton;
        private ToolStripMenuItem CardManagingButton;
        private ToolStripMenuItem UserManagingButton;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
    }
}