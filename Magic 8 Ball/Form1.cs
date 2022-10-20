using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_8_Ball
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        double question;
        public Form1()
        {
            InitializeComponent();
            question = randGen.Next(1,4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (question == 1)
            {
                questionLabel.Text = "Yes";
            }

            else if (question > 2)
            {
                questionLabel.Text = "No";
            }

            else
            {
                questionLabel.Text = "Maybe";
            }
        }
    }
}
