namespace GAME_SHOW.Forms
{
    partial class frmMCHome
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMCId = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDsCDMo = new System.Windows.Forms.Button();
            this.btnMoCD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDsSV = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(321, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "TRANG QUẢN LÝ ";
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
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 278);
            this.groupBox3.TabIndex = 8;
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
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::GAME_SHOW.Properties.Resources.special_event_expo_09_512;
            this.pictureBox2.Location = new System.Drawing.Point(46, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnDsCDMo);
            this.groupBox2.Controls.Add(this.btnMoCD);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(408, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 185);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Game show";
            // 
            // btnDsCDMo
            // 
            this.btnDsCDMo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDsCDMo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDsCDMo.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDsCDMo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDsCDMo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDsCDMo.Location = new System.Drawing.Point(15, 98);
            this.btnDsCDMo.Name = "btnDsCDMo";
            this.btnDsCDMo.Size = new System.Drawing.Size(166, 50);
            this.btnDsCDMo.TabIndex = 3;
            this.btnDsCDMo.Text = "Danh sách game show của tôi";
            this.btnDsCDMo.UseVisualStyleBackColor = false;
            // 
            // btnMoCD
            // 
            this.btnMoCD.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMoCD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoCD.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnMoCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoCD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMoCD.Location = new System.Drawing.Point(15, 30);
            this.btnMoCD.Name = "btnMoCD";
            this.btnMoCD.Size = new System.Drawing.Size(166, 50);
            this.btnMoCD.TabIndex = 0;
            this.btnMoCD.Text = "Tạo game show";
            this.btnMoCD.UseVisualStyleBackColor = false;
            this.btnMoCD.Click += new System.EventHandler(this.btnMoCD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnDsSV);
            this.groupBox1.Controls.Add(this.btnAddQuestion);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(214, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 185);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Câu hỏi";
            // 
            // btnDsSV
            // 
            this.btnDsSV.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDsSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDsSV.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDsSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDsSV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDsSV.Location = new System.Drawing.Point(18, 98);
            this.btnDsSV.Name = "btnDsSV";
            this.btnDsSV.Size = new System.Drawing.Size(149, 50);
            this.btnDsSV.TabIndex = 1;
            this.btnDsSV.Text = "Xem danh sách câu hỏi";
            this.btnDsSV.UseVisualStyleBackColor = false;
            this.btnDsSV.Click += new System.EventHandler(this.btnDsSV_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuestion.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddQuestion.Location = new System.Drawing.Point(18, 30);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(149, 50);
            this.btnAddQuestion.TabIndex = 0;
            this.btnAddQuestion.Text = "Thêm câu hỏi";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // frmMCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 285);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMCHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MC HOME";
            this.Load += new System.EventHandler(this.frmMCHome_Load);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDsCDMo;
        private System.Windows.Forms.Button btnMoCD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDsSV;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Label lblMCId;
    }
}