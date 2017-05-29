namespace CommodityInfoManagement
{
    partial class MainForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.high_weight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.low_weight = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.hign_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.low_price = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.sign_in = new System.Windows.Forms.Button();
            this.myInfo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.putAway = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 23);
            this.textBox1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(227, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "搜索";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "选择商品类别...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 10F);
            this.groupBox1.Location = new System.Drawing.Point(35, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 109);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.high_weight);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.low_weight);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.hign_price);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.low_price);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Font = new System.Drawing.Font("SimSun", 10F);
            this.groupBox2.Location = new System.Drawing.Point(420, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 109);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "筛选";
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(305, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 67);
            this.button6.TabIndex = 13;
            this.button6.Text = "确定";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // high_weight
            // 
            this.high_weight.Location = new System.Drawing.Point(230, 66);
            this.high_weight.Name = "high_weight";
            this.high_weight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.high_weight.Size = new System.Drawing.Size(57, 23);
            this.high_weight.TabIndex = 9;
            this.high_weight.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "——";
            // 
            // low_weight
            // 
            this.low_weight.Location = new System.Drawing.Point(126, 66);
            this.low_weight.Name = "low_weight";
            this.low_weight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.low_weight.Size = new System.Drawing.Size(57, 23);
            this.low_weight.TabIndex = 8;
            this.low_weight.Text = "0";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(20, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 23);
            this.button5.TabIndex = 999;
            this.button5.Text = "重量(KG)：";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // hign_price
            // 
            this.hign_price.Location = new System.Drawing.Point(230, 24);
            this.hign_price.Name = "hign_price";
            this.hign_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hign_price.Size = new System.Drawing.Size(57, 23);
            this.hign_price.TabIndex = 7;
            this.hign_price.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "——";
            // 
            // low_price
            // 
            this.low_price.Location = new System.Drawing.Point(126, 24);
            this.low_price.Name = "low_price";
            this.low_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.low_price.Size = new System.Drawing.Size(57, 23);
            this.low_price.TabIndex = 6;
            this.low_price.Text = "0";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(20, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 23);
            this.button4.TabIndex = 999;
            this.button4.Text = "价格(￥)：";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("SimSun", 10F);
            this.groupBox3.Location = new System.Drawing.Point(35, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(748, 395);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "搜索结果";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(736, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("SimSun", 10F);
            this.button7.Location = new System.Drawing.Point(590, 591);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 24);
            this.button7.TabIndex = 9;
            this.button7.Text = "下架";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("SimSun", 10F);
            this.button8.Location = new System.Drawing.Point(700, 591);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "修改";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // sign_in
            // 
            this.sign_in.Font = new System.Drawing.Font("SimSun", 10F);
            this.sign_in.Location = new System.Drawing.Point(700, 12);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(76, 27);
            this.sign_in.TabIndex = 11;
            this.sign_in.Text = "切换用户";
            this.sign_in.UseVisualStyleBackColor = true;
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // myInfo
            // 
            this.myInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myInfo.Font = new System.Drawing.Font("SimSun", 10F);
            this.myInfo.Location = new System.Drawing.Point(590, 11);
            this.myInfo.Name = "myInfo";
            this.myInfo.Size = new System.Drawing.Size(84, 28);
            this.myInfo.TabIndex = 0;
            this.myInfo.Text = "个人信息";
            this.myInfo.UseVisualStyleBackColor = true;
            this.myInfo.Click += new System.EventHandler(this.myInfo_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("SimSun", 10F);
            this.button2.Location = new System.Drawing.Point(35, 590);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 24);
            this.button2.TabIndex = 12;
            this.button2.Text = "查看详情";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // putAway
            // 
            this.putAway.Font = new System.Drawing.Font("SimSun", 10F);
            this.putAway.Location = new System.Drawing.Point(481, 591);
            this.putAway.Name = "putAway";
            this.putAway.Size = new System.Drawing.Size(71, 24);
            this.putAway.TabIndex = 13;
            this.putAway.Text = "上架";
            this.putAway.UseVisualStyleBackColor = true;
            this.putAway.Click += new System.EventHandler(this.putAway_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("SimSun", 10F);
            this.button11.Location = new System.Drawing.Point(162, 590);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(84, 24);
            this.button11.TabIndex = 12;
            this.button11.Text = "购买";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button10.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button10.Font = new System.Drawing.Font("SimSun", 10F);
            this.button10.Location = new System.Drawing.Point(41, 11);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 28);
            this.button10.TabIndex = 0;
            this.button10.Text = "用户管理";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(824, 627);
            this.Controls.Add(this.putAway);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sign_in);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.myInfo);
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "MainForm";
            this.Text = "SHOP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox high_weight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox low_weight;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox hign_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox low_price;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button sign_in;
        public System.Windows.Forms.Button myInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button putAway;
        private System.Windows.Forms.Button button11;
        public System.Windows.Forms.Button button10;
    }
}

