using System;

namespace Blackjack
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
            this.lblBanker = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.pbBankerCard1 = new System.Windows.Forms.PictureBox();
            this.pbPlayerCard1 = new System.Windows.Forms.PictureBox();
            this.pbPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.rsltLabel = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBankerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCard2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBanker
            // 
            this.lblBanker.AutoSize = true;
            this.lblBanker.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBanker.Location = new System.Drawing.Point(16, 53);
            this.lblBanker.Name = "lblBanker";
            this.lblBanker.Size = new System.Drawing.Size(41, 13);
            this.lblBanker.TabIndex = 98;
            this.lblBanker.Text = "Banker";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlayer.Location = new System.Drawing.Point(20, 183);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer.TabIndex = 99;
            this.lblPlayer.Text = "Player";
            // 
            // pbBankerCard1
            // 
            this.pbBankerCard1.Location = new System.Drawing.Point(77, 12);
            this.pbBankerCard1.Name = "pbBankerCard1";
            this.pbBankerCard1.Size = new System.Drawing.Size(71, 96);
            this.pbBankerCard1.TabIndex = 2;
            this.pbBankerCard1.TabStop = false;
            // 
            // pbPlayerCard1
            // 
            this.pbPlayerCard1.Location = new System.Drawing.Point(77, 144);
            this.pbPlayerCard1.Name = "pbPlayerCard1";
            this.pbPlayerCard1.Size = new System.Drawing.Size(71, 96);
            this.pbPlayerCard1.TabIndex = 3;
            this.pbPlayerCard1.TabStop = false;
            // 
            // pbPlayerCard2
            // 
            this.pbPlayerCard2.Location = new System.Drawing.Point(154, 144);
            this.pbPlayerCard2.Name = "pbPlayerCard2";
            this.pbPlayerCard2.Size = new System.Drawing.Size(71, 96);
            this.pbPlayerCard2.TabIndex = 4;
            this.pbPlayerCard2.TabStop = false;
            // 
            // rsltLabel
            // 
            this.rsltLabel.AutoSize = true;
            this.rsltLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rsltLabel.Location = new System.Drawing.Point(90, 270);
            this.rsltLabel.Name = "rsltLabel";
            this.rsltLabel.Size = new System.Drawing.Size(0, 13);
            this.rsltLabel.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 310);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(93, 310);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 2;
            this.btnHit.Text = "&Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(174, 310);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 23);
            this.btnStand.TabIndex = 3;
            this.btnStand.Text = "S&tand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.BtnStand_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(255, 310);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(712, 310);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(794, 341);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rsltLabel);
            this.Controls.Add(this.pbPlayerCard2);
            this.Controls.Add(this.pbPlayerCard1);
            this.Controls.Add(this.pbBankerCard1);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblBanker);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "BJ21";
            ((System.ComponentModel.ISupportInitialize)(this.pbBankerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCard2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblBanker;
        private System.Windows.Forms.PictureBox pbBankerCard1;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.PictureBox pbPlayerCard1;
        private System.Windows.Forms.PictureBox pbPlayerCard2;
        private System.Windows.Forms.Label rsltLabel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

