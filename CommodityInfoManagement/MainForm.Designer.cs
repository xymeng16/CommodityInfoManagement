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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comm_search_text = new System.Windows.Forms.TextBox();
            this.comm_search = new System.Windows.Forms.Button();
            this.comm_search_category = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filter = new System.Windows.Forms.Button();
            this.high_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.low_amount = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.high_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.low_price = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.search_result = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.sign_in = new System.Windows.Forms.Button();
            this.myInfo = new System.Windows.Forms.Button();
            this.detail = new System.Windows.Forms.Button();
            this.putAway = new System.Windows.Forms.Button();
            this.buy_comm = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_result)).BeginInit();
            this.SuspendLayout();
            // 
            // comm_search_text
            // 
            this.comm_search_text.Location = new System.Drawing.Point(25, 22);
            this.comm_search_text.Name = "comm_search_text";
            this.comm_search_text.Size = new System.Drawing.Size(173, 23);
            this.comm_search_text.TabIndex = 0;
            // 
            // comm_search
            // 
            this.comm_search.Location = new System.Drawing.Point(227, 22);
            this.comm_search.Name = "comm_search";
            this.comm_search.Size = new System.Drawing.Size(75, 23);
            this.comm_search.TabIndex = 2;
            this.comm_search.Text = "搜索";
            this.comm_search.UseVisualStyleBackColor = true;
            this.comm_search.Click += new System.EventHandler(this.comm_search_Click);
            // 
            // comm_search_category
            // 
            this.comm_search_category.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comm_search_category.FormattingEnabled = true;
            this.comm_search_category.Location = new System.Drawing.Point(25, 68);
            this.comm_search_category.Name = "comm_search_category";
            this.comm_search_category.Size = new System.Drawing.Size(121, 21);
            this.comm_search_category.TabIndex = 1;
            this.comm_search_category.Text = "选择商品类别...";
            this.comm_search_category.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comm_search_category);
            this.groupBox1.Controls.Add(this.comm_search);
            this.groupBox1.Controls.Add(this.comm_search_text);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox1.Location = new System.Drawing.Point(35, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filter);
            this.groupBox2.Controls.Add(this.high_amount);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.low_amount);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.high_price);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.low_price);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox2.Location = new System.Drawing.Point(420, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "筛选";
            // 
            // filter
            // 
            this.filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filter.Location = new System.Drawing.Point(305, 22);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(52, 67);
            this.filter.TabIndex = 13;
            this.filter.Text = "确定";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click_1);
            // 
            // high_amount
            // 
            this.high_amount.Location = new System.Drawing.Point(230, 66);
            this.high_amount.Name = "high_amount";
            this.high_amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.high_amount.Size = new System.Drawing.Size(57, 23);
            this.high_amount.TabIndex = 3;
            this.high_amount.Text = "0";
            this.high_amount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.high_amount_MouseClick);
            this.high_amount.Leave += new System.EventHandler(this.high_amount_Leave);
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
            // low_amount
            // 
            this.low_amount.Location = new System.Drawing.Point(126, 66);
            this.low_amount.Name = "low_amount";
            this.low_amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.low_amount.Size = new System.Drawing.Size(57, 23);
            this.low_amount.TabIndex = 2;
            this.low_amount.Text = "0";
            this.low_amount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.low_amount_MouseClick);
            this.low_amount.Leave += new System.EventHandler(this.low_amount_Leave);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(20, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 23);
            this.button5.TabIndex = 999;
            this.button5.Text = "库存：";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // high_price
            // 
            this.high_price.Location = new System.Drawing.Point(230, 24);
            this.high_price.Name = "high_price";
            this.high_price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.high_price.Size = new System.Drawing.Size(57, 23);
            this.high_price.TabIndex = 1;
            this.high_price.Text = "0";
            this.high_price.MouseClick += new System.Windows.Forms.MouseEventHandler(this.high_price_MouseClick);
            this.high_price.Leave += new System.EventHandler(this.high_price_Leave);
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
            this.low_price.Size = new System.Drawing.Size(57, 23);
            this.low_price.TabIndex = 0;
            this.low_price.Text = "0";
            this.low_price.MouseClick += new System.Windows.Forms.MouseEventHandler(this.low_price_MouseClick);
            this.low_price.Leave += new System.EventHandler(this.low_price_Leave);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(20, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 23);
            this.button4.TabIndex = 999;
            this.button4.Text = "价格：";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.search_result);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox3.Location = new System.Drawing.Point(35, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(748, 395);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "搜索结果";
            // 
            // search_result
            // 
            this.search_result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.search_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.search_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.search_result.DefaultCellStyle = dataGridViewCellStyle12;
            this.search_result.Location = new System.Drawing.Point(6, 22);
            this.search_result.Name = "search_result";
            this.search_result.RowTemplate.Height = 23;
            this.search_result.Size = new System.Drawing.Size(736, 364);
            this.search_result.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("宋体", 10F);
            this.button7.Location = new System.Drawing.Point(590, 591);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 24);
            this.button7.TabIndex = 9;
            this.button7.Text = "下架";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("宋体", 10F);
            this.button8.Location = new System.Drawing.Point(700, 591);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "修改";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // sign_in
            // 
            this.sign_in.Font = new System.Drawing.Font("宋体", 10F);
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
            this.myInfo.Font = new System.Drawing.Font("宋体", 10F);
            this.myInfo.Location = new System.Drawing.Point(590, 11);
            this.myInfo.Name = "myInfo";
            this.myInfo.Size = new System.Drawing.Size(84, 28);
            this.myInfo.TabIndex = 3;
            this.myInfo.Text = "个人信息";
            this.myInfo.UseVisualStyleBackColor = true;
            this.myInfo.Click += new System.EventHandler(this.myInfo_Click);
            // 
            // detail
            // 
            this.detail.Font = new System.Drawing.Font("宋体", 10F);
            this.detail.Location = new System.Drawing.Point(35, 590);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(84, 24);
            this.detail.TabIndex = 12;
            this.detail.Text = "查看详情";
            this.detail.UseVisualStyleBackColor = true;
            this.detail.Click += new System.EventHandler(this.detail_Click);
            // 
            // putAway
            // 
            this.putAway.Font = new System.Drawing.Font("宋体", 10F);
            this.putAway.Location = new System.Drawing.Point(481, 591);
            this.putAway.Name = "putAway";
            this.putAway.Size = new System.Drawing.Size(71, 24);
            this.putAway.TabIndex = 13;
            this.putAway.Text = "上架";
            this.putAway.UseVisualStyleBackColor = true;
            this.putAway.Click += new System.EventHandler(this.putAway_Click);
            // 
            // buy_comm
            // 
            this.buy_comm.Font = new System.Drawing.Font("宋体", 10F);
            this.buy_comm.Location = new System.Drawing.Point(162, 590);
            this.buy_comm.Name = "buy_comm";
            this.buy_comm.Size = new System.Drawing.Size(84, 24);
            this.buy_comm.TabIndex = 12;
            this.buy_comm.Text = "购买";
            this.buy_comm.UseVisualStyleBackColor = true;
            this.buy_comm.Click += new System.EventHandler(this.buy_comm_Click);
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button10.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button10.Font = new System.Drawing.Font("宋体", 10F);
            this.button10.Location = new System.Drawing.Point(41, 11);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 28);
            this.button10.TabIndex = 2;
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
            this.Controls.Add(this.buy_comm);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.sign_in);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.myInfo);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.search_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox comm_search_text;
        private System.Windows.Forms.Button comm_search;
        private System.Windows.Forms.ComboBox comm_search_category;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.TextBox high_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox low_amount;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox high_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox low_price;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView search_result;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button sign_in;
        public System.Windows.Forms.Button myInfo;
        private System.Windows.Forms.Button detail;
        private System.Windows.Forms.Button putAway;
        private System.Windows.Forms.Button buy_comm;
        public System.Windows.Forms.Button button10;
    }
}

