using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace earlyTest
{
    public partial class Form2 : Form
    {
        public Form2(bool teacher)
        {
            if (teacher == true)
            {InitializeComponent();
                quitBTN.Location = new Point(218, 410);
                teacherBTN.Visible= true;
            }
            else
            {
            InitializeComponent();
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
 
        }

        private void quitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startGameBTN_Click(object sender, EventArgs e)
        {

        }

        private void highscoreBTN_Click(object sender, EventArgs e)
        {

        }

        private void teacherBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
