namespace steam
{
    partial class Form14
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
            Cards = new DataGridView();
            label1 = new Label();
            ReturnButton = new Button();
            SortButton = new Button();
            DeleteButton = new Button();
            CancelSortButton = new Button();
            label2 = new Label();
            MinimumDateField = new DateTimePicker();
            MaximumDateField = new DateTimePicker();
            MinimumBallanceField = new NumericUpDown();
            MaximumBallanceField = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)Cards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimumBallanceField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaximumBallanceField).BeginInit();
            SuspendLayout();
            // 
            // Cards
            // 
            Cards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Cards.Location = new Point(21, 46);
            Cards.Name = "Cards";
            Cards.RowHeadersWidth = 51;
            Cards.Size = new Size(1249, 326);
            Cards.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Список карт";
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(1176, 11);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(94, 29);
            ReturnButton.TabIndex = 2;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(517, 396);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(271, 29);
            SortButton.TabIndex = 3;
            SortButton.Text = "Сортировать";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(517, 463);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(271, 29);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // CancelSortButton
            // 
            CancelSortButton.Location = new Point(517, 428);
            CancelSortButton.Name = "CancelSortButton";
            CancelSortButton.Size = new Size(271, 29);
            CancelSortButton.TabIndex = 5;
            CancelSortButton.Text = "Отменить сортировку";
            CancelSortButton.UseVisualStyleBackColor = true;
            CancelSortButton.Click += CancelSortButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 375);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 6;
            label2.Text = "Сортировка";
            // 
            // MinimumDateField
            // 
            MinimumDateField.Location = new Point(34, 435);
            MinimumDateField.Name = "MinimumDateField";
            MinimumDateField.Size = new Size(250, 27);
            MinimumDateField.TabIndex = 7;
            // 
            // MaximumDateField
            // 
            MaximumDateField.Location = new Point(34, 468);
            MaximumDateField.Name = "MaximumDateField";
            MaximumDateField.Size = new Size(250, 27);
            MaximumDateField.TabIndex = 8;
            // 
            // MinimumBallanceField
            // 
            MinimumBallanceField.Location = new Point(334, 430);
            MinimumBallanceField.Name = "MinimumBallanceField";
            MinimumBallanceField.Size = new Size(150, 27);
            MinimumBallanceField.TabIndex = 9;
            // 
            // MaximumBallanceField
            // 
            MaximumBallanceField.Location = new Point(334, 463);
            MaximumBallanceField.Name = "MaximumBallanceField";
            MaximumBallanceField.Size = new Size(150, 27);
            MaximumBallanceField.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 412);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 11;
            label3.Text = "Дата просрочки";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 442);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 12;
            label4.Text = "от";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 470);
            label5.Name = "label5";
            label5.Size = new Size(26, 20);
            label5.TabIndex = 13;
            label5.Text = "до";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(334, 407);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 14;
            label6.Text = "Балланс";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(304, 437);
            label7.Name = "label7";
            label7.Size = new Size(24, 20);
            label7.TabIndex = 15;
            label7.Text = "от";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(304, 470);
            label8.Name = "label8";
            label8.Size = new Size(26, 20);
            label8.TabIndex = 16;
            label8.Text = "до";
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 520);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(MaximumBallanceField);
            Controls.Add(MinimumBallanceField);
            Controls.Add(MaximumDateField);
            Controls.Add(MinimumDateField);
            Controls.Add(label2);
            Controls.Add(CancelSortButton);
            Controls.Add(DeleteButton);
            Controls.Add(SortButton);
            Controls.Add(ReturnButton);
            Controls.Add(label1);
            Controls.Add(Cards);
            Name = "Form14";
            Text = "Управление картами";
            ((System.ComponentModel.ISupportInitialize)Cards).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimumBallanceField).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaximumBallanceField).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Cards;
        private Label label1;
        private Button ReturnButton;
        private Button SortButton;
        private Button DeleteButton;
        private Button CancelSortButton;
        private Label label2;
        private DateTimePicker MinimumDateField;
        private DateTimePicker MaximumDateField;
        private NumericUpDown MinimumBallanceField;
        private NumericUpDown MaximumBallanceField;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}