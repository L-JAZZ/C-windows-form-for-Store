namespace Final
{
    partial class Login
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.link_register = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(64, 132);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(248, 22);
            this.txt_id.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(64, 208);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(248, 22);
            this.txt_password.TabIndex = 1;
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(146, 277);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 23);
            this.btn_enter.TabIndex = 2;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(149, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log in";
            // 
            // link_register
            // 
            this.link_register.AutoSize = true;
            this.link_register.Location = new System.Drawing.Point(133, 342);
            this.link_register.Name = "link_register";
            this.link_register.Size = new System.Drawing.Size(95, 17);
            this.link_register.TabIndex = 4;
            this.link_register.TabStop = true;
            this.link_register.Text = "Go to register";
            this.link_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_register_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 424);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.link_register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_id);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_register;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

