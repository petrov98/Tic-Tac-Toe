using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Toe
{
    public partial class Form1 : Form
    {
        bool OnePlayer = false;
        bool TwoPlayer = false;
        int length = 9;
        List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] listOFButtons = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public void AI()
        {

        }
        public Form1()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            button1.Text = string.Empty;
            button2.Text = string.Empty;
            button3.Text = string.Empty;
            button4.Text = string.Empty;
            button5.Text = string.Empty;
            button6.Text = string.Empty;
            button7.Text = string.Empty;
            button8.Text = string.Empty;
            button9.Text = string.Empty;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled =false;
            button8.Enabled = false;
            button9.Enabled = false;
            list = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            button10.Enabled = true;
            button11.Enabled = true;
            OnePlayer = false; TwoPlayer = false;
            length = 9;
            count = 0;

        }
        string winnerTag;
        public void DoSmth(Button button)
        {
            if (count % 2 == 0)
            {
                button.Text = "X";

            }
            else
            {
                button.Text = "O";
            }
            button.Enabled = false;
            count++;
            CheckforWinner();
        }

        int count = 0;
       

        private void CheckforWinner()
        {
            bool winner = false;
            if ((button1.Text == button2.Text) && (button1.Text == button3.Text))
            {
                if (button1.Text == "O" || button1.Text == "X")
                {
                    winnerTag = button1.Text;
                    winner = true;
                }
            }
            if ((button4.Text == button5.Text) && (button4.Text == button6.Text))
            {
                if (button4.Text == "O" || button4.Text == "X")
                {
                    winnerTag = button4.Text;
                    winner = true;
                }

            }
            if ((button7.Text == button8.Text) && (button7.Text == button9.Text))
            {
                if ((button7.Text == "O" || button7.Text == "X"))
                {
                    winnerTag = button7.Text;
                    winner = true;
                }
            }
            if ((button1.Text == button4.Text) && (button1.Text == button7.Text))
            {
                if (button1.Text == "O" || button1.Text == "X")
                {
                    winnerTag = button1.Text;
                    winner = true;
                }
            }
            if ((button3.Text == button6.Text) && (button9.Text == button3.Text))
            {
                if (button3.Text == "O" || button3.Text == "X")
                {
                    winnerTag = button3.Text;
                    winner = true;
                }
            }
            if ((button5.Text == button2.Text) && (button2.Text == button8.Text))
            {
                if (button2.Text == "O" || button2.Text == "X")
                {
                    winnerTag = button2.Text;
                    winner = true;
                }
            }
            if ((button1.Text == button5.Text) && (button1.Text == button9.Text))
            {
                if (button1.Text == "O" || button1.Text == "X")
                {
                    winnerTag = button1.Text;
                    winner = true;
                }
            }
            if ((button3.Text == button5.Text) && (button7.Text == button5.Text))
            {
                if (button3.Text == "O" || button3.Text == "X")
                {
                    winnerTag = button3.Text;
                    winner = true;
                }
            }
            if (winner == true)
            {
                DialogResult result;
                if (winnerTag == "O")
                {
                    DialogResult result1 = MessageBox.Show("The winner is player with O.Do you want to play again?",
        "Good Game",
        MessageBoxButtons.YesNo);
                    result = result1;
                }
                else
                {
                    DialogResult result1 = MessageBox.Show("The winner is player with X.Do you want to play again?",
                            "Good Game",
                            MessageBoxButtons.YesNo);
                    result = result1;
                }
                if (result == DialogResult.Yes)
                {
                    Reset();
                }
                else
                {
                    this.Close();
                }
            }
            if (count == 9)
            {
                DialogResult result1 = MessageBox.Show("Do you want to play again",
                            "Draw",
                            MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    Reset();
                }
                else
                {
                    this.Close();
                }
            }

        }

        public void EnableAllButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DoSmth(button1);
           // removeElement(listOFButtons, 1);
            list.Remove(1);
            length--;
            RandomButton();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            DoSmth(button2);
          //  listOFButtons = removeElement(listOFButtons, 2);
            list.Remove(2);
            length--;
            RandomButton();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DoSmth(button3);
           // listOFButtons=removeElement(listOFButtons, 3);
            list.Remove(3);
            length--;
            RandomButton();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DoSmth(button4);
            list.Remove(4);
            length--;
            RandomButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DoSmth(button5);
            list.Remove(5);
            length--;
           
            RandomButton();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            DoSmth(button6);
            list.Remove(6);
            length--;
            RandomButton();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            DoSmth(button7);
            list.Remove(7);
            length--;
            RandomButton();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            DoSmth(button8);
            list.Remove(8);
            length--;
            RandomButton();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            DoSmth(button9);
            list.Remove(9);
            length--;
            RandomButton();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EnableAllButtons();
            button11.Enabled = false;
            button10.Enabled = false;
            OnePlayer = true;
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            EnableAllButtons();
            button10.Enabled = false;
            button11.Enabled = false;
            TwoPlayer = true;
            
        }
        public void RandomButton()
        {
            if (OnePlayer == true)
            {
                if (count % 2 == 1)
                {
                    Random randomNum = new Random();
                    var arr=list.ToArray();
                    int rndNum = randomNum.Next(0,arr.Length-1);
                    int m = list[rndNum];
                    Button btn = new Button();


                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is Button && ctrl.Name == "button" + m.ToString())
                        {
                            btn = (Button)(ctrl);
                            break;
                        }
                    }

                    btn.PerformClick();
                }
                
            }
        }
        public int[] removeElement(int[] arr, int ele)
        {


            arr = arr.Except(new int[] {ele }).ToArray();
            return arr;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
      }           
 }
        