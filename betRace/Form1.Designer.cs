namespace betRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.resetBtn = new System.Windows.Forms.Button();
            this.raceBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.winLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mxBet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.placeBetBtn = new System.Windows.Forms.Button();
            this.aiTB = new System.Windows.Forms.TextBox();
            this.bobTB = new System.Windows.Forms.TextBox();
            this.joeTB = new System.Windows.Forms.TextBox();
            this.dogNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.priceNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.betterTb = new System.Windows.Forms.TextBox();
            this.rbAi = new System.Windows.Forms.RadioButton();
            this.rbBob = new System.Windows.Forms.RadioButton();
            this.rbJoe = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(538, 408);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(106, 39);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // raceBtn
            // 
            this.raceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceBtn.Location = new System.Drawing.Point(663, 408);
            this.raceBtn.Name = "raceBtn";
            this.raceBtn.Size = new System.Drawing.Size(105, 39);
            this.raceBtn.TabIndex = 2;
            this.raceBtn.Text = "Race";
            this.raceBtn.UseVisualStyleBackColor = true;
            this.raceBtn.Click += new System.EventHandler(this.raceBtn_Click);
            // 
            // winLbl
            // 
            this.winLbl.AutoSize = true;
            this.winLbl.Font = new System.Drawing.Font("MktBold Plain:", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.winLbl.Location = new System.Drawing.Point(45, 416);
            this.winLbl.Name = "winLbl";
            this.winLbl.Size = new System.Drawing.Size(0, 31);
            this.winLbl.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 400);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(62, 364);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(62, 339);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::betRace.Properties.Resources.Car1;
            this.pictureBox1.Location = new System.Drawing.Point(62, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.mxBet);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.placeBetBtn);
            this.panel2.Controls.Add(this.aiTB);
            this.panel2.Controls.Add(this.bobTB);
            this.panel2.Controls.Add(this.joeTB);
            this.panel2.Controls.Add(this.dogNUD);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.priceNUD);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.betterTb);
            this.panel2.Controls.Add(this.rbAi);
            this.panel2.Controls.Add(this.rbBob);
            this.panel2.Controls.Add(this.rbJoe);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(108, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 194);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // mxBet
            // 
            this.mxBet.Location = new System.Drawing.Point(156, 16);
            this.mxBet.Name = "mxBet";
            this.mxBet.Size = new System.Drawing.Size(58, 20);
            this.mxBet.TabIndex = 13;
            this.mxBet.TextChanged += new System.EventHandler(this.mxBet_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Max bets $";
            // 
            // placeBetBtn
            // 
            this.placeBetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.placeBetBtn.Location = new System.Drawing.Point(171, 133);
            this.placeBetBtn.Name = "placeBetBtn";
            this.placeBetBtn.Size = new System.Drawing.Size(151, 43);
            this.placeBetBtn.TabIndex = 11;
            this.placeBetBtn.Text = "Place Bet";
            this.placeBetBtn.UseVisualStyleBackColor = false;
            this.placeBetBtn.Click += new System.EventHandler(this.placeBetBtn_Click);
            // 
            // aiTB
            // 
            this.aiTB.Location = new System.Drawing.Point(286, 89);
            this.aiTB.Name = "aiTB";
            this.aiTB.Size = new System.Drawing.Size(225, 20);
            this.aiTB.TabIndex = 10;
            this.aiTB.Text = "AI hasn\'t placed a bet ";
            // 
            // bobTB
            // 
            this.bobTB.Location = new System.Drawing.Point(286, 53);
            this.bobTB.Name = "bobTB";
            this.bobTB.Size = new System.Drawing.Size(225, 20);
            this.bobTB.TabIndex = 9;
            this.bobTB.Text = "Bob hasn\'t placed a bet ";
            // 
            // joeTB
            // 
            this.joeTB.Location = new System.Drawing.Point(286, 17);
            this.joeTB.Name = "joeTB";
            this.joeTB.Size = new System.Drawing.Size(223, 20);
            this.joeTB.TabIndex = 8;
            this.joeTB.Text = "Joe hasn\'t placed a bet ";
            // 
            // dogNUD
            // 
            this.dogNUD.Location = new System.Drawing.Point(196, 92);
            this.dogNUD.Name = "dogNUD";
            this.dogNUD.Size = new System.Drawing.Size(34, 20);
            this.dogNUD.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "On Car Number  #";
            // 
            // priceNUD
            // 
            this.priceNUD.Location = new System.Drawing.Point(216, 54);
            this.priceNUD.Name = "priceNUD";
            this.priceNUD.Size = new System.Drawing.Size(34, 20);
            this.priceNUD.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "bets $";
            // 
            // betterTb
            // 
            this.betterTb.Location = new System.Drawing.Point(77, 53);
            this.betterTb.Name = "betterTb";
            this.betterTb.Size = new System.Drawing.Size(85, 20);
            this.betterTb.TabIndex = 3;
            // 
            // rbAi
            // 
            this.rbAi.AutoSize = true;
            this.rbAi.Location = new System.Drawing.Point(24, 92);
            this.rbAi.Name = "rbAi";
            this.rbAi.Size = new System.Drawing.Size(37, 17);
            this.rbAi.TabIndex = 2;
            this.rbAi.TabStop = true;
            this.rbAi.Text = "AI";
            this.rbAi.UseVisualStyleBackColor = true;
            this.rbAi.CheckedChanged += new System.EventHandler(this.rbAi_CheckedChanged);
            // 
            // rbBob
            // 
            this.rbBob.AutoSize = true;
            this.rbBob.Location = new System.Drawing.Point(24, 57);
            this.rbBob.Name = "rbBob";
            this.rbBob.Size = new System.Drawing.Size(47, 17);
            this.rbBob.TabIndex = 1;
            this.rbBob.TabStop = true;
            this.rbBob.Text = "Bob";
            this.rbBob.UseVisualStyleBackColor = true;
            this.rbBob.CheckedChanged += new System.EventHandler(this.rbBob_CheckedChanged);
            // 
            // rbJoe
            // 
            this.rbJoe.AutoSize = true;
            this.rbJoe.Location = new System.Drawing.Point(24, 20);
            this.rbJoe.Name = "rbJoe";
            this.rbJoe.Size = new System.Drawing.Size(45, 17);
            this.rbJoe.TabIndex = 0;
            this.rbJoe.TabStop = true;
            this.rbJoe.Text = "Joe";
            this.rbJoe.UseVisualStyleBackColor = true;
            this.rbJoe.CheckedChanged += new System.EventHandler(this.rbJoe_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(79, 50);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(79, 25);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 19);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.ErrorImage")));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(79, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.winLbl);
            this.Controls.Add(this.raceBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button raceBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbAi;
        private System.Windows.Forms.RadioButton rbBob;
        private System.Windows.Forms.RadioButton rbJoe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox betterTb;
        private System.Windows.Forms.NumericUpDown priceNUD;
        private System.Windows.Forms.NumericUpDown dogNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aiTB;
        private System.Windows.Forms.TextBox bobTB;
        private System.Windows.Forms.TextBox joeTB;
        private System.Windows.Forms.Button placeBetBtn;
        private System.Windows.Forms.TextBox mxBet;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label winLbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

