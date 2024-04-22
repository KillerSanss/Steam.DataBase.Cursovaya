namespace steam
{
    partial class Form15
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
            Users = new DataGridView();
            label1 = new Label();
            ReturnButton = new Button();
            RoleField = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            SortButton = new Button();
            MinimumDateField = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            MaximumDateField = new DateTimePicker();
            CancelSortButton = new Button();
            DeleteUserButton = new Button();
            MinimumBallanceField = new NumericUpDown();
            MaximumBallanceField = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)Users).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimumBallanceField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaximumBallanceField).BeginInit();
            SuspendLayout();
            // 
            // Users
            // 
            Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Users.Location = new Point(12, 42);
            Users.Name = "Users";
            Users.RowHeadersWidth = 51;
            Users.Size = new Size(1091, 367);
            Users.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 1;
            label1.Text = "Список пользователей";
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(1009, 7);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(94, 29);
            ReturnButton.TabIndex = 2;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // RoleField
            // 
            RoleField.FormattingEnabled = true;
            RoleField.Items.AddRange(new object[] { "User", "Developer" });
            RoleField.Location = new Point(28, 479);
            RoleField.Name = "RoleField";
            RoleField.Size = new Size(151, 28);
            RoleField.TabIndex = 3;
            RoleField.Text = "None";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 423);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 4;
            label2.Text = "Сортировка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 456);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 5;
            label3.Text = "Роль";
            // 
            // SortButton
            // 
            SortButton.Location = new Point(733, 436);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(223, 29);
            SortButton.TabIndex = 6;
            SortButton.Text = "Сортировать";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // MinimumDateField
            // 
            MinimumDateField.Location = new Point(243, 477);
            MinimumDateField.Name = "MinimumDateField";
            MinimumDateField.Size = new Size(250, 27);
            MinimumDateField.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 454);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 8;
            label4.Text = "Дата регистрации";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(218, 482);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 9;
            label5.Text = "от";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(218, 517);
            label6.Name = "label6";
            label6.Size = new Size(26, 20);
            label6.TabIndex = 10;
            label6.Text = "до";
            // 
            // MaximumDateField
            // 
            MaximumDateField.Location = new Point(243, 510);
            MaximumDateField.Name = "MaximumDateField";
            MaximumDateField.Size = new Size(250, 27);
            MaximumDateField.TabIndex = 11;
            // 
            // CancelSortButton
            // 
            CancelSortButton.Location = new Point(733, 471);
            CancelSortButton.Name = "CancelSortButton";
            CancelSortButton.Size = new Size(223, 29);
            CancelSortButton.TabIndex = 12;
            CancelSortButton.Text = "Отменить сортировку";
            CancelSortButton.UseVisualStyleBackColor = true;
            CancelSortButton.Click += CancelSortButton_Click;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.Location = new Point(733, 506);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(223, 29);
            DeleteUserButton.TabIndex = 13;
            DeleteUserButton.Text = "Удалить пользователя";
            DeleteUserButton.UseVisualStyleBackColor = true;
            DeleteUserButton.Click += DeleteUserButton_Click;
            // 
            // MinimumBallanceField
            // 
            MinimumBallanceField.Location = new Point(548, 473);
            MinimumBallanceField.Name = "MinimumBallanceField";
            MinimumBallanceField.Size = new Size(150, 27);
            MinimumBallanceField.TabIndex = 14;
            // 
            // MaximumBallanceField
            // 
            MaximumBallanceField.Location = new Point(548, 508);
            MaximumBallanceField.Name = "MaximumBallanceField";
            MaximumBallanceField.Size = new Size(150, 27);
            MaximumBallanceField.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(548, 450);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 16;
            label7.Text = "Баланс";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(518, 480);
            label8.Name = "label8";
            label8.Size = new Size(24, 20);
            label8.TabIndex = 17;
            label8.Text = "от";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(518, 512);
            label9.Name = "label9";
            label9.Size = new Size(26, 20);
            label9.TabIndex = 18;
            label9.Text = "до";
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 561);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(MaximumBallanceField);
            Controls.Add(MinimumBallanceField);
            Controls.Add(DeleteUserButton);
            Controls.Add(CancelSortButton);
            Controls.Add(MaximumDateField);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(MinimumDateField);
            Controls.Add(SortButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(RoleField);
            Controls.Add(ReturnButton);
            Controls.Add(label1);
            Controls.Add(Users);
            Name = "Form15";
            Text = "Управление списком пользователей";
            ((System.ComponentModel.ISupportInitialize)Users).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimumBallanceField).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaximumBallanceField).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Users;
        private Label label1;
        private Button ReturnButton;
        private ComboBox RoleField;
        private Label label2;
        private Label label3;
        private Button SortButton;
        private DateTimePicker MinimumDateField;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker MaximumDateField;
        private Button CancelSortButton;
        private Button DeleteUserButton;
        private NumericUpDown MinimumBallanceField;
        private NumericUpDown MaximumBallanceField;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}