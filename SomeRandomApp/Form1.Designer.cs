namespace SomeRandomApp
{
    partial class SomeRandomApp
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BouncingButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BouncingButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(508, 303);
            this.MainPanel.TabIndex = 0;
            // 
            // BouncingButton
            // 
            this.BouncingButton.Location = new System.Drawing.Point(165, 88);
            this.BouncingButton.Name = "BouncingButton";
            this.BouncingButton.Size = new System.Drawing.Size(75, 23);
            this.BouncingButton.TabIndex = 0;
            this.BouncingButton.Text = "Heya";
            this.BouncingButton.UseVisualStyleBackColor = true;
            this.BouncingButton.MouseEnter += new System.EventHandler(this.BouncingButton_MouseEnter);
            // 
            // SomeRandomApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 303);
            this.Controls.Add(this.MainPanel);
            this.Name = "SomeRandomApp";
            this.Text = "SomeRandomApp";
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BouncingButton;
    }
}

