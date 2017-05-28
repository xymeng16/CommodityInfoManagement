namespace CommodityInfoManagement
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_signin = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.button_signup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_signin);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.button_signup);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 10F);
            this.groupBox1.Location = new System.Drawing.Point(27, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录";
            // 
            // button_signin
            // 
            this.button_signin.Location = new System.Drawing.Point(196, 120);
            this.button_signin.Name = "button_signin";
            this.button_signin.Size = new System.Drawing.Size(71, 28);
            this.button_signin.TabIndex = 4;
            this.button_signin.Text = "登陆";
            this.button_signin.UseVisualStyleBackColor = true;
            this.button_signin.Click += new System.EventHandler(this.button_signin_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(136, 75);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(152, 23);
            this.password.TabIndex = 3;
            // 
            // button_signup
            // 
            this.button_signup.Location = new System.Drawing.Point(79, 120);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(71, 28);
            this.button_signup.TabIndex = 9;
            this.button_signup.Text = "注册";
            this.button_signup.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F);
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(136, 43);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(152, 23);
            this.username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F);
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 251);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_signin;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_signup;
    }
}