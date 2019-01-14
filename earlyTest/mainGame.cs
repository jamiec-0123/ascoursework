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
    public partial class mainGame : Form
    {
        bool goDown, goUp, goLeft, goRight;
        int playerSpeed = 65;
        int speed = 5;

        public mainGame()
        {
            InitializeComponent();
            gameUpTime.Start();

        } 

        private void gameUpTime_Tick(object sender, EventArgs e)
        {

            if (goDown && goLeft)
                {
                    player.Top += playerSpeed;
                    player.Left -= playerSpeed;
                }
                else if (goDown && goRight )
                {
                    player.Top += playerSpeed;
                    player.Left += playerSpeed;
                }
                else if (goUp && goRight )
                {
                    player.Top -= playerSpeed;
                    player.Left += playerSpeed;
                }
                else if (goUp && goLeft )
                {
                    player.Top -= playerSpeed;
                    player.Left -= playerSpeed;
                }
                else if (goLeft )
                {
                    player.Left -= playerSpeed;
                }
                else if (goRight)
                {
                    player.Left += playerSpeed;
                }
                else if (goUp)
                {
                    player.Top -= playerSpeed;
                }
                else if (goDown)
                {
                    player.Top += playerSpeed;
                }
            
        }


        private void mainGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void mainGame_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
        }




      

        private void mainGame_Load(object sender, EventArgs e)
        {
        }

        private void player_Click(object sender, EventArgs e)
        {
            gameUpTime.Start();

        }


    }
}
