namespace My_Daily_Wins_Project
{
    partial class frmAddNewAchievements
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
            this.tcAddNewAchievements = new System.Windows.Forms.TabControl();
            this.tpRecord = new System.Windows.Forms.TabPage();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.txtRecord = new System.Windows.Forms.TextBox();
            this.lblDayValue = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.tpSatisfaction = new System.Windows.Forms.TabPage();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.pnlSatisfaction = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblSatisfactionValue = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbSatisfactionValue = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tcAddNewAchievements.SuspendLayout();
            this.tpRecord.SuspendLayout();
            this.tpSatisfaction.SuspendLayout();
            this.pnlSatisfaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSatisfactionValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAddNewAchievements
            // 
            this.tcAddNewAchievements.Controls.Add(this.tpRecord);
            this.tcAddNewAchievements.Controls.Add(this.tpSatisfaction);
            this.tcAddNewAchievements.Location = new System.Drawing.Point(1, 0);
            this.tcAddNewAchievements.Name = "tcAddNewAchievements";
            this.tcAddNewAchievements.SelectedIndex = 0;
            this.tcAddNewAchievements.Size = new System.Drawing.Size(994, 504);
            this.tcAddNewAchievements.TabIndex = 16;
            // 
            // tpRecord
            // 
            this.tpRecord.BackgroundImage = global::My_Daily_Wins_Project.Properties.Resources.Rise_To_The_Top_image;
            this.tpRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpRecord.Controls.Add(this.lblDateValue);
            this.tpRecord.Controls.Add(this.btnNext);
            this.tpRecord.Controls.Add(this.btnClose);
            this.tpRecord.Controls.Add(this.lblDate);
            this.tpRecord.Controls.Add(this.lblDay);
            this.tpRecord.Controls.Add(this.txtRecord);
            this.tpRecord.Controls.Add(this.lblDayValue);
            this.tpRecord.Controls.Add(this.lblTitle2);
            this.tpRecord.Controls.Add(this.lblTitle1);
            this.tpRecord.Location = new System.Drawing.Point(4, 25);
            this.tpRecord.Name = "tpRecord";
            this.tpRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tpRecord.Size = new System.Drawing.Size(986, 475);
            this.tpRecord.TabIndex = 0;
            this.tpRecord.Text = "Record";
            this.tpRecord.UseVisualStyleBackColor = true;
            // 
            // lblDateValue
            // 
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.BackColor = System.Drawing.SystemColors.Control;
            this.lblDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateValue.Location = new System.Drawing.Point(137, 41);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(90, 25);
            this.lblDateValue.TabIndex = 6;
            this.lblDateValue.Text = "1/2/2000";
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.BackColor = System.Drawing.Color.Lime;
            this.btnNext.CausesValidation = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(510, 383);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(151, 51);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.CausesValidation = false;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(295, 383);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 51);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(82, 41);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 25);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.SystemColors.Control;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(736, 41);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(53, 25);
            this.lblDay.TabIndex = 4;
            this.lblDay.Text = "Day:";
            // 
            // txtRecord
            // 
            this.txtRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecord.Location = new System.Drawing.Point(87, 194);
            this.txtRecord.Multiline = true;
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecord.Size = new System.Drawing.Size(794, 169);
            this.txtRecord.TabIndex = 13;
            // 
            // lblDayValue
            // 
            this.lblDayValue.AutoSize = true;
            this.lblDayValue.BackColor = System.Drawing.SystemColors.Control;
            this.lblDayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayValue.Location = new System.Drawing.Point(786, 41);
            this.lblDayValue.Name = "lblDayValue";
            this.lblDayValue.Size = new System.Drawing.Size(95, 25);
            this.lblDayValue.TabIndex = 5;
            this.lblDayValue.Text = "Thursday";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Permanent Marker", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.Red;
            this.lblTitle2.Location = new System.Drawing.Point(346, 137);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(173, 47);
            this.lblTitle2.TabIndex = 12;
            this.lblTitle2.Text = "Mahmoud";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle1.Font = new System.Drawing.Font("Permanent Marker", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(80, 144);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(260, 40);
            this.lblTitle1.TabIndex = 8;
            this.lblTitle1.Text = "Record Your Wins";
            // 
            // tpSatisfaction
            // 
            this.tpSatisfaction.BackgroundImage = global::My_Daily_Wins_Project.Properties.Resources.Rise_To_The_Top_image;
            this.tpSatisfaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpSatisfaction.Controls.Add(this.btnSubmit);
            this.tpSatisfaction.Controls.Add(this.btnBack);
            this.tpSatisfaction.Controls.Add(this.lblTitle3);
            this.tpSatisfaction.Controls.Add(this.pnlSatisfaction);
            this.tpSatisfaction.Location = new System.Drawing.Point(4, 25);
            this.tpSatisfaction.Name = "tpSatisfaction";
            this.tpSatisfaction.Padding = new System.Windows.Forms.Padding(3);
            this.tpSatisfaction.Size = new System.Drawing.Size(986, 475);
            this.tpSatisfaction.TabIndex = 1;
            this.tpSatisfaction.Text = "Satisfaction";
            this.tpSatisfaction.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.CausesValidation = false;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(510, 383);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(151, 51);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.CausesValidation = false;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(295, 383);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(151, 51);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle3.Font = new System.Drawing.Font("Permanent Marker", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle3.Location = new System.Drawing.Point(153, 122);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(634, 40);
            this.lblTitle3.TabIndex = 9;
            this.lblTitle3.Text = "How Much You\'re Satisfied About Your Self?";
            // 
            // pnlSatisfaction
            // 
            this.pnlSatisfaction.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSatisfaction.Controls.Add(this.pictureBox3);
            this.pnlSatisfaction.Controls.Add(this.lblSatisfactionValue);
            this.pnlSatisfaction.Controls.Add(this.pictureBox5);
            this.pnlSatisfaction.Controls.Add(this.pictureBox2);
            this.pnlSatisfaction.Controls.Add(this.tbSatisfactionValue);
            this.pnlSatisfaction.Controls.Add(this.pictureBox1);
            this.pnlSatisfaction.Controls.Add(this.pictureBox4);
            this.pnlSatisfaction.Location = new System.Drawing.Point(156, 165);
            this.pnlSatisfaction.Name = "pnlSatisfaction";
            this.pnlSatisfaction.Size = new System.Drawing.Size(658, 171);
            this.pnlSatisfaction.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::My_Daily_Wins_Project.Properties.Resources.Happy_Emojie;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(604, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 41);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // lblSatisfactionValue
            // 
            this.lblSatisfactionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatisfactionValue.Location = new System.Drawing.Point(282, 124);
            this.lblSatisfactionValue.Name = "lblSatisfactionValue";
            this.lblSatisfactionValue.Size = new System.Drawing.Size(92, 32);
            this.lblSatisfactionValue.TabIndex = 7;
            this.lblSatisfactionValue.Text = "0";
            this.lblSatisfactionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::My_Daily_Wins_Project.Properties.Resources.Smile_Emojie;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(454, 18);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 41);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::My_Daily_Wins_Project.Properties.Resources.Crying_Emojie;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(4, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 41);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tbSatisfactionValue
            // 
            this.tbSatisfactionValue.Location = new System.Drawing.Point(4, 65);
            this.tbSatisfactionValue.Maximum = 100;
            this.tbSatisfactionValue.Name = "tbSatisfactionValue";
            this.tbSatisfactionValue.Size = new System.Drawing.Size(651, 56);
            this.tbSatisfactionValue.TabIndex = 6;
            this.tbSatisfactionValue.Scroll += new System.EventHandler(this.tbSatisfactionValue_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::My_Daily_Wins_Project.Properties.Resources.Normal_Emojie;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(304, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 41);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::My_Daily_Wins_Project.Properties.Resources.Sad_Emojie;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(154, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 41);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // frmAddNewAchievements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(997, 503);
            this.Controls.Add(this.tcAddNewAchievements);
            this.DoubleBuffered = true;
            this.Name = "frmAddNewAchievements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewAchievements";
            this.tcAddNewAchievements.ResumeLayout(false);
            this.tpRecord.ResumeLayout(false);
            this.tpRecord.PerformLayout();
            this.tpSatisfaction.ResumeLayout(false);
            this.tpSatisfaction.PerformLayout();
            this.pnlSatisfaction.ResumeLayout(false);
            this.pnlSatisfaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSatisfactionValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblDayValue;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.TextBox txtRecord;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tcAddNewAchievements;
        private System.Windows.Forms.TabPage tpRecord;
        private System.Windows.Forms.TabPage tpSatisfaction;
        private System.Windows.Forms.Panel pnlSatisfaction;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar tbSatisfactionValue;
        private System.Windows.Forms.Label lblSatisfactionValue;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
    }
}