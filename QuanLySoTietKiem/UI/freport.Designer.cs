
namespace QuanLySoTietKiem
{
    partial class freport
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.BCnbutton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataDay = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BCTbutton2 = new System.Windows.Forms.Button();
            this.BCTbutton1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBCT_Nam = new System.Windows.Forms.TextBox();
            this.tbBCT_Thang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataMonth = new System.Windows.Forms.DataGridView();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.cbLoaiSo = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDay)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-4, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::QuanLySoTietKiem.Properties.Resources.hinh_nen_may_tinh_don_gian;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.dateTime);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.BCnbutton2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataDay);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NGÀY";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(645, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BCnbutton2
            // 
            this.BCnbutton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BCnbutton2.Location = new System.Drawing.Point(441, 73);
            this.BCnbutton2.Name = "BCnbutton2";
            this.BCnbutton2.Size = new System.Drawing.Size(122, 33);
            this.BCnbutton2.TabIndex = 3;
            this.BCnbutton2.Text = "Kiểm Tra";
            this.BCnbutton2.UseVisualStyleBackColor = true;
            this.BCnbutton2.Click += new System.EventHandler(this.freport_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày: ";
            // 
            // dataDay
            // 
            this.dataDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDay.Location = new System.Drawing.Point(0, 121);
            this.dataDay.Name = "dataDay";
            this.dataDay.RowHeadersWidth = 51;
            this.dataDay.RowTemplate.Height = 24;
            this.dataDay.Size = new System.Drawing.Size(801, 299);
            this.dataDay.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::QuanLySoTietKiem.Properties.Resources.hinh_nen_may_tinh_don_gian;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.cbLoaiSo);
            this.tabPage2.Controls.Add(this.BCTbutton2);
            this.tabPage2.Controls.Add(this.BCTbutton1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbBCT_Nam);
            this.tabPage2.Controls.Add(this.tbBCT_Thang);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataMonth);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(801, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "THÁNG";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BCTbutton2
            // 
            this.BCTbutton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCTbutton2.Location = new System.Drawing.Point(666, 96);
            this.BCTbutton2.Name = "BCTbutton2";
            this.BCTbutton2.Size = new System.Drawing.Size(122, 33);
            this.BCTbutton2.TabIndex = 9;
            this.BCTbutton2.Text = "Thoát";
            this.BCTbutton2.UseVisualStyleBackColor = true;
            this.BCTbutton2.Click += new System.EventHandler(this.BCTbutton2_Click);
            // 
            // BCTbutton1
            // 
            this.BCTbutton1.Location = new System.Drawing.Point(490, 96);
            this.BCTbutton1.Name = "BCTbutton1";
            this.BCTbutton1.Size = new System.Drawing.Size(122, 33);
            this.BCTbutton1.TabIndex = 8;
            this.BCTbutton1.Text = "Kiểm Tra";
            this.BCTbutton1.UseVisualStyleBackColor = true;
            this.BCTbutton1.Click += new System.EventHandler(this.freport_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại Sổ: ";
            // 
            // tbBCT_Nam
            // 
            this.tbBCT_Nam.Location = new System.Drawing.Point(446, 26);
            this.tbBCT_Nam.Name = "tbBCT_Nam";
            this.tbBCT_Nam.Size = new System.Drawing.Size(92, 30);
            this.tbBCT_Nam.TabIndex = 5;
            // 
            // tbBCT_Thang
            // 
            this.tbBCT_Thang.Location = new System.Drawing.Point(124, 26);
            this.tbBCT_Thang.Name = "tbBCT_Thang";
            this.tbBCT_Thang.Size = new System.Drawing.Size(92, 30);
            this.tbBCT_Thang.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tháng: ";
            // 
            // dataMonth
            // 
            this.dataMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMonth.Location = new System.Drawing.Point(0, 153);
            this.dataMonth.Name = "dataMonth";
            this.dataMonth.RowHeadersWidth = 51;
            this.dataMonth.RowTemplate.Height = 24;
            this.dataMonth.Size = new System.Drawing.Size(801, 264);
            this.dataMonth.TabIndex = 0;
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "\"dd/MM/yyyy\"";
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(131, 50);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 30);
            this.dateTime.TabIndex = 11;
            this.dateTime.ValueChanged += new System.EventHandler(this.freport_Load);
            // 
            // cbLoaiSo
            // 
            this.cbLoaiSo.FormattingEnabled = true;
            this.cbLoaiSo.Items.AddRange(new object[] {
            "Kì hạn 3 tháng",
            "Kì hạn 6 tháng",
            "Không kỳ hạn"});
            this.cbLoaiSo.Location = new System.Drawing.Point(124, 89);
            this.cbLoaiSo.Name = "cbLoaiSo";
            this.cbLoaiSo.Size = new System.Drawing.Size(236, 30);
            this.cbLoaiSo.TabIndex = 23;
            // 
            // freport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySoTietKiem.Properties.Resources.hinh_nen_may_tinh_don_gian;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "freport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "freport";
            this.Load += new System.EventHandler(this.freport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDay)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataDay;
        private System.Windows.Forms.Button BCnbutton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BCTbutton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBCT_Nam;
        private System.Windows.Forms.TextBox tbBCT_Thang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataMonth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BCTbutton2;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.ComboBox cbLoaiSo;
    }
}