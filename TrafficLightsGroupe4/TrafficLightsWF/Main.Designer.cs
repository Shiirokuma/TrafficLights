namespace TrafficLightsWF
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCarPosition = new System.Windows.Forms.Label();
            this.tmrFeu = new System.Windows.Forms.Timer(this.components);
            this.pcxBus1 = new System.Windows.Forms.PictureBox();
            this.pcbCar4 = new System.Windows.Forms.PictureBox();
            this.pcbCar3 = new System.Windows.Forms.PictureBox();
            this.pcbWhiteStrip4 = new System.Windows.Forms.PictureBox();
            this.pcbWhiteStrip3 = new System.Windows.Forms.PictureBox();
            this.pcbFeu4 = new System.Windows.Forms.PictureBox();
            this.pcbFeu3 = new System.Windows.Forms.PictureBox();
            this.pcbCarrfour = new System.Windows.Forms.PictureBox();
            this.pcbCar2 = new System.Windows.Forms.PictureBox();
            this.pcbFeu2 = new System.Windows.Forms.PictureBox();
            this.pcbWhiteStrip2 = new System.Windows.Forms.PictureBox();
            this.pcbWhiteStrip = new System.Windows.Forms.PictureBox();
            this.pcbFeu = new System.Windows.Forms.PictureBox();
            this.pcbCar = new System.Windows.Forms.PictureBox();
            this.pcbRoadLeft = new System.Windows.Forms.PictureBox();
            this.pcbRoadRight = new System.Windows.Forms.PictureBox();
            this.pcbRoadTop = new System.Windows.Forms.PictureBox();
            this.pcbRoadBottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcxBus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWhiteStrip4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWhiteStrip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFeu4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFeu3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrfour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFeu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWhiteStrip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWhiteStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFeu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoadLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoadRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoadTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoadBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCarPosition
            // 
            this.lblCarPosition.AutoSize = true;
            this.lblCarPosition.Location = new System.Drawing.Point(12, 9);
            this.lblCarPosition.Name = "lblCarPosition";
            this.lblCarPosition.Size = new System.Drawing.Size(35, 13);
            this.lblCarPosition.TabIndex = 6;
            this.lblCarPosition.Text = "label1";
            // 
            // tmrFeu
            // 
            this.tmrFeu.Enabled = true;
            this.tmrFeu.Interval = 1000;
            this.tmrFeu.Tick += new System.EventHandler(this.tmrFeu_Tick);
            // 
            // pcxBus1
            // 
            this.pcxBus1.Image = global::TrafficLightsWF.Properties.Resources.Bus;
            this.pcxBus1.Location = new System.Drawing.Point(387, 490);
            this.pcxBus1.Name = "pcxBus1";
            this.pcxBus1.Size = new System.Drawing.Size(27, 67);
            this.pcxBus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcxBus1.TabIndex = 21;
            this.pcxBus1.TabStop = false;
            // 
            // pcbCar4
            // 
            this.pcbCar4.BackColor = System.Drawing.Color.Transparent;
            this.pcbCar4.Image = global::TrafficLightsWF.Properties.Resources.voitureLEFT;
            this.pcbCar4.Location = new System.Drawing.Point(755, 189);
            this.pcbCar4.Name = "pcbCar4";
            this.pcbCar4.Size = new System.Drawing.Size(45, 25);
            this.pcbCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCar4.TabIndex = 20;
            this.pcbCar4.TabStop = false;
            // 
            // pcbCar3
            // 
            this.pcbCar3.BackColor = System.Drawing.Color.Transparent;
            this.pcbCar3.Image = global::TrafficLightsWF.Properties.Resources.voitureRIGHT;
            this.pcbCar3.Location = new System.Drawing.Point(0, 218);
            this.pcbCar3.Name = "pcbCar3";
            this.pcbCar3.Size = new System.Drawing.Size(45, 25);
            this.pcbCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCar3.TabIndex = 19;
            this.pcbCar3.TabStop = false;
            // 
            // pcbWhiteStrip4
            // 
            this.pcbWhiteStrip4.Location = new System.Drawing.Point(340, 217);
            this.pcbWhiteStrip4.Name = "pcbWhiteStrip4";
            this.pcbWhiteStrip4.Size = new System.Drawing.Size(7, 27);
            this.pcbWhiteStrip4.TabIndex = 18;
            this.pcbWhiteStrip4.TabStop = false;
            // 
            // pcbWhiteStrip3
            // 
            this.pcbWhiteStrip3.Location = new System.Drawing.Point(428, 188);
            this.pcbWhiteStrip3.Name = "pcbWhiteStrip3";
            this.pcbWhiteStrip3.Size = new System.Drawing.Size(7, 27);
            this.pcbWhiteStrip3.TabIndex = 17;
            this.pcbWhiteStrip3.TabStop = false;
            // 
            // pcbFeu4
            // 
            this.pcbFeu4.Image = global::TrafficLightsWF.Properties.Resources.FeuRouge;
            this.pcbFeu4.Location = new System.Drawing.Point(323, 256);
            this.pcbFeu4.Name = "pcbFeu4";
            this.pcbFeu4.Size = new System.Drawing.Size(24, 26);
            this.pcbFeu4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFeu4.TabIndex = 16;
            this.pcbFeu4.TabStop = false;
            // 
            // pcbFeu3
            // 
            this.pcbFeu3.Image = global::TrafficLightsWF.Properties.Resources.FeuRouge;
            this.pcbFeu3.Location = new System.Drawing.Point(428, 155);
            this.pcbFeu3.Name = "pcbFeu3";
            this.pcbFeu3.Size = new System.Drawing.Size(24, 26);
            this.pcbFeu3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFeu3.TabIndex = 15;
            this.pcbFeu3.TabStop = false;
            // 
            // pcbCarrfour
            // 
            this.pcbCarrfour.Image = global::TrafficLightsWF.Properties.Resources.carrfoure;
            this.pcbCarrfour.Location = new System.Drawing.Point(353, 181);
            this.pcbCarrfour.Name = "pcbCarrfour";
            this.pcbCarrfour.Size = new System.Drawing.Size(69, 69);
            this.pcbCarrfour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbCarrfour.TabIndex = 12;
            this.pcbCarrfour.TabStop = false;
            // 
            // pcbCar2
            // 
            this.pcbCar2.BackColor = System.Drawing.Color.Transparent;
            this.pcbCar2.Image = global::TrafficLightsWF.Properties.Resources.voitureBOTTOM;
            this.pcbCar2.Location = new System.Drawing.Point(360, 12);
            this.pcbCar2.Name = "pcbCar2";
            this.pcbCar2.Size = new System.Drawing.Size(25, 45);
            this.pcbCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCar2.TabIndex = 11;
            this.pcbCar2.TabStop = false;
            // 
            // pcbFeu2
            // 
            this.pcbFeu2.Image = global::TrafficLightsWF.Properties.Resources.FeuRouge;
            this.pcbFeu2.Location = new System.Drawing.Point(323, 155);
            this.pcbFeu2.Name = "pcbFeu2";
            this.pcbFeu2.Size = new System.Drawing.Size(24, 26);
            this.pcbFeu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFeu2.TabIndex = 10;
            this.pcbFeu2.TabStop = false;
            // 
            // pcbWhiteStrip2
            // 
            this.pcbWhiteStrip2.Location = new System.Drawing.Point(360, 174);
            this.pcbWhiteStrip2.Name = "pcbWhiteStrip2";
            this.pcbWhiteStrip2.Size = new System.Drawing.Size(27, 7);
            this.pcbWhiteStrip2.TabIndex = 9;
            this.pcbWhiteStrip2.TabStop = false;
            // 
            // pcbWhiteStrip
            // 
            this.pcbWhiteStrip.Location = new System.Drawing.Point(387, 256);
            this.pcbWhiteStrip.Name = "pcbWhiteStrip";
            this.pcbWhiteStrip.Size = new System.Drawing.Size(27, 7);
            this.pcbWhiteStrip.TabIndex = 8;
            this.pcbWhiteStrip.TabStop = false;
            // 
            // pcbFeu
            // 
            this.pcbFeu.Image = global::TrafficLightsWF.Properties.Resources.FeuRouge;
            this.pcbFeu.Location = new System.Drawing.Point(428, 256);
            this.pcbFeu.Name = "pcbFeu";
            this.pcbFeu.Size = new System.Drawing.Size(24, 26);
            this.pcbFeu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFeu.TabIndex = 7;
            this.pcbFeu.TabStop = false;
            // 
            // pcbCar
            // 
            this.pcbCar.BackColor = System.Drawing.Color.Transparent;
            this.pcbCar.Image = global::TrafficLightsWF.Properties.Resources.voitureTOP;
            this.pcbCar.Location = new System.Drawing.Point(389, 408);
            this.pcbCar.Name = "pcbCar";
            this.pcbCar.Size = new System.Drawing.Size(25, 45);
            this.pcbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCar.TabIndex = 5;
            this.pcbCar.TabStop = false;
            // 
            // pcbRoadLeft
            // 
            this.pcbRoadLeft.Image = global::TrafficLightsWF.Properties.Resources.route1;
            this.pcbRoadLeft.Location = new System.Drawing.Point(0, 181);
            this.pcbRoadLeft.Name = "pcbRoadLeft";
            this.pcbRoadLeft.Size = new System.Drawing.Size(355, 69);
            this.pcbRoadLeft.TabIndex = 4;
            this.pcbRoadLeft.TabStop = false;
            // 
            // pcbRoadRight
            // 
            this.pcbRoadRight.Image = global::TrafficLightsWF.Properties.Resources.route1;
            this.pcbRoadRight.Location = new System.Drawing.Point(420, 181);
            this.pcbRoadRight.Name = "pcbRoadRight";
            this.pcbRoadRight.Size = new System.Drawing.Size(380, 69);
            this.pcbRoadRight.TabIndex = 3;
            this.pcbRoadRight.TabStop = false;
            // 
            // pcbRoadTop
            // 
            this.pcbRoadTop.Image = global::TrafficLightsWF.Properties.Resources.route1;
            this.pcbRoadTop.Location = new System.Drawing.Point(353, 0);
            this.pcbRoadTop.Name = "pcbRoadTop";
            this.pcbRoadTop.Size = new System.Drawing.Size(69, 181);
            this.pcbRoadTop.TabIndex = 2;
            this.pcbRoadTop.TabStop = false;
            // 
            // pcbRoadBottom
            // 
            this.pcbRoadBottom.Image = global::TrafficLightsWF.Properties.Resources.route1;
            this.pcbRoadBottom.Location = new System.Drawing.Point(353, 248);
            this.pcbRoadBottom.Name = "pcbRoadBottom";
            this.pcbRoadBottom.Size = new System.Drawing.Size(69, 205);
            this.pcbRoadBottom.TabIndex = 1;
            this.pcbRoadBottom.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 601);
            this.Controls.Add(this.pcxBus1);
            this.Controls.Add(this.pcbCar4);
            this.Controls.Add(this.pcbCar3);
            this.Controls.Add(this.pcbWhiteStrip4);
            this.Controls.Add(this.pcbWhiteStrip3);
            this.Controls.Add(this.pcbFeu4);
            this.Controls.Add(this.pcbFeu3);
            this.Controls.Add(this.pcbCarrfour);
            this.Controls.Add(this.pcbCar2);
            this.Controls.Add(this.pcbFeu2);
            this.Controls.Add(this.pcbWhiteStrip2);
            this.Controls.Add(this.pcbWhiteStrip);
            this.Controls.Add(this.pcbFeu);
            this.Controls.Add(this.lblCarPosition);
            this.Controls.Add(this.pcbCar);
            this.Controls.Add(this.pcbRoadLeft);
            this.Controls.Add(this.pcbRoadRight);
            this.Controls.Add(this.pcbRoadTop);
            this.Controls.Add(this.pcbRoadBottom);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcxBus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWhiteStrip4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWhiteStrip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFeu4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFeu3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrfour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFeu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWhiteStrip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWhiteStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFeu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoadLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoadRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoadTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoadBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbRoadBottom;
        private System.Windows.Forms.PictureBox pcbRoadTop;
        private System.Windows.Forms.PictureBox pcbRoadRight;
        private System.Windows.Forms.PictureBox pcbRoadLeft;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pcbCar;
        private System.Windows.Forms.Label lblCarPosition;
        private System.Windows.Forms.PictureBox pcbFeu;
        private System.Windows.Forms.PictureBox pcbWhiteStrip;
        private System.Windows.Forms.PictureBox pcbWhiteStrip2;
        private System.Windows.Forms.PictureBox pcbFeu2;
        private System.Windows.Forms.PictureBox pcbCar2;
        private System.Windows.Forms.PictureBox pcbCarrfour;
        private System.Windows.Forms.PictureBox pcbFeu3;
        private System.Windows.Forms.PictureBox pcbFeu4;
        private System.Windows.Forms.PictureBox pcbWhiteStrip3;
        private System.Windows.Forms.PictureBox pcbWhiteStrip4;
        private System.Windows.Forms.PictureBox pcbCar3;
        private System.Windows.Forms.PictureBox pcbCar4;
        private System.Windows.Forms.Timer tmrFeu;
        private System.Windows.Forms.PictureBox pcxBus1;
    }
}

