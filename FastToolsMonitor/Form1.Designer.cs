namespace FastToolsMonitor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.statePic = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.killClose = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.statePic)).BeginInit();
            this.SuspendLayout();
            // 
            // statePic
            // 
            this.statePic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statePic.Image = global::FastToolsMonitor.resources.Sync;
            this.statePic.Location = new System.Drawing.Point(0, 0);
            this.statePic.Name = "statePic";
            this.statePic.Size = new System.Drawing.Size(63, 63);
            this.statePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statePic.TabIndex = 0;
            this.statePic.TabStop = false;
            this.statePic.DoubleClick += new System.EventHandler(this.statePic_DoubleClick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "OPC104 monitor";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // killClose
            // 
            this.killClose.AutoSize = true;
            this.killClose.BackColor = System.Drawing.SystemColors.InfoText;
            this.killClose.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.killClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.1F);
            this.killClose.Location = new System.Drawing.Point(47, 0);
            this.killClose.Name = "killClose";
            this.killClose.Size = new System.Drawing.Size(15, 14);
            this.killClose.TabIndex = 1;
            this.killClose.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(63, 63);
            this.Controls.Add(this.killClose);
            this.Controls.Add(this.statePic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.InfoText;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox statePic;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox killClose;
    }
}

