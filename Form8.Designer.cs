namespace steam
{
    partial class Form8
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
            TitleField = new TextBox();
            DescriptionField = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            ReturnButton = new Button();
            CategoryBox = new ComboBox();
            label3 = new Label();
            SubmitButton = new Button();
            PriceField = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)PriceField).BeginInit();
            SuspendLayout();
            // 
            // TitleField
            // 
            TitleField.Location = new Point(46, 52);
            TitleField.Name = "TitleField";
            TitleField.Size = new Size(439, 27);
            TitleField.TabIndex = 0;
            // 
            // DescriptionField
            // 
            DescriptionField.Location = new Point(46, 121);
            DescriptionField.Name = "DescriptionField";
            DescriptionField.Size = new Size(439, 120);
            DescriptionField.TabIndex = 1;
            DescriptionField.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 29);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 98);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(391, 12);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(94, 29);
            ReturnButton.TabIndex = 4;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // CategoryBox
            // 
            CategoryBox.FormattingEnabled = true;
            CategoryBox.Items.AddRange(new object[] { "Game", "Software" });
            CategoryBox.Location = new Point(44, 288);
            CategoryBox.Name = "CategoryBox";
            CategoryBox.Size = new Size(439, 28);
            CategoryBox.TabIndex = 5;
            CategoryBox.Text = "Game";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 265);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "Category";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(44, 431);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(437, 29);
            SubmitButton.TabIndex = 7;
            SubmitButton.Text = "Опубликовать";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // PriceField
            // 
            PriceField.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            PriceField.Location = new Point(44, 371);
            PriceField.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            PriceField.Name = "PriceField";
            PriceField.Size = new Size(441, 27);
            PriceField.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 348);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 9;
            label4.Text = "Price";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 489);
            Controls.Add(label4);
            Controls.Add(PriceField);
            Controls.Add(SubmitButton);
            Controls.Add(label3);
            Controls.Add(CategoryBox);
            Controls.Add(ReturnButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DescriptionField);
            Controls.Add(TitleField);
            Name = "Form8";
            Text = "Разработка продукта";
            ((System.ComponentModel.ISupportInitialize)PriceField).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TitleField;
        private RichTextBox DescriptionField;
        private Label label1;
        private Label label2;
        private Button ReturnButton;
        private ComboBox CategoryBox;
        private Label label3;
        private Button SubmitButton;
        private NumericUpDown PriceField;
        private Label label4;
    }
}