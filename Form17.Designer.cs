namespace steam
{
    partial class Form17
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
            TitleLabel = new Label();
            DescriptionField = new RichTextBox();
            AnswerField = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            CreationDateLabel = new Label();
            UserLabel = new Label();
            label5 = new Label();
            ReturnButton = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(25, 26);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(27, 20);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "///";
            // 
            // DescriptionField
            // 
            DescriptionField.Location = new Point(25, 95);
            DescriptionField.Name = "DescriptionField";
            DescriptionField.Size = new Size(270, 120);
            DescriptionField.TabIndex = 1;
            DescriptionField.Text = "";
            // 
            // AnswerField
            // 
            AnswerField.Location = new Point(25, 259);
            AnswerField.Name = "AnswerField";
            AnswerField.Size = new Size(270, 120);
            AnswerField.TabIndex = 2;
            AnswerField.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 72);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 3;
            label1.Text = "Описание";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 236);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 4;
            label2.Text = "Ответ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 408);
            label3.Name = "label3";
            label3.Size = new Size(176, 20);
            label3.TabIndex = 5;
            label3.Text = "Дата создания вопроса:";
            // 
            // CreationDateLabel
            // 
            CreationDateLabel.AutoSize = true;
            CreationDateLabel.Location = new Point(207, 408);
            CreationDateLabel.Name = "CreationDateLabel";
            CreationDateLabel.Size = new Size(27, 20);
            CreationDateLabel.TabIndex = 6;
            CreationDateLabel.Text = "///";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(141, 451);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(27, 20);
            UserLabel.TabIndex = 8;
            UserLabel.Text = "///";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 451);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 7;
            label5.Text = "Пользователь:";
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(310, 22);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(94, 29);
            ReturnButton.TabIndex = 9;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // Form17
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 518);
            Controls.Add(ReturnButton);
            Controls.Add(UserLabel);
            Controls.Add(label5);
            Controls.Add(CreationDateLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AnswerField);
            Controls.Add(DescriptionField);
            Controls.Add(TitleLabel);
            Name = "Form17";
            Text = "Подробная информация о вопросе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private RichTextBox DescriptionField;
        private RichTextBox AnswerField;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label CreationDateLabel;
        private Label UserLabel;
        private Label label5;
        private Button ReturnButton;
    }
}