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
            this.pcbRoadBottom = new System.Windows.Forms.PictureBox();
            this.pcbRoadTop = new System.Windows.Forms.PictureBox();
            this.pcbRoadRight = new System.Windows.Forms.PictureBox();
            this.pcbRoadLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoadBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoadTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoadRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoadLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbRoadBottom
            // 
            this.pcbRoadBottom.Location = new System.Drawing.Point(353, 256);
            this.pcbRoadBottom.Name = "pcbRoadBottom";
            this.pcbRoadBottom.Size = new System.Drawing.Size(69, 197);
            this.pcbRoadBottom.TabIndex = 1;
            this.pcbRoadBottom.TabStop = false;
            // 
            // pcbRoadTop
            // 
            this.pcbRoadTop.Location = new System.Drawing.Point(353, 0);
            this.pcbRoadTop.Name = "pcbRoadTop";
            this.pcbRoadTop.Size = new System.Drawing.Size(69, 177);
            this.pcbRoadTop.TabIndex = 2;
            this.pcbRoadTop.TabStop = false;
            // 
            // pcbRoadRight
            // 
            this.pcbRoadRight.Image = global::TrafficLightsWF.Properties.Resources.route;
            this.pcbRoadRight.Location = new System.Drawing.Point(428, 183);
            this.pcbRoadRight.Name = "pcbRoadRight";
            this.pcbRoadRight.Size = new System.Drawing.Size(372, 69);
            this.pcbRoadRight.TabIndex = 3;
            this.pcbRoadRight.TabStop = false;
            // 
            // pcbRoadLeft
            // 
            this.pcbRoadLeft.Location = new System.Drawing.Point(0, 183);
            this.pcbRoadLeft.Name = "pcbRoadLeft";
            this.pcbRoadLeft.Size = new System.Drawing.Size(347, 69);
            this.pcbRoadLeft.TabIndex = 4;
            this.pcbRoadLeft.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcbRoadLeft);
            this.Controls.Add(this.pcbRoadRight);
            this.Controls.Add(this.pcbRoadTop);
            this.Controls.Add(this.pcbRoadBottom);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoadBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoadTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoadRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoadLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbRoadBottom;
        private System.Windows.Forms.PictureBox pcbRoadTop;
        private System.Windows.Forms.PictureBox pcbRoadRight;
        private System.Windows.Forms.PictureBox pcbRoadLeft;
    }
}

