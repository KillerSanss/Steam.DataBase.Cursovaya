namespace steam
{
    partial class Form7
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
            ReturnButton = new Button();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            MaximumDateField = new DateTimePicker();
            MinimumDateField = new DateTimePicker();
            label11 = new Label();
            StatusBox = new ComboBox();
            label12 = new Label();
            SortButton = new Button();
            CancelSortButton = new Button();
            AskButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            DescriptionField = new RichTextBox();
            TitleField = new TextBox();
            Questions = new ListBox();
            Statuses = new ListBox();
            MoreInformationButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 12);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 1;
            label1.Text = "Список вопросов";
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(501, 7);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(94, 29);
            ReturnButton.TabIndex = 8;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(601, 157);
            label8.Name = "label8";
            label8.Size = new Size(26, 20);
            label8.TabIndex = 31;
            label8.Text = "до";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(601, 131);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 30;
            label9.Text = "от";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(625, 103);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 29;
            label7.Text = "Дата создания";
            // 
            // MaximumDateField
            // 
            MaximumDateField.Location = new Point(631, 155);
            MaximumDateField.Name = "MaximumDateField";
            MaximumDateField.Size = new Size(255, 27);
            MaximumDateField.TabIndex = 28;
            // 
            // MinimumDateField
            // 
            MinimumDateField.Location = new Point(631, 126);
            MinimumDateField.Name = "MinimumDateField";
            MinimumDateField.Size = new Size(255, 27);
            MinimumDateField.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(614, 42);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 21;
            label11.Text = "Статус";
            // 
            // StatusBox
            // 
            StatusBox.FormattingEnabled = true;
            StatusBox.Items.AddRange(new object[] { "Active", "Resolved" });
            StatusBox.Location = new Point(614, 65);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(151, 28);
            StatusBox.TabIndex = 20;
            StatusBox.Text = "Active";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(689, 11);
            label12.Name = "label12";
            label12.Size = new Size(92, 20);
            label12.TabIndex = 19;
            label12.Text = "Сортировка";
            // 
            // SortButton
            // 
            SortButton.Location = new Point(614, 206);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(272, 29);
            SortButton.TabIndex = 32;
            SortButton.Text = "Сортировка";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // CancelSortButton
            // 
            CancelSortButton.Location = new Point(614, 238);
            CancelSortButton.Name = "CancelSortButton";
            CancelSortButton.Size = new Size(272, 29);
            CancelSortButton.TabIndex = 33;
            CancelSortButton.Text = "Отменить сортировку";
            CancelSortButton.UseVisualStyleBackColor = true;
            CancelSortButton.Click += CancelSortButton_Click;
            // 
            // AskButton
            // 
            AskButton.Location = new Point(12, 603);
            AskButton.Name = "AskButton";
            AskButton.Size = new Size(583, 29);
            AskButton.TabIndex = 39;
            AskButton.Text = "Задать вопрос";
            AskButton.UseVisualStyleBackColor = true;
            AskButton.Click += AskButton_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 348);
            label4.Name = "label4";
            label4.Size = new Size(373, 20);
            label4.TabIndex = 38;
            label4.Text = "Задайте свой вопрос, и возможно на него ответят!!!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 445);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 37;
            label3.Text = "Описание вопроса";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 380);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 36;
            label2.Text = "Тема вопроса";
            // 
            // DescriptionField
            // 
            DescriptionField.Location = new Point(15, 468);
            DescriptionField.Name = "DescriptionField";
            DescriptionField.Size = new Size(580, 120);
            DescriptionField.TabIndex = 35;
            DescriptionField.Text = "";
            // 
            // TitleField
            // 
            TitleField.Location = new Point(12, 403);
            TitleField.Name = "TitleField";
            TitleField.Size = new Size(583, 27);
            TitleField.TabIndex = 34;
            // 
            // Questions
            // 
            Questions.FormattingEnabled = true;
            Questions.Location = new Point(24, 42);
            Questions.Name = "Questions";
            Questions.Size = new Size(361, 244);
            Questions.TabIndex = 40;
            // 
            // Statuses
            // 
            Statuses.FormattingEnabled = true;
            Statuses.Location = new Point(395, 42);
            Statuses.Name = "Statuses";
            Statuses.Size = new Size(200, 244);
            Statuses.TabIndex = 41;
            // 
            // MoreInformationButton
            // 
            MoreInformationButton.Location = new Point(24, 303);
            MoreInformationButton.Name = "MoreInformationButton";
            MoreInformationButton.Size = new Size(571, 29);
            MoreInformationButton.TabIndex = 42;
            MoreInformationButton.Text = "Посмотреть подробную информацию о вопросе";
            MoreInformationButton.UseVisualStyleBackColor = true;
            MoreInformationButton.Click += MoreInformationButton_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 644);
            Controls.Add(MoreInformationButton);
            Controls.Add(Statuses);
            Controls.Add(Questions);
            Controls.Add(AskButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DescriptionField);
            Controls.Add(TitleField);
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
            Name = "Form7";
            Text = "Окно вопросов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button ReturnButton;
        private Label label8;
        private Label label9;
        private Label label7;
        private DateTimePicker MaximumDateField;
        private DateTimePicker MinimumDateField;
        private Label label11;
        private ComboBox StatusBox;
        private Label label12;
        private Button SortButton;
        private Button CancelSortButton;
        private Button AskButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private RichTextBox DescriptionField;
        private TextBox TitleField;
        private ListBox Questions;
        private ListBox Statuses;
        private Button MoreInformationButton;
    }
}