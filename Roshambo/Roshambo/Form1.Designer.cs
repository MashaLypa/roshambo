﻿namespace Roshambo
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userPanelRock = new System.Windows.Forms.Panel();
            this.pictureBoxRockUser = new System.Windows.Forms.PictureBox();
            this.userPanelScissors = new System.Windows.Forms.Panel();
            this.pictureBoxScissorsUser = new System.Windows.Forms.PictureBox();
            this.userPanelPaper = new System.Windows.Forms.Panel();
            this.pictureBoxPaperUser = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxRockComp = new System.Windows.Forms.PictureBox();
            this.pictureBoxPaperComp = new System.Windows.Forms.PictureBox();
            this.pictureBoxScissorsComp = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelComp = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userPanelRock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRockUser)).BeginInit();
            this.userPanelScissors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScissorsUser)).BeginInit();
            this.userPanelPaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaperUser)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRockComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaperComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScissorsComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // userPanelRock
            // 
            this.userPanelRock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPanelRock.Controls.Add(this.pictureBoxRockUser);
            this.userPanelRock.Location = new System.Drawing.Point(11, 81);
            this.userPanelRock.Name = "userPanelRock";
            this.userPanelRock.Size = new System.Drawing.Size(120, 120);
            this.userPanelRock.TabIndex = 0;
            this.userPanelRock.Tag = "Rock";
            this.userPanelRock.MouseEnter += new System.EventHandler(this.userPanel_MouseEnter);
            // 
            // pictureBoxRockUser
            // 
            this.pictureBoxRockUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRockUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRockUser.Image")));
            this.pictureBoxRockUser.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRockUser.Name = "pictureBoxRockUser";
            this.pictureBoxRockUser.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxRockUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRockUser.TabIndex = 4;
            this.pictureBoxRockUser.TabStop = false;
            this.pictureBoxRockUser.Tag = "";
            this.pictureBoxRockUser.Visible = false;
            this.pictureBoxRockUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxUser_MouseClick);
            // 
            // userPanelScissors
            // 
            this.userPanelScissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPanelScissors.Controls.Add(this.pictureBoxScissorsUser);
            this.userPanelScissors.Location = new System.Drawing.Point(158, 81);
            this.userPanelScissors.Name = "userPanelScissors";
            this.userPanelScissors.Size = new System.Drawing.Size(120, 120);
            this.userPanelScissors.TabIndex = 1;
            this.userPanelScissors.Tag = "Scissors";
            this.userPanelScissors.MouseEnter += new System.EventHandler(this.userPanel_MouseEnter);
            // 
            // pictureBoxScissorsUser
            // 
            this.pictureBoxScissorsUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxScissorsUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxScissorsUser.Image")));
            this.pictureBoxScissorsUser.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxScissorsUser.Name = "pictureBoxScissorsUser";
            this.pictureBoxScissorsUser.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxScissorsUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScissorsUser.TabIndex = 6;
            this.pictureBoxScissorsUser.TabStop = false;
            this.pictureBoxScissorsUser.Visible = false;
            this.pictureBoxScissorsUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxUser_MouseClick);
            // 
            // userPanelPaper
            // 
            this.userPanelPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPanelPaper.Controls.Add(this.pictureBoxPaperUser);
            this.userPanelPaper.Location = new System.Drawing.Point(314, 81);
            this.userPanelPaper.Name = "userPanelPaper";
            this.userPanelPaper.Size = new System.Drawing.Size(120, 120);
            this.userPanelPaper.TabIndex = 2;
            this.userPanelPaper.Tag = "Paper";
            this.userPanelPaper.MouseEnter += new System.EventHandler(this.userPanel_MouseEnter);
            // 
            // pictureBoxPaperUser
            // 
            this.pictureBoxPaperUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPaperUser.Image")));
            this.pictureBoxPaperUser.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPaperUser.Name = "pictureBoxPaperUser";
            this.pictureBoxPaperUser.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxPaperUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPaperUser.TabIndex = 5;
            this.pictureBoxPaperUser.TabStop = false;
            this.pictureBoxPaperUser.Visible = false;
            this.pictureBoxPaperUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxUser_MouseClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBoxRockComp);
            this.panel4.Controls.Add(this.pictureBoxPaperComp);
            this.panel4.Controls.Add(this.pictureBoxScissorsComp);
            this.panel4.Location = new System.Drawing.Point(615, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 120);
            this.panel4.TabIndex = 3;
            // 
            // pictureBoxRockComp
            // 
            this.pictureBoxRockComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRockComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRockComp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRockComp.Image")));
            this.pictureBoxRockComp.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRockComp.Name = "pictureBoxRockComp";
            this.pictureBoxRockComp.Size = new System.Drawing.Size(118, 118);
            this.pictureBoxRockComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRockComp.TabIndex = 5;
            this.pictureBoxRockComp.TabStop = false;
            this.pictureBoxRockComp.Tag = "";
            this.pictureBoxRockComp.Visible = false;
            // 
            // pictureBoxPaperComp
            // 
            this.pictureBoxPaperComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPaperComp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPaperComp.Image")));
            this.pictureBoxPaperComp.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPaperComp.Name = "pictureBoxPaperComp";
            this.pictureBoxPaperComp.Size = new System.Drawing.Size(118, 118);
            this.pictureBoxPaperComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPaperComp.TabIndex = 6;
            this.pictureBoxPaperComp.TabStop = false;
            this.pictureBoxPaperComp.Visible = false;
            // 
            // pictureBoxScissorsComp
            // 
            this.pictureBoxScissorsComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxScissorsComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxScissorsComp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxScissorsComp.Image")));
            this.pictureBoxScissorsComp.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxScissorsComp.Name = "pictureBoxScissorsComp";
            this.pictureBoxScissorsComp.Size = new System.Drawing.Size(118, 118);
            this.pictureBoxScissorsComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScissorsComp.TabIndex = 7;
            this.pictureBoxScissorsComp.TabStop = false;
            this.pictureBoxScissorsComp.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelMessage
            // 
            this.labelMessage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMessage.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessage.Location = new System.Drawing.Point(12, 19);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(423, 40);
            this.labelMessage.TabIndex = 4;
            this.labelMessage.Text = "Choose your figure!";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelComp
            // 
            this.labelComp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelComp.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComp.ImageKey = "(отсутствует)";
            this.labelComp.Location = new System.Drawing.Point(615, 19);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(120, 40);
            this.labelComp.TabIndex = 5;
            this.labelComp.Text = "Computer";
            this.labelComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScore
            // 
            this.labelScore.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelScore.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(11, 238);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(724, 43);
            this.labelScore.TabIndex = 6;
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.LargeChange = 1;
            this.trackBarSpeed.Location = new System.Drawing.Point(568, 81);
            this.trackBarSpeed.Maximum = 5;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarSpeed.Size = new System.Drawing.Size(45, 119);
            this.trackBarSpeed.TabIndex = 7;
            this.trackBarSpeed.Value = 3;
            this.trackBarSpeed.ValueChanged += new System.EventHandler(this.trackBarSpeed_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(565, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Eazy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelComp);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.userPanelPaper);
            this.Controls.Add(this.userPanelScissors);
            this.Controls.Add(this.userPanelRock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roshambo";
            this.userPanelRock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRockUser)).EndInit();
            this.userPanelScissors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScissorsUser)).EndInit();
            this.userPanelPaper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaperUser)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRockComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaperComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScissorsComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel userPanelRock;
        private System.Windows.Forms.Panel userPanelScissors;
        private System.Windows.Forms.Panel userPanelPaper;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBoxRockUser;
        private System.Windows.Forms.PictureBox pictureBoxPaperUser;
        private System.Windows.Forms.PictureBox pictureBoxScissorsUser;
        private System.Windows.Forms.PictureBox pictureBoxPaperComp;
        private System.Windows.Forms.PictureBox pictureBoxScissorsComp;
        private System.Windows.Forms.PictureBox pictureBoxRockComp;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelComp;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

