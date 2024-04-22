namespace steam
{
    partial class Form16
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
            Title = new Label();
            Description = new RichTextBox();
            label1 = new Label();
            DateOfDevelopment = new Label();
            ReturnButton = new Button();
            label2 = new Label();
            Developer = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(26, 23);
            Title.Name = "Title";
            Title.Size = new Size(38, 20);
            Title.TabIndex = 0;
            Title.Text = "Title";
            // 
            // Description
            // 
            Description.Location = new Point(26, 62);
            Description.Name = "Description";
            Description.Size = new Size(267, 120);
            Description.TabIndex = 1;
            Description.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 202);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 2;
            label1.Text = "Дата разработки:";
            // 
            // DateOfDevelopment
            // 
            DateOfDevelopment.AutoSize = true;
            DateOfDevelopment.Location = new Point(158, 202);
            DateOfDevelopment.Name = "DateOfDevelopment";
            DateOfDevelopment.Size = new Size(27, 20);
            DateOfDevelopment.TabIndex = 3;
            DateOfDevelopment.Text = "///";
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(323, 19);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(94, 29);
            ReturnButton.TabIndex = 4;
            ReturnButton.Text = "Закрыть";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 251);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 5;
            label2.Text = "Разработчик:";
            // 
            // Developer
            // 
            Developer.AutoSize = true;
            Developer.Location = new Point(132, 251);
            Developer.Name = "Developer";
            Developer.Size = new Size(27, 20);
            Developer.TabIndex = 6;
            Developer.Text = "///";
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 301);
            Controls.Add(Developer);
            Controls.Add(label2);
            Controls.Add(ReturnButton);
            Controls.Add(DateOfDevelopment);
            Controls.Add(label1);
            Controls.Add(Description);
            Controls.Add(Title);
            Name = "Form16";
            Text = "Подробная информация о товаре";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private RichTextBox Description;
        private Label label1;
        private Label DateOfDevelopment;
        private Button ReturnButton;
        private Label label2;
        private Label Developer;
    }
}