namespace steam
{
    partial class Form12
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
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            MaximumDateField = new DateTimePicker();
            MinimumDateField = new DateTimePicker();
            CancelSortButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            MaximumPriceField = new NumericUpDown();
            MinimumPriceField = new NumericUpDown();
            label3 = new Label();
            SortButton = new Button();
            CategoryBox = new ComboBox();
            label2 = new Label();
            ProductList = new DataGridView();
            DeleteButton = new Button();
            ReturnButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)MaximumPriceField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimumPriceField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductList).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(359, 526);
            label8.Name = "label8";
            label8.Size = new Size(26, 20);
            label8.TabIndex = 35;
            label8.Text = "до";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(359, 500);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 34;
            label9.Text = "от";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(383, 472);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 33;
            label7.Text = "Дата разработки";
            // 
            // MaximumDateField
            // 
            MaximumDateField.Location = new Point(389, 524);
            MaximumDateField.Name = "MaximumDateField";
            MaximumDateField.Size = new Size(270, 27);
            MaximumDateField.TabIndex = 32;
            // 
            // MinimumDateField
            // 
            MinimumDateField.Location = new Point(389, 495);
            MinimumDateField.Name = "MinimumDateField";
            MinimumDateField.Size = new Size(270, 27);
            MinimumDateField.TabIndex = 31;
            // 
            // CancelSortButton
            // 
            CancelSortButton.Location = new Point(41, 585);
            CancelSortButton.Name = "CancelSortButton";
            CancelSortButton.Size = new Size(997, 29);
            CancelSortButton.TabIndex = 30;
            CancelSortButton.Text = "Отменить сортироку";
            CancelSortButton.UseVisualStyleBackColor = true;
            CancelSortButton.Click += CancelSortButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(198, 524);
            label6.Name = "label6";
            label6.Size = new Size(26, 20);
            label6.TabIndex = 29;
            label6.Text = "до";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 498);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 28;
            label5.Text = "от";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 472);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 27;
            label4.Text = "Цена";
            // 
            // MaximumPriceField
            // 
            MaximumPriceField.Location = new Point(230, 521);
            MaximumPriceField.Name = "MaximumPriceField";
            MaximumPriceField.Size = new Size(123, 27);
            MaximumPriceField.TabIndex = 26;
            // 
            // MinimumPriceField
            // 
            MinimumPriceField.Location = new Point(230, 495);
            MinimumPriceField.Name = "MinimumPriceField";
            MinimumPriceField.Size = new Size(123, 27);
            MinimumPriceField.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 493);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 24;
            label3.Text = "Категория";
            // 
            // SortButton
            // 
            SortButton.Location = new Point(41, 554);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(997, 29);
            SortButton.TabIndex = 23;
            SortButton.Text = "Сортировать";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // CategoryBox
            // 
            CategoryBox.FormattingEnabled = true;
            CategoryBox.Items.AddRange(new object[] { "Game", "Software" });
            CategoryBox.Location = new Point(41, 516);
            CategoryBox.Name = "CategoryBox";
            CategoryBox.Size = new Size(151, 28);
            CategoryBox.TabIndex = 22;
            CategoryBox.Text = "Game";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(493, 438);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 21;
            label2.Text = "Сортировка";
            // 
            // ProductList
            // 
            ProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductList.Location = new Point(41, 43);
            ProductList.Name = "ProductList";
            ProductList.RowHeadersWidth = 51;
            ProductList.Size = new Size(1312, 392);
            ProductList.TabIndex = 19;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(41, 620);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(997, 29);
            DeleteButton.TabIndex = 36;
            DeleteButton.Text = "Удалить выбранное";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(1259, 8);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(94, 29);
            ReturnButton.TabIndex = 37;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 17);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 38;
            label1.Text = "Ветрина";
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 657);
            Controls.Add(label1);
            Controls.Add(ReturnButton);
            Controls.Add(DeleteButton);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(MaximumDateField);
            Controls.Add(MinimumDateField);
            Controls.Add(CancelSortButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(MaximumPriceField);
            Controls.Add(MinimumPriceField);
            Controls.Add(label3);
            Controls.Add(SortButton);
            Controls.Add(CategoryBox);
            Controls.Add(label2);
            Controls.Add(ProductList);
            Name = "Form12";
            Text = "Управление магазином";
            ((System.ComponentModel.ISupportInitialize)MaximumPriceField).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimumPriceField).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label9;
        private Label label7;
        private DateTimePicker MaximumDateField;
        private DateTimePicker MinimumDateField;
        private Button CancelSortButton;
        private Label label6;
        private Label label5;
        private Label label4;
        private NumericUpDown MaximumPriceField;
        private NumericUpDown MinimumPriceField;
        private Label label3;
        private Button SortButton;
        private ComboBox CategoryBox;
        private Label label2;
        private DataGridView ProductList;
        private Button DeleteButton;
        private Button ReturnButton;
        private Label label1;
    }
}