using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace SpotTheDifference
{
    public partial class Form2 : Form
    {
        Bitmap bmpImg;
        private Timer timer;
        private Form1 mainForm = null;
        ImagePair pair = null;

        public Form2() {
            InitializeComponent();
        }

        public Form2(Form callingForm)
        {
            mainForm = callingForm as Form1; 
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            pair = new ImagePair();
            ShowImages();
        }
    

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.GreenYellow);
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
            lblPosition.Text = e.X.ToString() + " X " + e.Y.ToString();
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
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        public void ShowImages(){
            SuspendLayout();
            pair = this.mainForm.category.getNewPair();
            pbLeft.Image = pair.left;
            pbRight.Image = pair.right;            
        }




    }
}
