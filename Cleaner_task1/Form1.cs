using System.IO;
using System.Windows.Forms;

namespace Cleaner_task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Visible = false;
            MainLabel.Parent = pictureBox1;
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            buttonOpenCleaner.Parent = pictureBox1;
            MainLabel.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            buttonOpenCleaner.BackColor = Color.Transparent;
            progressBar1.ForeColor = Color.Red;
        }

        private void buttonOpenCleaner_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;


            while (progressBar1.Value != 100)
            {
                progressBar1.Value += 10;
                Thread.Sleep(1000);
                progressBar1.Value += 10;
            }

            progressBar1.Visible = false;
            buttonOpenCleaner.Text = "Open application";
            FormCleaner cleaner = new FormCleaner();

            cleaner.ShowDialog();


        }


    }
}