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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbChoose = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInstr = new System.Windows.Forms.Button();
            this.pbAnimals = new System.Windows.Forms.PictureBox();
            this.pbNature = new System.Windows.Forms.PictureBox();
            this.pbSkopje = new System.Windows.Forms.PictureBox();
            this.pbFinki = new System.Windows.Forms.PictureBox();
            this.lbSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkopje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinki)).BeginInit();
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
            this.btnCancel.Location = new System.Drawing.Point(315, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInstr
            // 
            this.btnInstr.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstr.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInstr.Location = new System.Drawing.Point(12, 335);
            this.btnInstr.Name = "btnInstr";
            this.btnInstr.Size = new System.Drawing.Size(123, 31);
            this.btnInstr.TabIndex = 7;
            this.btnInstr.Text = "Instructions";
            this.btnInstr.UseVisualStyleBackColor = false;
            this.btnInstr.Click += new System.EventHandler(this.btnInstr_Click);
            // 
            // pbAnimals
            // 
            this.pbAnimals.Image = global::SpotTheDifference.Properties.Resources.std10;
            this.pbAnimals.Location = new System.Drawing.Point(106, 80);
            this.pbAnimals.Name = "pbAnimals";
            this.pbAnimals.Size = new System.Drawing.Size(110, 110);
            this.pbAnimals.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimals.TabIndex = 6;
            this.pbAnimals.TabStop = false;
            this.pbAnimals.Click += new System.EventHandler(this.pbAnimals_Click);
            this.pbAnimals.MouseEnter += new System.EventHandler(this.pbAnimals_MouseEnter);
          //  this.pbAnimals.MouseLeave += new System.EventHandler(this.pbAnimals_MouseLeave);
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
            this.pbNature.MouseEnter += new System.EventHandler(this.pbNature_MouseEnter);
            //this.pbNature.MouseLeave += new System.EventHandler(this.pbNature_MouseLeave);
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
            this.pbSkopje.MouseEnter += new System.EventHandler(this.pbSkopje_MouseEnter);
            //this.pbSkopje.MouseLeave += new System.EventHandler(this.pbSkopje_MouseLeave);
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
            this.pbFinki.MouseEnter += new System.EventHandler(this.pbFinki_MouseEnter);
            //this.pbFinki.MouseLeave += new System.EventHandler(this.pbFinki_MouseLeave);
            // 
            // lbSelect
            // 
            this.lbSelect.AutoSize = true;
            this.lbSelect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSelect.Location = new System.Drawing.Point(186, 342);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(0, 24);
            this.lbSelect.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 378);
            this.Controls.Add(this.lbSelect);
            this.Controls.Add(this.btnInstr);
            this.Controls.Add(this.pbAnimals);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbChoose);
            this.Controls.Add(this.pbNature);
            this.Controls.Add(this.pbSkopje);
            this.Controls.Add(this.pbFinki);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Spot the difference";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkopje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinki)).EndInit();
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
        private System.Windows.Forms.Button btnInstr;
        private System.Windows.Forms.Label lbSelect;
    }
}

