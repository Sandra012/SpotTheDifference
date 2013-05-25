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
        private Form1 mainForm = null;
        ImagePair pair = null;
      

        private Line line = new Line(390, 555, new Point(580, 555), 2);
        
        


        private void Form2_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }
        public Form2() {
            InitializeComponent();

            line=new Line(390, 555, new Point(580, 555), 2);
            Point p1 = new Point(357, 535);
            pbSpark.Location = p1;
        }

        public Form2(Form callingForm)  
        {
            mainForm = callingForm as Form1; 
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 200 ;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            pair = new ImagePair();
            ShowImages();
        }
    

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.DarkCyan);
         
            line.Draw(e.Graphics);
        }

        private void pbLeft_MouseEnter(object sender, EventArgs e)
        {
            pbCursor.Show();
        }

        private void pbLeft_MouseMove(object sender, MouseEventArgs e)
        {
            Point pos=new Point();
            pos.X=(e.X+525);
            pos.Y=e.Y+15;
            pbCursor.Location = pos;          
           // lblPosition.Text = e.X.ToString() + " X " + e.Y.ToString();
        }

        private void pbLeft_MouseLeave(object sender, EventArgs e)
        {
            pbCursor.Hide();

        }

        private void pbRight_MouseEnter(object sender, EventArgs e)
        {
            pbCursor.Show();
        }

        private void pbRight_MouseMove(object sender, MouseEventArgs e)
        {
            
            pbCursor.Location = new Point(e.X+25, e.Y + 15) ;
        }

        private void pbRight_MouseLeave(object sender, EventArgs e)
        {
            pbCursor.Hide();
        }

        private void pbCursor_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            TransparencyKey = BackColor;        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Dispose();
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Application.Exit();
        }



        public void ShowImages(){
            SuspendLayout();
            pair = this.mainForm.category.getNewPair();
            pbLeft.Image = pair.left;
            pbRight.Image = pair.right;            
        }

        private void pbLeft_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = pair.isAcquired(new Point(e.X, e.Y));
            if (p != Point.Empty)
                TargetAcquired(p);
            else
                TargetNotAcquired();
        }

        public void TargetAcquired(Point p) {
            ShowDifference(p);
            lblCorrect.Text = (Convert.ToInt16(lblCorrect.Text) + 1).ToString();
            if (Convert.ToInt16(lblCorrect.Text) == 5) {
                timer.Stop();
                timer.Dispose();
                DialogResult result = MessageBox.Show("Try again?", "You won!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) { Application.Exit(); }
                else { this.Close(); }
            }
            
        }

       
        private void pbRight_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = pair.isAcquired(new Point(e.X, e.Y));
            if (p != Point.Empty)
                TargetAcquired(p);           
            else
                TargetNotAcquired();
        }

        public void TargetNotAcquired()
        {

        }

        public void ShowDifference(Point p) {
            Pen pen = new Pen(Color.Black, 2);
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
            timer.Start();
            
                Line line2 = new Line(390, 555, new Point(580, 555), 2);
                line = line2;
                Invalidate();
                Point p1 = new Point(357, 535);
                Point p2 = new Point(372, 539);
                pbSpark.Location = p1;
                pbSpark2.Location = p2;
            
            lblCorrect.Text = "0";
            ShowImages();
            
        }

        private void btnChangeCategory_Click(object sender, EventArgs e)
        {
            timer.Dispose();
            timer.Stop();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap bufl = new Bitmap(pbSpark.Width, pbSpark.Height);
            using (Graphics g = Graphics.FromImage(bufl))
            {

                if (line.X < 560)
                {
                    line.X ++;

                    if (pbSpark.Visible)
                    {
                        pbSpark.Hide(); pbSpark2.Show();
                        Point loc1 = new Point(pbSpark.Location.X + 1, pbSpark.Location.Y);
                        Point loc2 = new Point(pbSpark2.Location.X + 1, pbSpark2.Location.Y);
                        pbSpark2.Location = loc2;
                        pbSpark.Location = loc1;
                    }
                    else
                    {
                        Point loc1 = new Point(pbSpark.Location.X + 1, pbSpark.Location.Y);
                        Point loc2 = new Point(pbSpark2.Location.X + 1, pbSpark2.Location.Y);
                        pbSpark2.Hide(); pbSpark.Show();
                        pbSpark2.Location = loc2;
                        pbSpark.Location = loc1;
                    }
                }
                if (line.X == 560)
                {
                    quit();
                }
               // pbSpark.CreateGraphics().DrawImageUnscaled(bufl, 0, 0);
            }
        }
        public void quit() {
            timer.Stop();
            timer.Dispose();
        
            DialogResult result = MessageBox.Show("Try again?", "You lose!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) { Application.Exit(); }
            else
            {
                timer.Stop(); timer.Dispose();
                this.Close(); }
            
        }

        private void lblFive_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Dispose();
            timer.Stop();
        }
    }
}
