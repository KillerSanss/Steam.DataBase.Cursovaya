namespace steam
{
    partial class Form13
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
            CancelSortButton = new Button();
            SortButton = new Button();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            MaximumDateField = new DateTimePicker();
            MinimumDateField = new DateTimePicker();
            label11 = new Label();
            StatusBox = new ComboBox();
            label12 = new Label();
            ReturnButton = new Button();
            label1 = new Label();
            Questions = new DataGridView();
            DeleteButton = new Button();
            AnswerButton = new Button();
            AnswerField = new RichTextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Questions).BeginInit();
            SuspendLayout();
            // 
            // CancelSortButton
            // 
            CancelSortButton.Location = new Point(519, 393);
            CancelSortButton.Name = "CancelSortButton";
            CancelSortButton.Size = new Size(258, 29);
            CancelSortButton.TabIndex = 46;
            CancelSortButton.Text = "Отменить сортировку";
            CancelSortButton.UseVisualStyleBackColor = true;
            CancelSortButton.Click += CancelSortButton_Click;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(519, 361);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(258, 29);
            SortButton.TabIndex = 45;
            SortButton.Text = "Сортировка";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(195, 419);
            label8.Name = "label8";
            label8.Size = new Size(26, 20);
            label8.TabIndex = 44;
            label8.Text = "до";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(195, 393);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 43;
            label9.Text = "от";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(219, 365);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 42;
            label7.Text = "Дата создания";
            // 
            // MaximumDateField
            // 
            MaximumDateField.Location = new Point(225, 417);
            MaximumDateField.Name = "MaximumDateField";
            MaximumDateField.Size = new Size(270, 27);
            MaximumDateField.TabIndex = 41;
            // 
            // MinimumDateField
            // 
            MinimumDateField.Location = new Point(225, 388);
            MinimumDateField.Name = "MinimumDateField";
            MinimumDateField.Size = new Size(270, 27);
            MinimumDateField.TabIndex = 40;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(27, 393);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 39;
            label11.Text = "Статус";
            // 
            // StatusBox
            // 
            StatusBox.FormattingEnabled = true;
            StatusBox.Items.AddRange(new object[] { "Active", "Resolved" });
            StatusBox.Location = new Point(27, 416);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(151, 28);
            StatusBox.TabIndex = 38;
            StatusBox.Text = "Active";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(354, 325);
            label12.Name = "label12";
            label12.Size = new Size(92, 20);
            label12.TabIndex = 37;
            label12.Text = "Сортировка";
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(1216, 9);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(94, 29);
            ReturnButton.TabIndex = 36;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 35;
            label1.Text = "Список вопросов";
            // 
            // Questions
            // 
            Questions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Questions.Location = new Point(24, 44);
            Questions.Name = "Questions";
            Questions.RowHeadersWidth = 51;
            Questions.Size = new Size(1286, 272);
            Questions.TabIndex = 34;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(519, 428);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(258, 29);
            DeleteButton.TabIndex = 47;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AnswerButton
            // 
            AnswerButton.Location = new Point(30, 627);
            AnswerButton.Name = "AnswerButton";
            AnswerButton.Size = new Size(747, 29);
            AnswerButton.TabIndex = 48;
            AnswerButton.Text = "Ответить";
            AnswerButton.UseVisualStyleBackColor = true;
            AnswerButton.Click += AnswerButton_Click;
            // 
            // AnswerField
            // 
            AnswerField.Location = new Point(30, 498);
            AnswerField.Name = "AnswerField";
            AnswerField.Size = new Size(747, 123);
            AnswerField.TabIndex = 49;
            AnswerField.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 475);
            label2.Name = "label2";
            label2.Size = new Size(318, 20);
            label2.TabIndex = 50;
            label2.Text = "Выберите вопрос и напишите на него ответ";
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 668);
            Controls.Add(label2);
            Controls.Add(AnswerField);
            Controls.Add(AnswerButton);
            Controls.Add(DeleteButton);
            Controls.Add(CancelSortButton);
            Controls.Add(SortButton);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(MaximumDateField);
            Controls.Add(MinimumDateField);
            Controls.Add(label11);
            Controls.Add(StatusBox);
            Controls.Add(label12);
            Controls.Add(ReturnButton);
            Controls.Add(label1);
            Controls.Add(Questions);
            Name = "Form13";
            Text = "Управление вопросами";
            ((System.ComponentModel.ISupportInitialize)Questions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelSortButton;
        private Button SortButton;
        private Label label8;
        private Label label9;
        private Label label7;
        private DateTimePicker MaximumDateField;
        private DateTimePicker MinimumDateField;
        private Label label11;
        private ComboBox StatusBox;
        private Label label12;
        private Button ReturnButton;
        private Label label1;
        private DataGridView Questions;
        private Button DeleteButton;
        private Button AnswerButton;
        private RichTextBox AnswerField;
        private Label label2;
    }
}