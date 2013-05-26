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

        private void pbAnimals_Click(object sender, EventArgs e)
        {
            CreateNewCategory("animals");
        }

        private void pbFinki_Click(object sender, EventArgs e)
        {
            CreateNewCategory("finki");
        }

        private void pbNature_Click(object sender, EventArgs e)
        {
            CreateNewCategory("nature");
        }

        private void pbSkopje_Click(object sender, EventArgs e)
        {
            CreateNewCategory("skopje");      
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
                Application.Exit();
        }

        private void btnInstr_Click(object sender, EventArgs e)
        {            
            MessageBox.Show(String.Format("\t\t\tInstructions:\n  Point and click on the differences between two pictures as fast as you can.\n\tRemember! Each wrong click will reduce the time left."));
        }

        private void pbAnimals_MouseEnter(object sender, EventArgs e)
        {
            lbSelect.Text = "Animals";
        }

        private void pbFinki_MouseEnter(object sender, EventArgs e)
        {
            lbSelect.Text = "FINKI";
        }

        private void pbNature_MouseEnter(object sender, EventArgs e)
        {
            lbSelect.Text = "Nature";
        }

        private void pbSkopje_MouseEnter(object sender, EventArgs e)
        {
            lbSelect.Text = "Skopje";
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            lbSelect.Text = "";
        }

        private void CreateNewCategory(String categoryName)
        {
            category = new Category(categoryName);
            form2 = new Form2(this);
            form2.Show();
        }
		// da vidime dali ke mi dade deka treba da se komitira...
    }
}
