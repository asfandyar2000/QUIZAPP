using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : Form
    {

        //variables
        int cans;
        int qn =1;
        int score;
        int per;
        int tq;
        public Form1()
        {
            InitializeComponent();
            askQuestion(qn);
            tq = 8;
        }

      

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderobject = (Button)sender;
            int buttontag = Convert.ToInt32(senderobject.Tag);
            if (buttontag == cans)
            {
                score++;
            }

            if (qn == tq)
            {
                per = (int)Math.Round((double)(score * 100) / tq);
                MessageBox.Show("Quiz Ended!" + Environment.NewLine + "CONGRATATULATIONS!You have passed" + score + "questions correctly" + Environment.NewLine
                    + "Your percentage is" + per + "%" + Environment.NewLine + "click ok to play again");
                score = 0;
                qn = 0;
                askQuestion(qn);
            }
            qn++;
            askQuestion(qn);
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.ajk4;
                    question.Text = "Computer is a word of :";
                    button1.Text = "English";
                    button2.Text = "Punjabi";
                    button3.Text = "Latin";
                    button4.Text = "Spanish";
                    cans = 3;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.ajk2;
                    question.Text = "HTML is a :";
                    button1.Text = "Computer Language";
                    button2.Text = "English Language";
                    button3.Text = "Programming Language";
                    button4.Text = "None";
                    cans = 1;
                    break;
            
                case 3:
                    pictureBox1.Image = Properties.Resources.pakflag;
                    question.Text = "C is developed by:";
                    button1.Text = "asfand";
                    button2.Text = "Ali";
                    button3.Text = "Awais";
                    button4.Text = "Dennis";
                    cans = 4;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.offer1;
                    question.Text = "Bit stands for :";
                    button1.Text = "Binary";
                    button2.Text = "Bita";
                    button3.Text = "Binary digit";
                    button4.Text = "Binary technology";
                    cans = 3;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.thumbnail2;
                    question.Text = "Father of computer is:";
                    button1.Text = "Thomas";
                    button2.Text = "Charless";
                    button3.Text = "Herman";
                    button4.Text = "Von";
                    cans = 2;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.turkey;
                    question.Text = "Base of Decimal Number system is ";
                    button1.Text = "9";
                    button2.Text = "8";
                    button3.Text = "10";
                    button4.Text = "12";
                    cans = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.pak3;
                    question.Text = "In Hexadecimal, A=?";
                    button1.Text = "12";
                    button2.Text = "11";
                    button3.Text = "9";
                    button4.Text = "10";
                    cans = 2;
                    break;
            }
          
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
