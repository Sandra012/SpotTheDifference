namespace SpotTheDifference
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Find5Dif = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFive = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNextImg = new System.Windows.Forms.Button();
            this.btnChangeCategory = new System.Windows.Forms.Button();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.pbSpark2 = new System.Windows.Forms.PictureBox();
            this.pbSpark = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpark2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Find5Dif
            // 
            this.Find5Dif.AutoSize = true;
            this.Find5Dif.BackColor = System.Drawing.Color.White;
            this.Find5Dif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Find5Dif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find5Dif.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Find5Dif.Location = new System.Drawing.Point(51, 540);
            this.Find5Dif.Name = "Find5Dif";
            this.Find5Dif.Size = new System.Drawing.Size(156, 22);
            this.Find5Dif.TabIndex = 2;
            this.Find5Dif.Text = "Find 5 differences";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Location = new System.Drawing.Point(940, 547);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFive
            // 
            this.lblFive.AutoSize = true;
            this.lblFive.BackColor = System.Drawing.Color.White;
            this.lblFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFive.Location = new System.Drawing.Point(30, 6);
            this.lblFive.Name = "lblFive";
            this.lblFive.Size = new System.Drawing.Size(39, 26);
            this.lblFive.TabIndex = 9;
            this.lblFive.Text = "/ 5";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.BackColor = System.Drawing.Color.White;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(9, 6);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(25, 26);
            this.lblCorrect.TabIndex = 10;
            this.lblCorrect.Text = "0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(834, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Give up!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNextImg
            // 
            this.btnNextImg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNextImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextImg.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNextImg.Location = new System.Drawing.Point(719, 547);
            this.btnNextImg.Name = "btnNextImg";
            this.btnNextImg.Size = new System.Drawing.Size(107, 64);
            this.btnNextImg.TabIndex = 12;
            this.btnNextImg.Text = "Next image";
            this.btnNextImg.UseVisualStyleBackColor = false;
            this.btnNextImg.Click += new System.EventHandler(this.btnNextImg_Click);
            // 
            // btnChangeCategory
            // 
            this.btnChangeCategory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangeCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeCategory.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnChangeCategory.Location = new System.Drawing.Point(834, 582);
            this.btnChangeCategory.Name = "btnChangeCategory";
            this.btnChangeCategory.Size = new System.Drawing.Size(206, 29);
            this.btnChangeCategory.TabIndex = 13;
            this.btnChangeCategory.Text = "Change Category";
            this.btnChangeCategory.UseVisualStyleBackColor = false;
            this.btnChangeCategory.Click += new System.EventHandler(this.btnChangeCategory_Click);
            // 
            // pbLeft
            // 
            this.pbLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLeft.Location = new System.Drawing.Point(24, 13);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(500, 500);
            this.pbLeft.TabIndex = 0;
            this.pbLeft.TabStop = false;
            this.pbLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbLeft_MouseClick);
            // 
            // pbRight
            // 
            this.pbRight.BackColor = System.Drawing.Color.Transparent;
            this.pbRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRight.Location = new System.Drawing.Point(530, 13);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(500, 500);
            this.pbRight.TabIndex = 1;
            this.pbRight.TabStop = false;
            this.pbRight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbRight_MouseClick);
            // 
            // pbSpark2
            // 
            this.pbSpark2.BackColor = System.Drawing.Color.Transparent;
            this.pbSpark2.Image = global::SpotTheDifference.Properties.Resources.spark_trans21;
            this.pbSpark2.Location = new System.Drawing.Point(372, 539);
            this.pbSpark2.Name = "pbSpark2";
            this.pbSpark2.Size = new System.Drawing.Size(36, 33);
            this.pbSpark2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpark2.TabIndex = 15;
            this.pbSpark2.TabStop = false;
            // 
            // pbSpark
            // 
            this.pbSpark.BackColor = System.Drawing.Color.Transparent;
            this.pbSpark.Image = global::SpotTheDifference.Properties.Resources.spark_trans2;
            this.pbSpark.Location = new System.Drawing.Point(357, 535);
            this.pbSpark.Name = "pbSpark";
            this.pbSpark.Size = new System.Drawing.Size(51, 42);
            this.pbSpark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpark.TabIndex = 14;
            this.pbSpark.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SpotTheDifference.Properties.Resources.bomb2;
            this.pictureBox1.Location = new System.Drawing.Point(574, 551);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Controls.Add(this.lblFive);
            this.panel1.Controls.Add(this.lblCorrect);
            this.panel1.Location = new System.Drawing.Point(82, 565);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 39);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.pbLeft);
            this.panel2.Controls.Add(this.pbRight);
            this.panel2.Location = new System.Drawing.Point(12, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 524);
            this.panel2.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbSpark2);
            this.Controls.Add(this.pbSpark);
            this.Controls.Add(this.btnChangeCategory);
            this.Controls.Add(this.btnNextImg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Find5Dif);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "Form2";
            this.Text = "Spot the difference";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpark2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Find5Dif;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFive;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNextImg;
        private System.Windows.Forms.Button btnChangeCategory;
        private System.Windows.Forms.PictureBox pbSpark;
        private System.Windows.Forms.PictureBox pbSpark2;
        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}