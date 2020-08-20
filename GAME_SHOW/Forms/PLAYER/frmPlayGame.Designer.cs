namespace GAME_SHOW.Forms.PLAYER
{
    partial class frmPlayGame
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
            this.components = new System.ComponentModel.Container();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.userScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpSingleAnswers1 = new System.Windows.Forms.GroupBox();
            this.lblB = new System.Windows.Forms.Label();
            this.rdoB = new System.Windows.Forms.RadioButton();
            this.lblC = new System.Windows.Forms.Label();
            this.rdoC = new System.Windows.Forms.RadioButton();
            this.lblD = new System.Windows.Forms.Label();
            this.rdoD = new System.Windows.Forms.RadioButton();
            this.lblA = new System.Windows.Forms.Label();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            this.grpSingleAnswers1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(501, 476);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(170, 32);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Chốt";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(12, 476);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(77, 32);
            this.btnQuit.TabIndex = 17;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox3.Controls.Add(this.grpSingleAnswers1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Linen;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(659, 458);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Question";
            // 
            // userScore
            // 
            this.userScore.AutoSize = true;
            this.userScore.Location = new System.Drawing.Point(184, 486);
            this.userScore.Name = "userScore";
            this.userScore.Size = new System.Drawing.Size(13, 13);
            this.userScore.TabIndex = 4;
            this.userScore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Điểm của bạn";
            // 
            // grpSingleAnswers1
            // 
            this.grpSingleAnswers1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.grpSingleAnswers1.Controls.Add(this.lblB);
            this.grpSingleAnswers1.Controls.Add(this.rdoB);
            this.grpSingleAnswers1.Controls.Add(this.lblC);
            this.grpSingleAnswers1.Controls.Add(this.rdoC);
            this.grpSingleAnswers1.Controls.Add(this.lblD);
            this.grpSingleAnswers1.Controls.Add(this.rdoD);
            this.grpSingleAnswers1.Controls.Add(this.lblA);
            this.grpSingleAnswers1.Controls.Add(this.rdoA);
            this.grpSingleAnswers1.ForeColor = System.Drawing.Color.PeachPuff;
            this.grpSingleAnswers1.Location = new System.Drawing.Point(54, 79);
            this.grpSingleAnswers1.Name = "grpSingleAnswers1";
            this.grpSingleAnswers1.Size = new System.Drawing.Size(571, 353);
            this.grpSingleAnswers1.TabIndex = 1;
            this.grpSingleAnswers1.TabStop = false;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(26, 107);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(86, 13);
            this.lblB.TabIndex = 7;
            this.lblB.Text = "Câu này đúng";
            // 
            // rdoB
            // 
            this.rdoB.AutoSize = true;
            this.rdoB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdoB.Location = new System.Drawing.Point(6, 107);
            this.rdoB.Name = "rdoB";
            this.rdoB.Size = new System.Drawing.Size(14, 13);
            this.rdoB.TabIndex = 6;
            this.rdoB.TabStop = true;
            this.rdoB.UseVisualStyleBackColor = true;
            this.rdoB.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(26, 204);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(86, 13);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "Câu này đúng";
            this.lblC.Click += new System.EventHandler(this.label4_Click);
            // 
            // rdoC
            // 
            this.rdoC.AutoSize = true;
            this.rdoC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdoC.Location = new System.Drawing.Point(6, 204);
            this.rdoC.Name = "rdoC";
            this.rdoC.Size = new System.Drawing.Size(14, 13);
            this.rdoC.TabIndex = 4;
            this.rdoC.TabStop = true;
            this.rdoC.UseVisualStyleBackColor = true;
            this.rdoC.CheckedChanged += new System.EventHandler(this.rdoC_CheckedChanged);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(26, 302);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(86, 13);
            this.lblD.TabIndex = 3;
            this.lblD.Text = "Câu này đúng";
            // 
            // rdoD
            // 
            this.rdoD.AutoSize = true;
            this.rdoD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdoD.Location = new System.Drawing.Point(6, 302);
            this.rdoD.Name = "rdoD";
            this.rdoD.Size = new System.Drawing.Size(14, 13);
            this.rdoD.TabIndex = 2;
            this.rdoD.TabStop = true;
            this.rdoD.UseVisualStyleBackColor = true;
            this.rdoD.CheckedChanged += new System.EventHandler(this.rdoD_CheckedChanged);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(26, 19);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(86, 13);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "Câu này đúng";
            // 
            // rdoA
            // 
            this.rdoA.AutoSize = true;
            this.rdoA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdoA.Location = new System.Drawing.Point(6, 19);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(14, 13);
            this.rdoA.TabIndex = 0;
            this.rdoA.TabStop = true;
            this.rdoA.UseVisualStyleBackColor = true;
            this.rdoA.CheckedChanged += new System.EventHandler(this.rdoAnswer1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Câu trả lời nào sau đây đúng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Câu hỏi:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 517);
            this.Controls.Add(this.userScore);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmPlayGame";
            this.Text = "frmPlayGame";
            this.Load += new System.EventHandler(this.frmPlayGame_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpSingleAnswers1.ResumeLayout(false);
            this.grpSingleAnswers1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpSingleAnswers1;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.RadioButton rdoB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.RadioButton rdoC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.RadioButton rdoD;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.RadioButton rdoA;
        private System.Windows.Forms.Label userScore;
        private System.Windows.Forms.Label label3;
    }
}