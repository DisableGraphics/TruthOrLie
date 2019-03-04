using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruthOrLie
{
    public partial class Form1 : Form
    {
        Random randm = new Random();

        bool escribirLabel = false;

        bool decirRespuesta = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            escribirLabel = true;

            decirRespuesta = false;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (escribirLabel == true && decirRespuesta == false)
            {
                

                int randomQuestion = randm.Next(1,21);

                if(randomQuestion == 1)
                {
                    label1.Text = "Do you have a moustache?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 2)
                {
                    label1.Text = "Do you wash your hands after going to the toilet?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 3)
                {
                    label1.Text = "What grades did you get at school?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 4)
                {
                    label1.Text = "Do you work at the Police?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 5)
                {
                    label1.Text = "Who is your best friend?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 6)
                {
                    label1.Text = "What is your favourite animal?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 7)
                {
                    label1.Text = "How many pet moustaches do you have?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 8)
                {
                    label1.Text = "What are you thinking?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 9)
                {
                    label1.Text = "Do you mind having a moustache?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 10)
                {
                    label1.Text = "Has anybody made something bad to you?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 11)
                {
                    label1.Text = "Who is your favourite youtuber?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 12)
                {
                    label1.Text = "Is Justin Bieber good at singing?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 13)
                {
                    label1.Text = "Is Microsoft Windows the best OS in the world?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 14)
                {
                    label1.Text = "Is the hamburguer the best food in the world?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 15)
                {
                    label1.Text = "Is Bill Gates a billionare?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 16)
                {
                    label1.Text = "What is your name?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 17)
                {
                    label1.Text = "Is electronic music your favourite music?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 18)
                {
                    label1.Text = "What is the best programming language in the world?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 19)
                {
                    label1.Text = "In this exact moment, how many 'bars' of the WiFi indicator do you have?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
                if (randomQuestion == 20)
                {
                    label1.Text = "Do you consider yourself a genius?";

                    decirRespuesta = true;

                    escribirLabel = false;
                }
            }
            if(decirRespuesta == true && textBox1.Text != "" && escribirLabel == false)
            {
                Random tf = new Random();

                textBox1.Text = "";

                int trueFalse = tf.Next(1,3);

                if(trueFalse == 1)
                {
                    label2.Text = "Correct!";

                    decirRespuesta = false;

                    trueFalse = 0;

                    escribirLabel = true;

                    
                }
                if (trueFalse == 2)
                {
                    label2.Text = "You are lying";

                    decirRespuesta = false;

                    trueFalse = 0;

                    escribirLabel = true;

                    
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
