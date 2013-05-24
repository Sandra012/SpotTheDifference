using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SpotTheDifference
{
    public partial class Form1 : Form
    {

        public Category category;
        Form2 form2;

        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Black);
           
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Application.Exit();
        }

        private void pbAnimals_MouseEnter(object sender, EventArgs e)
        {
           pbAnimals.BackgroundImage = Properties.Resources.std10_v2;
        }

        private void pbAnimals_Click(object sender, EventArgs e)
        {
            category = new Category("animals");
            form2 = new Form2(this);
            form2.Show();
        }

        private void pbFinki_Click(object sender, EventArgs e)
        {
            category = new Category("finki");
            form2 = new Form2(this);
            form2.Show();
        }

        private void pbNature_Click(object sender, EventArgs e)
        {
            
            category = new Category("nature");
            form2 = new Form2(this);
            form2.Show();
        }

        private void pbSkopje_Click(object sender, EventArgs e)
        {
            
            category = new Category("skopje");
            form2 = new Form2(this);
            form2.Show();
        }
    }
}
