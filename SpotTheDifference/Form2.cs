using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SpotTheDifference
{
    public partial class Form2 : Form
    {
        private Timer timer;
        private Form1 mainForm;
        ImagePair pair;
        private Line line;

        public Form2(Form callingForm)  
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
            NextImage();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetDesktopLocation(50, 50);
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.DarkCyan);     
            line.Draw(e.Graphics);
        }

        public void NextImage()
        {
            if (timer != null)
                timer.Dispose();
            InitializeTimer();
            InitializeSparks();
            InitializeLine();
            lblCorrect.Text = "0";
            ShowImages();
        }

        public void ShowImages()
        {
            SuspendLayout();
            pair = this.mainForm.category.getNewPair();
            pbLeft.Image = pair.left;
            pbRight.Image = pair.right;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            timer.Stop();
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
                Application.Exit();
            else if (result == DialogResult.No)
                timer.Start();
        }

        private void pbLeft_MouseClick(object sender, MouseEventArgs e)
        {
            ClickOnPhoto(sender, e);
        }

        private void pbRight_MouseClick(object sender, MouseEventArgs e)
        {
            ClickOnPhoto(sender, e);
        }

        public void ClickOnPhoto(object sender, MouseEventArgs e) {
            Point p = pair.isAcquired(new Point(e.X, e.Y));
            if (p != Point.Empty)
                TargetAcquired(p);
            else
                TargetNotAcquired();
        }

        public void TargetAcquired(Point p) {
            ShowDifference(p);
            int newScore = Convert.ToInt16(lblCorrect.Text) + 1;
            if (newScore == 5)
                NextImage();
            else
                lblCorrect.Text = newScore.ToString();
        }

        public void TargetNotAcquired()
        {
            MoveSparks(10, 10, pbSpark.Visible);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveSparks(1, 1, pbSpark.Visible);
        }

        public void MoveSparks(int moveLine, int moveSparks, Boolean b) {
            Bitmap bufl = new Bitmap(pbSpark.Width, pbSpark.Height);
            using (Graphics g = Graphics.FromImage(bufl))
            {
                if (line.X < 550)
                {
                    line.X += moveLine;
                    pbSpark.Location = new Point(pbSpark.Location.X + moveSparks, pbSpark.Location.Y);
                    pbSpark2.Location = new Point(pbSpark2.Location.X + moveSparks, pbSpark2.Location.Y);
                    if (b)
                    {
                        pbSpark.Hide(); pbSpark2.Show();
                    }
                    else
                    {
                        pbSpark2.Hide(); pbSpark.Show();
                    }
                }
                else
                    quit();
            }
        }   

        public void ShowDifference(Point p) {
            Pen pen = new Pen(Color.Yellow, 3);
            using (var g = Graphics.FromImage(pbLeft.Image))
            {
                g.DrawEllipse(pen, p.X - 20, p.Y - 20, 40, 40);
            }
            using (var g = Graphics.FromImage(pbRight.Image))
            {
                g.DrawEllipse(pen, p.X - 20, p.Y - 20, 40, 40);
            }
            pbLeft.Refresh();
            pbRight.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Dispose();
            foreach (Point p in pair.points)
                ShowDifference(p);
        }

        private void btnNextImg_Click(object sender, EventArgs e)
        {
            NextImage();
        }

        private void btnChangeCategory_Click(object sender, EventArgs e)
        {
            timer.Dispose();
            this.Close();
        }

        public void quit() {
            timer.Dispose();     
            DialogResult result = MessageBox.Show("Next image?", "You lose!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) { this.Close(); }
            else
                NextImage();
        }
       
        public void InitializeTimer() {
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        public void InitializeSparks() {
            pbSpark.Location = new Point(357, 535);
            pbSpark2.Location = new Point(372, 539);
        }

        public void InitializeLine(){
            line = new Line(390, 555, new Point(580, 555), 2);
            line.Draw(this.CreateGraphics());
        }
  
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Dispose();
            timer.Stop();
        }

    }
}
