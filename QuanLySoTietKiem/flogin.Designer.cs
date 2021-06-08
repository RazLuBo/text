
namespace QuanLySoTietKiem
{
    partial class flogin
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
            this.DangNhap = new System.Windows.Forms.Panel();
            this.DNbutton2 = new System.Windows.Forms.Button();
            this.DNbutton1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DangNhap.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DangNhap
            // 
            this.DangNhap.BackgroundImage = global::QuanLySoTietKiem.Properties.Resources.text;
            this.DangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DangNhap.Controls.Add(this.DNbutton2);
            this.DangNhap.Controls.Add(this.DNbutton1);
            this.DangNhap.Controls.Add(this.panel3);
            this.DangNhap.Controls.Add(this.panel2);
            this.DangNhap.Location = new System.Drawing.Point(-1, 2);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(682, 453);
            this.DangNhap.TabIndex = 0;
            // 
            // DNbutton2
            // 
            this.DNbutton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNbutton2.Location = new System.Drawing.Point(425, 355);
            this.DNbutton2.Name = "DNbutton2";
            this.DNbutton2.Size = new System.Drawing.Size(131, 37);
            this.DNbutton2.TabIndex = 4;
            this.DNbutton2.Text = "Thoát";
            this.DNbutton2.UseVisualStyleBackColor = true;
            this.DNbutton2.Click += new System.EventHandler(this.button3_Click);
            // 
            // DNbutton1
            // 
            this.DNbutton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DNbutton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.DNbutton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DNbutton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNbutton1.Location = new System.Drawing.Point(126, 356);
            this.DNbutton1.Name = "DNbutton1";
            this.DNbutton1.Size = new System.Drawing.Size(131, 37);
            this.DNbutton1.TabIndex = 2;
            this.DNbutton1.Text = "Đăng Nhập";
            this.DNbutton1.UseVisualStyleBackColor = true;
            this.DNbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::QuanLySoTietKiem.Properties.Resources.images__1_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Location = new System.Drawing.Point(78, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 75);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật Khẩu:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::QuanLySoTietKiem.Properties.Resources.images__1_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(78, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 75);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tài Khoản:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 22);
            this.textBox1.TabIndex = 1;
            // 
            // flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySoTietKiem.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 456);
            this.Controls.Add(this.DangNhap);
            this.Name = "flogin";
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.DangNhap.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DangNhap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DNbutton1;
        private System.Windows.Forms.Button DNbutton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

