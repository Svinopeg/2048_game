﻿namespace _2048_Game
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
            this.UpDate = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.scores = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GameOwer = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOwer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Очки:";
            // 
            // scores
            // 
            this.scores.AutoSize = true;
            this.scores.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.scores.Location = new System.Drawing.Point(55, 9);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(19, 20);
            this.scores.TabIndex = 5;
            this.scores.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(215, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Старт";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_2048_Game.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(59, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 75);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // GameOwer
            // 
            this.GameOwer.BackColor = System.Drawing.Color.Transparent;
            this.GameOwer.BackgroundImage = global::_2048_Game.Properties.Resources.gm;
            this.GameOwer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameOwer.Enabled = false;
            this.GameOwer.Location = new System.Drawing.Point(-3, 264);
            this.GameOwer.Name = "GameOwer";
            this.GameOwer.Size = new System.Drawing.Size(284, 132);
            this.GameOwer.TabIndex = 6;
            this.GameOwer.TabStop = false;
            this.GameOwer.Visible = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.start.Location = new System.Drawing.Point(213, 5);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(57, 28);
            this.start.TabIndex = 3;
            this.start.TabStop = false;
            this.start.Click += new System.EventHandler(this.start_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(279, 396);
            this.Controls.Add(this.GameOwer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.K_D);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOwer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer UpDate;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scores;
        private System.Windows.Forms.PictureBox GameOwer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

