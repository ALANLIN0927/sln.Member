namespace prjMember
{
    partial class FrmHomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomeScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.membername = new System.Windows.Forms.Label();
            this.comchoice = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labregister = new System.Windows.Forms.Label();
            this.labNotice = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.laborder = new System.Windows.Forms.Label();
            this.labshopcar = new System.Windows.Forms.Label();
            this.labshop = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.membername);
            this.panel1.Controls.Add(this.comchoice);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labregister);
            this.panel1.Controls.Add(this.labNotice);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.laborder);
            this.panel1.Controls.Add(this.labshopcar);
            this.panel1.Controls.Add(this.labshop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 76);
            this.panel1.TabIndex = 0;
            // 
            // membername
            // 
            this.membername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.membername.AutoSize = true;
            this.membername.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.membername.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.membername.Location = new System.Drawing.Point(850, 22);
            this.membername.Name = "membername";
            this.membername.Size = new System.Drawing.Size(62, 31);
            this.membername.TabIndex = 10;
            this.membername.Text = "會員";
            // 
            // comchoice
            // 
            this.comchoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comchoice.AutoCompleteCustomSource.AddRange(new string[] {
            "品牌專區",
            "相關條款",
            "意見回饋",
            "官方客服",
            "新手教學"});
            this.comchoice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comchoice.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comchoice.FormattingEnabled = true;
            this.comchoice.Items.AddRange(new object[] {
            "會員資料",
            "修改會員資料",
            ""});
            this.comchoice.Location = new System.Drawing.Point(1030, 24);
            this.comchoice.Name = "comchoice";
            this.comchoice.Size = new System.Drawing.Size(121, 32);
            this.comchoice.TabIndex = 9;
            this.comchoice.Text = "會員中心";
            this.comchoice.DropDown += new System.EventHandler(this.comchoice_DropDown);
            this.comchoice.SelectedIndexChanged += new System.EventHandler(this.comchoice_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(940, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 44);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labregister
            // 
            this.labregister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labregister.AutoSize = true;
            this.labregister.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labregister.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labregister.Location = new System.Drawing.Point(770, 22);
            this.labregister.Name = "labregister";
            this.labregister.Size = new System.Drawing.Size(62, 31);
            this.labregister.TabIndex = 7;
            this.labregister.Text = "登入";
            this.labregister.Click += new System.EventHandler(this.register_Click);
            this.labregister.MouseEnter += new System.EventHandler(this.labregister_MouseEnter);
            this.labregister.MouseLeave += new System.EventHandler(this.labregister_MouseLeave);
            // 
            // labNotice
            // 
            this.labNotice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labNotice.AutoSize = true;
            this.labNotice.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNotice.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labNotice.Location = new System.Drawing.Point(686, 22);
            this.labNotice.Name = "labNotice";
            this.labNotice.Size = new System.Drawing.Size(62, 31);
            this.labNotice.TabIndex = 6;
            this.labNotice.Text = "通知";
            this.labNotice.MouseEnter += new System.EventHandler(this.Notice_MouseEnter);
            this.labNotice.MouseLeave += new System.EventHandler(this.labNotice_MouseLeave);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "品牌專區",
            "相關條款",
            "意見回饋",
            "官方客服",
            "新手教學"});
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "品牌專區",
            "相關條款",
            "意見回饋",
            "官方客服",
            "新手教學"});
            this.comboBox1.Location = new System.Drawing.Point(306, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(545, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 61);
            this.label4.TabIndex = 4;
            this.label4.Text = "你訂";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(204, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "兌換專區";
            // 
            // laborder
            // 
            this.laborder.AutoSize = true;
            this.laborder.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.laborder.Location = new System.Drawing.Point(148, 27);
            this.laborder.Name = "laborder";
            this.laborder.Size = new System.Drawing.Size(54, 26);
            this.laborder.TabIndex = 2;
            this.laborder.Text = "訂單";
            this.laborder.Click += new System.EventHandler(this.laborder_Click);
            this.laborder.MouseEnter += new System.EventHandler(this.laborder_MouseEnter);
            this.laborder.MouseLeave += new System.EventHandler(this.laborder_MouseLeave);
            // 
            // labshopcar
            // 
            this.labshopcar.AutoSize = true;
            this.labshopcar.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labshopcar.Location = new System.Drawing.Point(76, 27);
            this.labshopcar.Name = "labshopcar";
            this.labshopcar.Size = new System.Drawing.Size(75, 26);
            this.labshopcar.TabIndex = 1;
            this.labshopcar.Text = "購物車";
            this.labshopcar.Click += new System.EventHandler(this.labshopcar_Click);
            this.labshopcar.MouseEnter += new System.EventHandler(this.labshopcar_MouseEnter);
            this.labshopcar.MouseLeave += new System.EventHandler(this.labshopcar_MouseLeave);
            // 
            // labshop
            // 
            this.labshop.AutoSize = true;
            this.labshop.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labshop.Location = new System.Drawing.Point(20, 27);
            this.labshop.Name = "labshop";
            this.labshop.Size = new System.Drawing.Size(54, 26);
            this.labshop.TabIndex = 0;
            this.labshop.Text = "訂購";
            this.labshop.Click += new System.EventHandler(this.labshop_Click);
            this.labshop.MouseEnter += new System.EventHandler(this.labshop_MouseEnter);
            this.labshop.MouseLeave += new System.EventHandler(this.labshop_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 713);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1175, 93);
            this.panel3.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(876, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 24);
            this.label12.TabIndex = 7;
            this.label12.Text = "官方客服";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(876, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 24);
            this.label11.TabIndex = 6;
            this.label11.Text = "意見回饋";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(981, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "隱私權條款";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(981, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "使用者條款";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(21, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "@2022 Nidin台灣";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(47, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "你訂";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 76);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1175, 637);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // FrmHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 806);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHomeScreen";
            this.Text = "FrmHomeScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHomeScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laborder;
        private System.Windows.Forms.Label labshopcar;
        private System.Windows.Forms.Label labshop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labregister;
        private System.Windows.Forms.Label labNotice;
        private System.Windows.Forms.ComboBox comchoice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label membername;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}