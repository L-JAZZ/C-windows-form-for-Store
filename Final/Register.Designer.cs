namespace Final
{
    partial class Register
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.link_login = new System.Windows.Forms.LinkLabel();
            this.btn_enter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_confirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(99, 216);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(248, 22);
            this.txt_password.TabIndex = 8;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(99, 152);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(248, 22);
            this.txt_id.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(177, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Register";
            // 
            // link_login
            // 
            this.link_login.AutoSize = true;
            this.link_login.Location = new System.Drawing.Point(180, 399);
            this.link_login.Name = "link_login";
            this.link_login.Size = new System.Drawing.Size(77, 17);
            this.link_login.TabIndex = 13;
            this.link_login.TabStop = true;
            this.link_login.Text = "Go to login";
            this.link_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_login_LinkClicked);
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(182, 335);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 23);
            this.btn_enter.TabIndex = 12;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Confirm password:";
            // 
            // txt_confirm
            // 
            this.txt_confirm.Location = new System.Drawing.Point(99, 282);
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.Size = new System.Drawing.Size(248, 22);
            this.txt_confirm.TabIndex = 14;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 460);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_confirm);
            this.Controls.Add(this.link_login);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_id);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_login;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_confirm;
    }
}