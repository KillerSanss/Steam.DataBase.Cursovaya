namespace steam
{
    partial class Form6
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
            label1 = new Label();
            BuyButton = new Button();
            ReturnButton = new Button();
            label2 = new Label();
            CategoryBox = new ComboBox();
            SortButton = new Button();
            label3 = new Label();
            MinimumPriceField = new NumericUpDown();
            MaximumPriceField = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            CancelSortButton = new Button();
            MinimumDateField = new DateTimePicker();
            MaximumDateField = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Products = new ListBox();
            Prices = new ListBox();
            MoreInformationButton = new Button();
            ((System.ComponentModel.ISupportInitialize)MinimumPriceField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaximumPriceField).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 14);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Ветрина";
            // 
            // BuyButton
            // 
            BuyButton.Location = new Point(26, 352);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(411, 29);
            BuyButton.TabIndex = 2;
            BuyButton.Text = "Приобрести";
            BuyButton.UseVisualStyleBackColor = true;
            BuyButton.Click += BuyButton_Click;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(343, 12);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(94, 29);
            ReturnButton.TabIndex = 3;
            ReturnButton.Text = "Вернуться";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(582, 9);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 4;
            label2.Text = "Сортировка";
            // 
            // CategoryBox
            // 
            CategoryBox.FormattingEnabled = true;
            CategoryBox.Items.AddRange(new object[] { "Game", "Software" });
            CategoryBox.Location = new Point(457, 67);
            CategoryBox.Name = "CategoryBox";
            CategoryBox.Size = new Size(151, 28);
            CategoryBox.TabIndex = 5;
            CategoryBox.Text = "Game";
            // 
            // SortButton
            // 
            SortButton.Location = new Point(457, 237);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(317, 29);
            SortButton.TabIndex = 6;
            SortButton.Text = "Сортировать";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 39);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 7;
            label3.Text = "Категория";
            // 
            // MinimumPriceField
            // 
            MinimumPriceField.Location = new Point(651, 64);
            MinimumPriceField.Name = "MinimumPriceField";
            MinimumPriceField.Size = new Size(123, 27);
            MinimumPriceField.TabIndex = 8;
            // 
            // MaximumPriceField
            // 
            MaximumPriceField.Location = new Point(651, 90);
            MaximumPriceField.Name = "MaximumPriceField";
            MaximumPriceField.Size = new Size(123, 27);
            MaximumPriceField.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(651, 39);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 10;
            label4.Text = "Цена";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(619, 67);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 11;
            label5.Text = "от";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(619, 93);
            label6.Name = "label6";
            label6.Size = new Size(26, 20);
            label6.TabIndex = 12;
            label6.Text = "до";
            // 
            // CancelSortButton
            // 
            CancelSortButton.Location = new Point(457, 272);
            CancelSortButton.Name = "CancelSortButton";
            CancelSortButton.Size = new Size(317, 29);
            CancelSortButton.TabIndex = 13;
            CancelSortButton.Text = "Отменить сортироку";
            CancelSortButton.UseVisualStyleBackColor = true;
            CancelSortButton.Click += CanselSortButton_Click;
            // 
            // MinimumDateField
            // 
            MinimumDateField.Location = new Point(473, 164);
            MinimumDateField.Name = "MinimumDateField";
            MinimumDateField.Size = new Size(301, 27);
            MinimumDateField.TabIndex = 14;
            // 
            // MaximumDateField
            // 
            MaximumDateField.Location = new Point(473, 193);
            MaximumDateField.Name = "MaximumDateField";
            MaximumDateField.Size = new Size(301, 27);
            MaximumDateField.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(467, 141);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 16;
            label7.Text = "Дата разработки";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(443, 195);
            label8.Name = "label8";
            label8.Size = new Size(26, 20);
            label8.TabIndex = 18;
            label8.Text = "до";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(443, 169);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 17;
            label9.Text = "от";
            // 
            // Products
            // 
            Products.FormattingEnabled = true;
            Products.Location = new Point(25, 47);
            Products.Name = "Products";
            Products.Size = new Size(355, 264);
            Products.TabIndex = 19;
            // 
            // Prices
            // 
            Prices.FormattingEnabled = true;
            Prices.Location = new Point(386, 47);
            Prices.Name = "Prices";
            Prices.Size = new Size(50, 264);
            Prices.TabIndex = 20;
            // 
            // MoreInformationButton
            // 
            MoreInformationButton.Location = new Point(26, 317);
            MoreInformationButton.Name = "MoreInformationButton";
            MoreInformationButton.Size = new Size(410, 29);
            MoreInformationButton.TabIndex = 21;
            MoreInformationButton.Text = "Посмотреть подробную информацию";
            MoreInformationButton.UseVisualStyleBackColor = true;
            MoreInformationButton.Click += MoreInformationButton_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 401);
            Controls.Add(MoreInformationButton);
            Controls.Add(Prices);
            Controls.Add(Products);
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
            Controls.Add(ReturnButton);
            Controls.Add(BuyButton);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Магазин";
            ((System.ComponentModel.ISupportInitialize)MinimumPriceField).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaximumPriceField).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button BuyButton;
        private Button ReturnButton;
        private Label label2;
        private ComboBox CategoryBox;
        private Button SortButton;
        private Label label3;
        private NumericUpDown MinimumPriceField;
        private NumericUpDown MaximumPriceField;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button CancelSortButton;
        private DateTimePicker MinimumDateField;
        private DateTimePicker MaximumDateField;
        private Label label7;
        private Label label8;
        private Label label9;
        private ListBox Products;
        private ListBox Prices;
        private Button MoreInformationButton;
    }
}