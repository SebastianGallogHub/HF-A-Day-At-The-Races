﻿namespace A_Day_At_The_Races
{
    partial class Parlor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parlor));
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.JoeRB = new System.Windows.Forms.RadioButton();
            this.BobRB = new System.Windows.Forms.RadioButton();
            this.AlRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Allbl = new System.Windows.Forms.Label();
            this.Boblbl = new System.Windows.Forms.Label();
            this.Joelbl = new System.Windows.Forms.Label();
            this.dogOrder = new System.Windows.Forms.NumericUpDown();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.betsLabel = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.Bet = new System.Windows.Forms.Button();
            this.race = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrack
            // 
            this.raceTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.raceTrack.Image = ((System.Drawing.Image)(resources.GetObject("raceTrack.Image")));
            this.raceTrack.Location = new System.Drawing.Point(12, 12);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(649, 283);
            this.raceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrack.TabIndex = 0;
            this.raceTrack.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = ((System.Drawing.Image)(resources.GetObject("dog1.Image")));
            this.dog1.Location = new System.Drawing.Point(26, 24);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(80, 36);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog1.TabIndex = 1;
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = ((System.Drawing.Image)(resources.GetObject("dog2.Image")));
            this.dog2.Location = new System.Drawing.Point(26, 93);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(80, 36);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog2.TabIndex = 1;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = ((System.Drawing.Image)(resources.GetObject("dog3.Image")));
            this.dog3.Location = new System.Drawing.Point(26, 169);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(80, 36);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog3.TabIndex = 1;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = ((System.Drawing.Image)(resources.GetObject("dog4.Image")));
            this.dog4.Location = new System.Drawing.Point(26, 238);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(80, 36);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog4.TabIndex = 1;
            this.dog4.TabStop = false;
            // 
            // JoeRB
            // 
            this.JoeRB.AutoSize = true;
            this.JoeRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoeRB.Location = new System.Drawing.Point(44, 48);
            this.JoeRB.Name = "JoeRB";
            this.JoeRB.Size = new System.Drawing.Size(101, 17);
            this.JoeRB.TabIndex = 2;
            this.JoeRB.Text = "JoeRadioButton";
            this.JoeRB.UseVisualStyleBackColor = true;
            this.JoeRB.CheckedChanged += new System.EventHandler(this.JoeRB_CheckedChanged);
            // 
            // BobRB
            // 
            this.BobRB.AutoSize = true;
            this.BobRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BobRB.Location = new System.Drawing.Point(44, 71);
            this.BobRB.Name = "BobRB";
            this.BobRB.Size = new System.Drawing.Size(103, 17);
            this.BobRB.TabIndex = 2;
            this.BobRB.Text = "BobRadioButton";
            this.BobRB.UseVisualStyleBackColor = true;
            this.BobRB.CheckedChanged += new System.EventHandler(this.BobRB_CheckedChanged);
            // 
            // AlRB
            // 
            this.AlRB.AutoSize = true;
            this.AlRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlRB.Location = new System.Drawing.Point(44, 94);
            this.AlRB.Name = "AlRB";
            this.AlRB.Size = new System.Drawing.Size(93, 17);
            this.AlRB.TabIndex = 2;
            this.AlRB.Text = "AlRadioButton";
            this.AlRB.UseVisualStyleBackColor = true;
            this.AlRB.CheckedChanged += new System.EventHandler(this.AlRB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Allbl);
            this.groupBox1.Controls.Add(this.Boblbl);
            this.groupBox1.Controls.Add(this.Joelbl);
            this.groupBox1.Controls.Add(this.dogOrder);
            this.groupBox1.Controls.Add(this.betAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.betsLabel);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Controls.Add(this.Bet);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.BobRB);
            this.groupBox1.Controls.Add(this.AlRB);
            this.groupBox1.Controls.Add(this.JoeRB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 164);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // Allbl
            // 
            this.Allbl.AutoSize = true;
            this.Allbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allbl.Location = new System.Drawing.Point(207, 96);
            this.Allbl.Name = "Allbl";
            this.Allbl.Size = new System.Drawing.Size(42, 13);
            this.Allbl.TabIndex = 8;
            this.Allbl.Text = "AlLabel";
            // 
            // Boblbl
            // 
            this.Boblbl.AutoSize = true;
            this.Boblbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boblbl.Location = new System.Drawing.Point(207, 73);
            this.Boblbl.Name = "Boblbl";
            this.Boblbl.Size = new System.Drawing.Size(52, 13);
            this.Boblbl.TabIndex = 8;
            this.Boblbl.Text = "BobLabel";
            // 
            // Joelbl
            // 
            this.Joelbl.AutoSize = true;
            this.Joelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joelbl.Location = new System.Drawing.Point(207, 50);
            this.Joelbl.Name = "Joelbl";
            this.Joelbl.Size = new System.Drawing.Size(50, 13);
            this.Joelbl.TabIndex = 8;
            this.Joelbl.Text = "JoeLabel";
            // 
            // dogOrder
            // 
            this.dogOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogOrder.Location = new System.Drawing.Point(268, 135);
            this.dogOrder.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogOrder.Name = "dogOrder";
            this.dogOrder.Size = new System.Drawing.Size(39, 20);
            this.dogOrder.TabIndex = 7;
            this.dogOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // betAmount
            // 
            this.betAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betAmount.Location = new System.Drawing.Point(145, 135);
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(39, 20);
            this.betAmount.TabIndex = 7;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "bucks on dog";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(64, 137);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 5;
            this.name.Text = "name";
            // 
            // betsLabel
            // 
            this.betsLabel.AutoSize = true;
            this.betsLabel.Location = new System.Drawing.Point(207, 26);
            this.betsLabel.Name = "betsLabel";
            this.betsLabel.Size = new System.Drawing.Size(36, 13);
            this.betsLabel.TabIndex = 4;
            this.betsLabel.Text = "Bets:";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Location = new System.Drawing.Point(41, 26);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(100, 13);
            this.minimumBetLabel.TabIndex = 4;
            this.minimumBetLabel.Text = "Minimum Bet: $5";
            // 
            // Bet
            // 
            this.Bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bet.Location = new System.Drawing.Point(103, 135);
            this.Bet.Name = "Bet";
            this.Bet.Size = new System.Drawing.Size(36, 22);
            this.Bet.TabIndex = 3;
            this.Bet.Text = "Bets";
            this.Bet.UseVisualStyleBackColor = true;
            this.Bet.Click += new System.EventHandler(this.Bet_Click);
            // 
            // race
            // 
            this.race.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.Location = new System.Drawing.Point(433, 40);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(184, 107);
            this.race.TabIndex = 3;
            this.race.Text = "Race!";
            this.race.UseVisualStyleBackColor = true;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // Parlor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.raceTrack);
            this.Name = "Parlor";
            this.Text = "A Day At The Races";
            this.Load += new System.EventHandler(this.Parlor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.RadioButton JoeRB;
        private System.Windows.Forms.RadioButton BobRB;
        private System.Windows.Forms.RadioButton AlRB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button Bet;
        private System.Windows.Forms.NumericUpDown dogOrder;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Label Joelbl;
        private System.Windows.Forms.Label betsLabel;
        private System.Windows.Forms.Label Allbl;
        private System.Windows.Forms.Label Boblbl;
    }
}

