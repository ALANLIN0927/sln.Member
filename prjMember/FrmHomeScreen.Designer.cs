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
            this.comchoice = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labregister = new System.Windows.Forms.Label();
            this.labNotice = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labshop = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comchoice);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labregister);
            this.panel1.Controls.Add(this.labNotice);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labshop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 76);
            this.panel1.TabIndex = 0;
            // 
            // comchoice
            // 
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
            this.comchoice.Location = new System.Drawing.Point(984, 29);
            this.comchoice.Name = "comchoice";
            this.comchoice.Size = new System.Drawing.Size(121, 32);
            this.comchoice.TabIndex = 9;
            this.comchoice.Text = "會員中心";
            this.comchoice.DropDown += new System.EventHandler(this.comchoice_DropDown);
            this.comchoice.SelectedIndexChanged += new System.EventHandler(this.comchoice_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(903, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 44);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labregister
            // 
            this.labregister.AutoSize = true;
            this.labregister.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labregister.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labregister.Location = new System.Drawing.Point(835, 29);
            this.labregister.Name = "labregister";
            this.labregister.Size = new System.Drawing.Size(48, 24);
            this.labregister.TabIndex = 7;
            this.labregister.Text = "登入";
            this.labregister.Click += new System.EventHandler(this.register_Click);
            this.labregister.MouseEnter += new System.EventHandler(this.labregister_MouseEnter);
            this.labregister.MouseLeave += new System.EventHandler(this.labregister_MouseLeave);
            this.labregister.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labregister_MouseMove);
            // 
            // labNotice
            // 
            this.labNotice.AutoSize = true;
            this.labNotice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNotice.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labNotice.Location = new System.Drawing.Point(771, 29);
            this.labNotice.Name = "labNotice";
            this.labNotice.Size = new System.Drawing.Size(48, 24);
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
            this.comboBox1.Location = new System.Drawing.Point(292, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(544, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 47);
            this.label4.TabIndex = 4;
            this.label4.Text = "你訂";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(204, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "兌換專區";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(148, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "訂單";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(76, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "購物車";
            // 
            // labshop
            // 
            this.labshop.AutoSize = true;
            this.labshop.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labshop.Location = new System.Drawing.Point(20, 27);
            this.labshop.Name = "labshop";
            this.labshop.Size = new System.Drawing.Size(42, 21);
            this.labshop.TabIndex = 0;
            this.labshop.Text = "訂購";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1175, 730);
            this.panel2.TabIndex = 1;
            // 
            // FrmHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 806);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHomeScreen";
            this.Text = "FrmHomeScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labshop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labregister;
        private System.Windows.Forms.Label labNotice;
        private System.Windows.Forms.ComboBox comchoice;
    }
}