namespace Tests
{
    partial class MainMenu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonTesting = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonLogin);
            this.flowLayoutPanel1.Controls.Add(this.buttonTesting);
            this.flowLayoutPanel1.Controls.Add(this.buttonExit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(288, 212);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(3, 3);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(281, 53);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Зайти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonTesting
            // 
            this.buttonTesting.Location = new System.Drawing.Point(3, 62);
            this.buttonTesting.Name = "buttonTesting";
            this.buttonTesting.Size = new System.Drawing.Size(281, 58);
            this.buttonTesting.TabIndex = 2;
            this.buttonTesting.Text = "Пройти тэст";
            this.buttonTesting.UseVisualStyleBackColor = true;
            this.buttonTesting.Click += new System.EventHandler(this.buttonTesting_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(3, 126);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(80, 58);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 212);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(304, 251);
            this.MinimumSize = new System.Drawing.Size(304, 251);
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonTesting;
        private System.Windows.Forms.Button buttonExit;
    }
}

