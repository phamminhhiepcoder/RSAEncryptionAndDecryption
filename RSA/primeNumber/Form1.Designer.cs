namespace primeNumber
{
    partial class Form1
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
            this.btnTaoKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPNumber = new System.Windows.Forms.NumericUpDown();
            this.nudQNumber = new System.Windows.Forms.NumericUpDown();
            this.txtENumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhiNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.txtVanBanMaHoa = new System.Windows.Forms.TextBox();
            this.txtVanBanGiaiMa = new System.Windows.Forms.TextBox();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVanBanGoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbNhap = new System.Windows.Forms.GroupBox();
            this.grbXuLy = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQNumber)).BeginInit();
            this.grbXuLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTaoKey
            // 
            this.btnTaoKey.Location = new System.Drawing.Point(420, 49);
            this.btnTaoKey.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaoKey.Name = "btnTaoKey";
            this.btnTaoKey.Size = new System.Drawing.Size(103, 41);
            this.btnTaoKey.TabIndex = 4;
            this.btnTaoKey.Text = "Tính";
            this.btnTaoKey.UseVisualStyleBackColor = true;
            this.btnTaoKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn p:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn q:";
            // 
            // nudPNumber
            // 
            this.nudPNumber.Location = new System.Drawing.Point(299, 40);
            this.nudPNumber.Margin = new System.Windows.Forms.Padding(2);
            this.nudPNumber.Name = "nudPNumber";
            this.nudPNumber.Size = new System.Drawing.Size(90, 20);
            this.nudPNumber.TabIndex = 8;
            // 
            // nudQNumber
            // 
            this.nudQNumber.Location = new System.Drawing.Point(299, 85);
            this.nudQNumber.Margin = new System.Windows.Forms.Padding(2);
            this.nudQNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQNumber.Name = "nudQNumber";
            this.nudQNumber.Size = new System.Drawing.Size(90, 20);
            this.nudQNumber.TabIndex = 8;
            // 
            // txtENumber
            // 
            this.txtENumber.Location = new System.Drawing.Point(75, 135);
            this.txtENumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtENumber.Name = "txtENumber";
            this.txtENumber.ReadOnly = true;
            this.txtENumber.Size = new System.Drawing.Size(76, 20);
            this.txtENumber.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "e number";
            // 
            // txtNNumber
            // 
            this.txtNNumber.Location = new System.Drawing.Point(249, 135);
            this.txtNNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtNNumber.Name = "txtNNumber";
            this.txtNNumber.ReadOnly = true;
            this.txtNNumber.Size = new System.Drawing.Size(76, 20);
            this.txtNNumber.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "N number";
            // 
            // txtPhiNumber
            // 
            this.txtPhiNumber.Location = new System.Drawing.Point(458, 135);
            this.txtPhiNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhiNumber.Name = "txtPhiNumber";
            this.txtPhiNumber.ReadOnly = true;
            this.txtPhiNumber.Size = new System.Drawing.Size(76, 20);
            this.txtPhiNumber.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Φ number";
            // 
            // txtDNumber
            // 
            this.txtDNumber.Location = new System.Drawing.Point(648, 136);
            this.txtDNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtDNumber.Name = "txtDNumber";
            this.txtDNumber.ReadOnly = true;
            this.txtDNumber.Size = new System.Drawing.Size(76, 20);
            this.txtDNumber.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "d number";
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encrypt.Location = new System.Drawing.Point(52, 18);
            this.btn_encrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(119, 32);
            this.btn_encrypt.TabIndex = 11;
            this.btn_encrypt.Text = "Mã hoá";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // txtVanBanMaHoa
            // 
            this.txtVanBanMaHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVanBanMaHoa.Location = new System.Drawing.Point(66, 322);
            this.txtVanBanMaHoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtVanBanMaHoa.Multiline = true;
            this.txtVanBanMaHoa.Name = "txtVanBanMaHoa";
            this.txtVanBanMaHoa.Size = new System.Drawing.Size(249, 131);
            this.txtVanBanMaHoa.TabIndex = 12;
            // 
            // txtVanBanGiaiMa
            // 
            this.txtVanBanGiaiMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVanBanGiaiMa.Location = new System.Drawing.Point(328, 322);
            this.txtVanBanGiaiMa.Margin = new System.Windows.Forms.Padding(2);
            this.txtVanBanGiaiMa.Multiline = true;
            this.txtVanBanGiaiMa.Name = "txtVanBanGiaiMa";
            this.txtVanBanGiaiMa.Size = new System.Drawing.Size(249, 131);
            this.txtVanBanGiaiMa.TabIndex = 13;
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decrypt.Location = new System.Drawing.Point(314, 18);
            this.btn_decrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(119, 32);
            this.btn_decrypt.TabIndex = 11;
            this.btn_decrypt.Text = "Giải mã";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 176);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 14;
            // 
            // txtVanBanGoc
            // 
            this.txtVanBanGoc.Location = new System.Drawing.Point(115, 202);
            this.txtVanBanGoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtVanBanGoc.Name = "txtVanBanGoc";
            this.txtVanBanGoc.Size = new System.Drawing.Size(518, 20);
            this.txtVanBanGoc.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 205);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Đoạn văn bản:";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(599, 344);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 32);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(599, 396);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 32);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbNhap
            // 
            this.grbNhap.Location = new System.Drawing.Point(14, 12);
            this.grbNhap.Name = "grbNhap";
            this.grbNhap.Size = new System.Drawing.Size(732, 247);
            this.grbNhap.TabIndex = 21;
            this.grbNhap.TabStop = false;
            this.grbNhap.Text = "Nhập số:";
            this.grbNhap.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grbXuLy
            // 
            this.grbXuLy.Controls.Add(this.btn_encrypt);
            this.grbXuLy.Controls.Add(this.btn_decrypt);
            this.grbXuLy.Location = new System.Drawing.Point(14, 265);
            this.grbXuLy.Name = "grbXuLy";
            this.grbXuLy.Size = new System.Drawing.Size(732, 228);
            this.grbXuLy.TabIndex = 22;
            this.grbXuLy.TabStop = false;
            this.grbXuLy.Text = "Giải mã và mã hoá:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 499);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtVanBanGoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVanBanGiaiMa);
            this.Controls.Add(this.txtVanBanMaHoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDNumber);
            this.Controls.Add(this.txtPhiNumber);
            this.Controls.Add(this.txtNNumber);
            this.Controls.Add(this.txtENumber);
            this.Controls.Add(this.nudQNumber);
            this.Controls.Add(this.nudPNumber);
            this.Controls.Add(this.btnTaoKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbNhap);
            this.Controls.Add(this.grbXuLy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình giải mã và hoá hoá RSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQNumber)).EndInit();
            this.grbXuLy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTaoKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPNumber;
        private System.Windows.Forms.NumericUpDown nudQNumber;
        private System.Windows.Forms.TextBox txtENumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhiNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.TextBox txtVanBanMaHoa;
        private System.Windows.Forms.TextBox txtVanBanGiaiMa;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVanBanGoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbNhap;
        private System.Windows.Forms.GroupBox grbXuLy;
    }
}

