namespace CommodityInfoManagement
{
    partial class buy_num
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
            this.num_remind = new System.Windows.Forms.Label();
            this.buycomm_num = new System.Windows.Forms.TextBox();
            this.num_comfirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num_remind
            // 
            this.num_remind.AutoSize = true;
            this.num_remind.Font = new System.Drawing.Font("宋体", 10F);
            this.num_remind.Location = new System.Drawing.Point(24, 25);
            this.num_remind.Name = "num_remind";
            this.num_remind.Size = new System.Drawing.Size(119, 14);
            this.num_remind.TabIndex = 0;
            this.num_remind.Text = "请输入购买数量：";
            // 
            // buycomm_num
            // 
            this.buycomm_num.Location = new System.Drawing.Point(27, 62);
            this.buycomm_num.Name = "buycomm_num";
            this.buycomm_num.Size = new System.Drawing.Size(243, 21);
            this.buycomm_num.TabIndex = 1;
            this.buycomm_num.Text = "0";
            this.buycomm_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num_comfirm
            // 
            this.num_comfirm.Location = new System.Drawing.Point(54, 104);
            this.num_comfirm.Name = "num_comfirm";
            this.num_comfirm.Size = new System.Drawing.Size(77, 27);
            this.num_comfirm.TabIndex = 2;
            this.num_comfirm.Text = "确定";
            this.num_comfirm.UseVisualStyleBackColor = true;
            this.num_comfirm.Click += new System.EventHandler(this.num_comfirm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buy_num
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 162);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num_comfirm);
            this.Controls.Add(this.buycomm_num);
            this.Controls.Add(this.num_remind);
            this.Name = "buy_num";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "buy_num";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num_remind;
        private System.Windows.Forms.TextBox buycomm_num;
        private System.Windows.Forms.Button num_comfirm;
        private System.Windows.Forms.Button button1;
    }
}