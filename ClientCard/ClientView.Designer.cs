namespace ClientCard
{
    partial class ClientView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientView));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AvatarBox = new System.Windows.Forms.PictureBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            // 
            // AvatarBox
            // 
            resources.ApplyResources(this.AvatarBox, "AvatarBox");
            this.AvatarBox.Name = "AvatarBox";
            this.AvatarBox.TabStop = false;
            this.AvatarBox.UseWaitCursor = true;
            // 
            // DescriptionLabel
            // 
            resources.ApplyResources(this.DescriptionLabel, "DescriptionLabel");
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.UseCompatibleTextRendering = true;
            this.DescriptionLabel.UseWaitCursor = true;
            // 
            // PhoneLabel
            // 
            resources.ApplyResources(this.PhoneLabel, "PhoneLabel");
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.UseWaitCursor = true;
            // 
            // MailLabel
            // 
            resources.ApplyResources(this.MailLabel, "MailLabel");
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.UseWaitCursor = true;
            // 
            // ClientView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.AvatarBox);
            this.Controls.Add(this.TitleLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "ClientView";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClientView_MouseClick);
            this.MouseEnter += new System.EventHandler(this.ClientView_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ClientView_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox AvatarBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label MailLabel;
    }
}
