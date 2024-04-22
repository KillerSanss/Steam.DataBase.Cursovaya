namespace steam
{
    partial class Form3
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
            ProfileButton = new ToolStripMenuItem();
            UpdateProfileButton = new ToolStripMenuItem();
            ExitButton = new ToolStripMenuItem();
            ShopButton = new ToolStripMenuItem();
            AskButton = new ToolStripMenuItem();
            привязатьКартуToolStripMenuItem = new ToolStripMenuItem();
            ConnectCardButton = new ToolStripMenuItem();
            MoneyField = new ToolStripMenuItem();
            ProductsLabel = new Label();
            DevelopButton = new Button();
            Products = new ListBox();
            MoreInformationButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ProfileButton, ShopButton, AskButton, привязатьКартуToolStripMenuItem, MoneyField });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(452, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ProfileButton
            // 
            ProfileButton.DropDownItems.AddRange(new ToolStripItem[] { UpdateProfileButton, ExitButton });
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(110, 24);
            ProfileButton.Text = "Мой аккаунт";
            // 
            // UpdateProfileButton
            // 
            UpdateProfileButton.Name = "UpdateProfileButton";
            UpdateProfileButton.Size = new Size(220, 26);
            UpdateProfileButton.Text = "Изменить данные";
            UpdateProfileButton.Click += UpdateProfileButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(220, 26);
            ExitButton.Text = "Выйти из аккаунта";
            ExitButton.Click += ExitButton_Click;
            // 
            // ShopButton
            // 
            ShopButton.Name = "ShopButton";
            ShopButton.Size = new Size(83, 24);
            ShopButton.Text = "Магазин";
            ShopButton.Click += ShopButton_Click;
            // 
            // AskButton
            // 
            AskButton.Name = "AskButton";
            AskButton.Size = new Size(124, 24);
            AskButton.Text = "Задать вопрос";
            AskButton.Click += AskButton_Click;
            // 
            // привязатьКартуToolStripMenuItem
            // 
            привязатьКартуToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ConnectCardButton });
            привязатьКартуToolStripMenuItem.Name = "привязатьКартуToolStripMenuItem";
            привязатьКартуToolStripMenuItem.Size = new Size(63, 24);
            привязатьКартуToolStripMenuItem.Text = "Карта";
            // 
            // ConnectCardButton
            // 
            ConnectCardButton.Name = "ConnectCardButton";
            ConnectCardButton.Size = new Size(207, 26);
            ConnectCardButton.Text = "Привязать карту";
            ConnectCardButton.Click += ConnectCardButton_Click;
            // 
            // MoneyField
            // 
            MoneyField.Name = "MoneyField";
            MoneyField.Size = new Size(31, 24);
            MoneyField.Text = "0";
            // 
            // ProductsLabel
            // 
            ProductsLabel.AutoSize = true;
            ProductsLabel.Location = new Point(22, 39);
            ProductsLabel.Name = "ProductsLabel";
            ProductsLabel.Size = new Size(27, 20);
            ProductsLabel.TabIndex = 2;
            ProductsLabel.Text = "///";
            // 
            // DevelopButton
            // 
            DevelopButton.Location = new Point(22, 307);
            DevelopButton.Name = "DevelopButton";
            DevelopButton.Size = new Size(420, 29);
            DevelopButton.TabIndex = 4;
            DevelopButton.Text = "Разработать продукт";
            DevelopButton.UseVisualStyleBackColor = true;
            DevelopButton.Click += DevelopButton_Click;
            // 
            // Products
            // 
            Products.FormattingEnabled = true;
            Products.Location = new Point(22, 62);
            Products.Name = "Products";
            Products.Size = new Size(418, 204);
            Products.TabIndex = 5;
            // 
            // MoreInformationButton
            // 
            MoreInformationButton.Location = new Point(22, 272);
            MoreInformationButton.Name = "MoreInformationButton";
            MoreInformationButton.Size = new Size(418, 29);
            MoreInformationButton.TabIndex = 6;
            MoreInformationButton.Text = "Посмотреть подробную информацию";
            MoreInformationButton.UseVisualStyleBackColor = true;
            MoreInformationButton.Click += MoreInformationButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 341);
            Controls.Add(MoreInformationButton);
            Controls.Add(Products);
            Controls.Add(DevelopButton);
            Controls.Add(ProductsLabel);
            Controls.Add(menuStrip1);
            Name = "Form3";
            Text = "Домашняя страница";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ProfileButton;
        private ToolStripMenuItem UpdateProfileButton;
        private ToolStripMenuItem ExitButton;
        private ToolStripMenuItem ShopButton;
        private ToolStripMenuItem AskButton;
        private Label ProductsLabel;
        private DataGridView ConnectedProducts;
        private ToolStripMenuItem привязатьКартуToolStripMenuItem;
        private ToolStripMenuItem ConnectCardButton;
        private ToolStripMenuItem MoneyField;
        private Button DevelopButton;
        private ListBox Products;
        private Button MoreInformationButton;
    }
}