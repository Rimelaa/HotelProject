namespace WindowsFormsApp1
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CleanerButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CleanerButton
            // 
            this.CleanerButton.Location = new System.Drawing.Point(249, 12);
            this.CleanerButton.Name = "CleanerButton";
            this.CleanerButton.Size = new System.Drawing.Size(231, 122);
            this.CleanerButton.TabIndex = 1;
            this.CleanerButton.Text = "Уборщик";
            this.CleanerButton.UseVisualStyleBackColor = true;
            this.CleanerButton.Click += new System.EventHandler(this.CleanerButton_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.Location = new System.Drawing.Point(12, 12);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(231, 122);
            this.AdminButton.TabIndex = 2;
            this.AdminButton.Text = "Администратор";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 150);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.CleanerButton);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CleanerButton;
        private System.Windows.Forms.Button AdminButton;
    }
}

