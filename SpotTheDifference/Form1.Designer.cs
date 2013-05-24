namespace SpotTheDifference
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
            this.lbChoose = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbNature = new System.Windows.Forms.PictureBox();
            this.pbSkopje = new System.Windows.Forms.PictureBox();
            this.pbFinki = new System.Windows.Forms.PictureBox();
            this.pbAnimals = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkopje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // lbChoose
            // 
            this.lbChoose.AutoSize = true;
            this.lbChoose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChoose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbChoose.Location = new System.Drawing.Point(128, 44);
            this.lbChoose.Name = "lbChoose";
            this.lbChoose.Size = new System.Drawing.Size(191, 24);
            this.lbChoose.TabIndex = 4;
            this.lbChoose.Text = "Choose a category:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(331, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbNature
            // 
            this.pbNature.Image = global::SpotTheDifference.Properties.Resources.pesok;
            this.pbNature.Location = new System.Drawing.Point(106, 194);
            this.pbNature.Name = "pbNature";
            this.pbNature.Size = new System.Drawing.Size(110, 110);
            this.pbNature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNature.TabIndex = 3;
            this.pbNature.TabStop = false;
            this.pbNature.Click += new System.EventHandler(this.pbNature_Click);
            // 
            // pbSkopje
            // 
            this.pbSkopje.Image = global::SpotTheDifference.Properties.Resources.kej;
            this.pbSkopje.Location = new System.Drawing.Point(222, 194);
            this.pbSkopje.Name = "pbSkopje";
            this.pbSkopje.Size = new System.Drawing.Size(110, 110);
            this.pbSkopje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSkopje.TabIndex = 2;
            this.pbSkopje.TabStop = false;
            this.pbSkopje.Click += new System.EventHandler(this.pbSkopje_Click);
            // 
            // pbFinki
            // 
            this.pbFinki.Image = global::SpotTheDifference.Properties.Resources.finki;
            this.pbFinki.Location = new System.Drawing.Point(222, 80);
            this.pbFinki.Name = "pbFinki";
            this.pbFinki.Size = new System.Drawing.Size(110, 110);
            this.pbFinki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFinki.TabIndex = 1;
            this.pbFinki.TabStop = false;
            this.pbFinki.Click += new System.EventHandler(this.pbFinki_Click);
            // 
            // pbAnimals
            // 
            this.pbAnimals.Image = global::SpotTheDifference.Properties.Resources.std10;
            this.pbAnimals.Location = new System.Drawing.Point(106, 78);
            this.pbAnimals.Name = "pbAnimals";
            this.pbAnimals.Size = new System.Drawing.Size(110, 110);
            this.pbAnimals.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimals.TabIndex = 6;
            this.pbAnimals.TabStop = false;
            this.pbAnimals.Click += new System.EventHandler(this.pbAnimals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 378);
            this.Controls.Add(this.pbAnimals);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbChoose);
            this.Controls.Add(this.pbNature);
            this.Controls.Add(this.pbSkopje);
            this.Controls.Add(this.pbFinki);
            this.Name = "Form1";
            this.Text = "Spot the difference";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbNature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkopje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFinki;
        private System.Windows.Forms.PictureBox pbSkopje;
        private System.Windows.Forms.PictureBox pbNature;
        private System.Windows.Forms.Label lbChoose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbAnimals;
    }
}

