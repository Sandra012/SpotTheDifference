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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbCursor = new System.Windows.Forms.PictureBox();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.lblPosition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find 5 differences";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(318, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time left";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(929, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbCursor
            // 
            this.pbCursor.BackColor = System.Drawing.Color.Transparent;
            this.pbCursor.Image = ((System.Drawing.Image)(resources.GetObject("pbCursor.Image")));
            this.pbCursor.InitialImage = null;
            this.pbCursor.Location = new System.Drawing.Point(784, 124);
            this.pbCursor.Name = "pbCursor";
            this.pbCursor.Size = new System.Drawing.Size(20, 24);
            this.pbCursor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCursor.TabIndex = 5;
            this.pbCursor.TabStop = false;
            this.pbCursor.Visible = false;
            this.pbCursor.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pbCursor_LoadCompleted);
            // 
            // pbRight
            // 
            this.pbRight.BackColor = System.Drawing.Color.Transparent;
            this.pbRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRight.Location = new System.Drawing.Point(547, 19);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(500, 500);
            this.pbRight.TabIndex = 1;
            this.pbRight.TabStop = false;
            this.pbRight.MouseEnter += new System.EventHandler(this.pbRight_MouseEnter);
            this.pbRight.MouseLeave += new System.EventHandler(this.pbRight_MouseLeave);
            this.pbRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbRight_MouseMove);
            // 
            // pbLeft
            // 
            this.pbLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLeft.Location = new System.Drawing.Point(32, 19);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(500, 500);
            this.pbLeft.TabIndex = 0;
            this.pbLeft.TabStop = false;
 //           this.pbLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbLeft_MouseClick);
            this.pbLeft.MouseEnter += new System.EventHandler(this.pbLeft_MouseEnter);
            this.pbLeft.MouseLeave += new System.EventHandler(this.pbLeft_MouseLeave);
            this.pbLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbLeft_MouseMove);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(646, 547);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(41, 13);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "label3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 607);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.pbCursor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.pbLeft);
            this.Name = "Form2";
            this.Text = "Spot the difference";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbCursor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPosition;
    }
}