using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toc_Game.Properties;

namespace Tic_Tac_Toc_Game
{
    public partial class Form1 : Form
    {

        int counter = 1;


        string Image1;
        string Image2;
        string Image3;
        string Image4;
        string Image5;
        string Image6;
        string Image7;
        string Image8;
        string Image9;


        bool visitPicture1 = false;
        bool visitPicture2 = false;
        bool visitPicture3 = false;
        bool visitPicture4 = false;
        bool visitPicture5 = false;
        bool visitPicture6 = false;
        bool visitPicture7 = false;
        bool visitPicture8 = false;
        bool visitPicture9 = false;
        

        public Form1()
        {
            InitializeComponent();
        }


        bool checkIfTheGameEnd()
        {
            if (visitPicture1 == true && visitPicture2 == true &&
                visitPicture3 == true && visitPicture4 == true &&
                visitPicture5 == true && visitPicture6 == true &&
                visitPicture7 == true && visitPicture8 == true &&
                visitPicture9 == true)
                return true;
            else
                return false;
        }
        bool checkIfTheGameEndWithWinner()
        {
            if (Image1 == "X" && Image2 == "X" && Image3 == "X" ||
                Image4 == "X" && Image5 == "X" && Image6 == "X" ||
                Image7 == "X" && Image8 == "X" && Image9 == "X" ||

                Image1 == "X" && Image4 == "X" && Image7 == "X" ||
                Image2 == "X" && Image5 == "X" && Image8 == "X" ||
                Image3 == "X" && Image6 == "X" && Image9 == "X" ||

                Image1 == "X" && Image5 == "X" && Image9 == "X" ||
                Image3 == "X" && Image5 == "X" && Image7 == "X"
                )
            {
                lblResult.Text = "Player1 Win";
                gbPictures.Enabled = false;
                return true;
            }
            else if (Image1 == "O" && Image2 == "O" && Image3 == "O" ||
                     Image4 == "O" && Image5 == "O" && Image6 == "O" ||
                     Image7 == "O" && Image8 == "O" && Image9 == "O" ||

                     Image1 == "O" && Image4 == "O" && Image7 == "O" ||
                     Image2 == "O" && Image5 == "O" && Image8 == "O" ||
                     Image3 == "O" && Image6 == "O" && Image9 == "O" ||

                     Image1 == "O" && Image5 == "O" && Image9 == "O" ||
                     Image3 == "O" && Image5 == "O" && Image7 == "O"
                )
            {
                lblResult.Text = "Player2 Win";
                gbPictures.Enabled = false;
                return true;
            }
            
            else
                return false;
           

        }
        bool checkIfPlayer1()
        {
            counter++;
            if (counter%2==0)
                return true;
            else
                return false;
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen Pen = new Pen(White, 8);

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 300, 200, 600, 200);
            e.Graphics.DrawLine(Pen, 300, 300, 600, 300);

            e.Graphics.DrawLine(Pen, 400, 100, 400,400);
            e.Graphics.DrawLine(Pen, 500, 100, 500, 400);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (visitPicture1 == true)
            {
                MessageBox.Show("Wrong game!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkIfPlayer1())
            {
                lblPlayer.Text = "Player1";
                pictureBox1.Image = Resources.X;
                Image1 = "X";
                visitPicture1 = true;
            }
            else
            {
                lblPlayer.Text = "Player2";
                pictureBox1.Image = Resources.O;
                Image1= "O";
                visitPicture1 = true;
            }
            if (checkIfTheGameEndWithWinner())
            {
                MessageBox.Show("Game Over");
            }
            if(checkIfTheGameEnd())
            {
                MessageBox.Show("Game Over");
                lblResult.Text = "Draw";
            }



        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (visitPicture2 == true)
            {
                MessageBox.Show("Wrong game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkIfPlayer1())
            {
                lblPlayer.Text = "Player1";
                pictureBox2.Image = Resources.X;
                Image2 = "X";
                visitPicture2 = true;
            }
            else
            {
                lblPlayer.Text = "Player2";
                pictureBox2.Image = Resources.O;
                Image2 = "O";
                visitPicture2 = true;
            }
            if (checkIfTheGameEndWithWinner())
            {
                MessageBox.Show("Game Over");

            }
            if (checkIfTheGameEnd())
            {
                MessageBox.Show("Game Over");
                lblResult.Text = "Draw";
            }

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (visitPicture3 == true)
            {
                MessageBox.Show("Wrong game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkIfPlayer1())
            {
                lblPlayer.Text = "Player1";
                pictureBox3.Image = Resources.X;
                Image3 = "X";
                visitPicture3 = true;
            }
            else
            {
                lblPlayer.Text = "Player2";
                pictureBox3.Image = Resources.O;
                Image3 = "O";
                visitPicture3 = true;
            }
            if (checkIfTheGameEndWithWinner())
            {
                MessageBox.Show("Game Over");

            }
            if (checkIfTheGameEnd())
            {
                MessageBox.Show("Game Over");
                lblResult.Text = "Draw";
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (visitPicture4 == true)
            {
                MessageBox.Show("Wrong game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkIfPlayer1())
            {
                lblPlayer.Text = "Player1";
                pictureBox4.Image = Resources.X;
                Image4 = "X";
                visitPicture4 = true;
            }
            else
            {
                lblPlayer.Text = "Player2";
                pictureBox4.Image = Resources.O;
                Image4 = "O";
                visitPicture4 = true;
            }
            if (checkIfTheGameEndWithWinner())
            {
                MessageBox.Show("Game Over");

            }
            if (checkIfTheGameEnd())
            {
                MessageBox.Show("Game Over");
                lblResult.Text = "Draw";
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (visitPicture5 == true)
            {
                MessageBox.Show("Wrong game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkIfPlayer1())
            {
                lblPlayer.Text = "Player1";
                pictureBox5.Image = Resources.X;
                Image5 = "X";
                visitPicture5 = true;
            }
            else
            {
                lblPlayer.Text = "Player2";
                pictureBox5.Image = Resources.O;
                Image5 = "O";
                visitPicture5 = true;
            }
            if (checkIfTheGameEndWithWinner())
            {
                MessageBox.Show("Game Over");

            }
            if (checkIfTheGameEnd())
            {
                MessageBox.Show("Game Over");
                lblResult.Text = "Draw";
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (visitPicture6 == true)
            {
                MessageBox.Show("Wrong game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkIfPlayer1())
            {
                lblPlayer.Text = "Player1";
                pictureBox6.Image = Resources.X;
                Image6 = "X";
                visitPicture6 = true;
            }
            else
            {
                lblPlayer.Text = "Player2";
                pictureBox6.Image = Resources.O;
                Image6 = "O";
                visitPicture6 = true;
            }
            if (checkIfTheGameEndWithWinner())
            {
                MessageBox.Show("Game Over");

            }
            if (checkIfTheGameEnd())
            {
                MessageBox.Show("Game Over");
                lblResult.Text = "Draw";
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (visitPicture7 == true)
            {
                MessageBox.Show("Wrong game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkIfPlayer1())
            {
                lblPlayer.Text = "Player1";
                pictureBox7.Image = Resources.X;
                Image7  = "X";
                visitPicture7 = true;
            }
            else
            {
                lblPlayer.Text = "Player2";
                pictureBox7.Image = Resources.O;
                Image7 = "O";
                visitPicture7 = true;
            }
            if (checkIfTheGameEndWithWinner())
            {
                MessageBox.Show("Game Over");

            }
            if (checkIfTheGameEnd())
            {
                MessageBox.Show("Game Over");
                lblResult.Text = "Draw";
            }
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (visitPicture8 == true)
            {
                MessageBox.Show("Wrong game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkIfPlayer1())
            {
                lblPlayer.Text = "Player1";
                pictureBox8.Image = Resources.X;
                Image8 = "X";
                visitPicture8 = true;
            }
            else
            {
                lblPlayer.Text = "Player2";
                pictureBox8.Image = Resources.O;
                Image8 = "O";
                visitPicture8 = true;
                
            }
            if (checkIfTheGameEndWithWinner())
            {
                MessageBox.Show("Game Over");

            }
            if (checkIfTheGameEnd())
            {
                MessageBox.Show("Game Over");
                lblResult.Text = "Draw";
            }
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (visitPicture9 == true)
            {
                MessageBox.Show("Wrong game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkIfPlayer1())
            {
                lblPlayer.Text = "Player1";
                pictureBox9.Image = Resources.X;
                Image9 = "X";
                visitPicture9 = true;
            }
            else
            {
                lblPlayer.Text = "Player2";
                pictureBox9.Image = Resources.O;
                Image9 = "O";
                visitPicture9 = true;
             
            }
            if (checkIfTheGameEndWithWinner())
            {
                MessageBox.Show("Game Over");

            }
            if (checkIfTheGameEnd())
            {
                MessageBox.Show("Game Over");
                lblResult.Text = "Draw";
            }
        }
        
        
        
        private void bRefresh_Click(object sender, EventArgs e)
        {
            counter = 1;

            pictureBox1.Image = Resources.question_mark_96;
            pictureBox2.Image = Resources.question_mark_96;
            pictureBox3.Image = Resources.question_mark_96;
            pictureBox4.Image = Resources.question_mark_96;
            pictureBox5.Image = Resources.question_mark_96;
            pictureBox6.Image = Resources.question_mark_96;
            pictureBox7.Image = Resources.question_mark_96;
            pictureBox8.Image = Resources.question_mark_96;
            pictureBox9.Image = Resources.question_mark_96;

            lblResult.Text = "In Progress";
            lblPlayer.Text = "Player";
            gbPictures.Enabled = true;
            Image1 = "Q";
            Image2 = "Q";
            Image3 = "Q";
            Image4 = "Q";
            Image5 = "Q";
            Image6 = "Q";
            Image7 = "Q";
            Image8 = "Q";
            Image9 = "Q";

            visitPicture1 = false;
            visitPicture2 = false;
            visitPicture3 = false;
            visitPicture4 = false;
            visitPicture5 = false;
            visitPicture6 = false;
            visitPicture7 = false;
            visitPicture8 = false;
            visitPicture9 = false;
        }
    }
}
