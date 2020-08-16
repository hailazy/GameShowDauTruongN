namespace GAME_SHOW.Forms.PLAYER
{
    partial class frmPlayerHome
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMCId = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDsSV = new System.Windows.Forms.Button();
            this.btnThemTKSV = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(330, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Đấu trường N+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.btnSignOut);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 278);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblMCId);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Location = new System.Drawing.Point(6, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 213);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên:";
            // 
            // lblMCId
            // 
            this.lblMCId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMCId.ForeColor = System.Drawing.Color.Red;
            this.lblMCId.Location = new System.Drawing.Point(0, 144);
            this.lblMCId.Name = "lblMCId";
            this.lblMCId.Size = new System.Drawing.Size(181, 20);
            this.lblMCId.TabIndex = 3;
            this.lblMCId.Text = "Id";
            this.lblMCId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblFullName.ForeColor = System.Drawing.Color.Red;
            this.lblFullName.Location = new System.Drawing.Point(0, 185);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(181, 20);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Lớn Văn Lên";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Honeydew;
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSignOut.Location = new System.Drawing.Point(6, 228);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(181, 37);
            this.btnSignOut.TabIndex = 3;
            this.btnSignOut.Text = "Đăng Xuất";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnDsSV);
            this.groupBox1.Controls.Add(this.btnThemTKSV);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(223, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 185);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng chơi";
            // 
            // btnDsSV
            // 
            this.btnDsSV.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDsSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDsSV.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDsSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDsSV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDsSV.Location = new System.Drawing.Point(173, 30);
            this.btnDsSV.Name = "btnDsSV";
            this.btnDsSV.Size = new System.Drawing.Size(149, 50);
            this.btnDsSV.TabIndex = 1;
            this.btnDsSV.Text = "Thông tin phòng";
            this.btnDsSV.UseVisualStyleBackColor = false;
            // 
            // btnThemTKSV
            // 
            this.btnThemTKSV.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThemTKSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemTKSV.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnThemTKSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTKSV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemTKSV.Location = new System.Drawing.Point(18, 30);
            this.btnThemTKSV.Name = "btnThemTKSV";
            this.btnThemTKSV.Size = new System.Drawing.Size(149, 50);
            this.btnThemTKSV.TabIndex = 0;
            this.btnThemTKSV.Text = "Tìm phòng";
            this.btnThemTKSV.UseVisualStyleBackColor = false;
            this.btnThemTKSV.Click += new System.EventHandler(this.btnThemTKSV_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::GAME_SHOW.Properties.Resources._3303391_200;
            this.pictureBox2.Location = new System.Drawing.Point(46, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // frmPlayerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPlayerHome";
            this.Text = "frmPlayerHome";
            this.Load += new System.EventHandler(this.frmPlayerHome_Load);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMCId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDsSV;
        private System.Windows.Forms.Button btnThemTKSV;
    }
}