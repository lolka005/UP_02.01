namespace ЛР5
{
    partial class MainMenu
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
            this.subBtn = new System.Windows.Forms.Button();
            this.authBtn = new System.Windows.Forms.Button();
            this.pubBtn = new System.Windows.Forms.Button();
            this.recBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subBtn
            // 
            this.subBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.subBtn.Location = new System.Drawing.Point(81, 39);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(115, 40);
            this.subBtn.TabIndex = 0;
            this.subBtn.Text = "Подписки";
            this.subBtn.UseVisualStyleBackColor = false;
            this.subBtn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // authBtn
            // 
            this.authBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.authBtn.Location = new System.Drawing.Point(81, 85);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(115, 40);
            this.authBtn.TabIndex = 1;
            this.authBtn.Text = "Авторы";
            this.authBtn.UseVisualStyleBackColor = false;
            this.authBtn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // pubBtn
            // 
            this.pubBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pubBtn.Location = new System.Drawing.Point(81, 131);
            this.pubBtn.Name = "pubBtn";
            this.pubBtn.Size = new System.Drawing.Size(115, 40);
            this.pubBtn.TabIndex = 2;
            this.pubBtn.Text = "Издания";
            this.pubBtn.UseVisualStyleBackColor = false;
            this.pubBtn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // recBtn
            // 
            this.recBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.recBtn.Location = new System.Drawing.Point(81, 177);
            this.recBtn.Name = "recBtn";
            this.recBtn.Size = new System.Drawing.Size(115, 40);
            this.recBtn.TabIndex = 3;
            this.recBtn.Text = "Получатели";
            this.recBtn.UseVisualStyleBackColor = false;
            this.recBtn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // logBtn
            // 
            this.logBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.logBtn.Location = new System.Drawing.Point(81, 223);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(115, 40);
            this.logBtn.TabIndex = 4;
            this.logBtn.Text = "Журнал входа";
            this.logBtn.UseVisualStyleBackColor = false;
            this.logBtn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.recBtn);
            this.Controls.Add(this.pubBtn);
            this.Controls.Add(this.authBtn);
            this.Controls.Add(this.subBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.Button pubBtn;
        private System.Windows.Forms.Button recBtn;
        private System.Windows.Forms.Button logBtn;
    }
}