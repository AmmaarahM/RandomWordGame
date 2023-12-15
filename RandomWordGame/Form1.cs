using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWordGame
{
    public partial class Form1 : Form
    {
        List <string> wordlist = new List <string> ();
        int boxCount = 0;
        string finalWord = "";
        public Form1()
        {
            InitializeComponent();
            button2.Text = randomletter().ToString();
            button3.Text = randomletter().ToString();
            button4.Text = randomletter().ToString();
            button5.Text = randomletter().ToString();
            button6.Text = randomletter().ToString();
            button7.Text = randomletter().ToString();
            button8.Text = randomletter().ToString();
            button9.Text = randomletter().ToString();
            button10.Text = randomletter().ToString();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("C:\\Users\\231730\\source\\repos\\RandomWordGame\\RandomWordGame\\Resources\\ukenglish.txt");
            string ln;
            while((ln = file.ReadLine()) != null)
            {
                if(ln.Length > 2 && ln.Length < 9)
                { wordlist.Add (ln); }
            }
            file.Close();
            
            

        }

        Random rand = new Random();
        private char randomletter()
        {
            int number = rand.Next(0, 26);
            char letter = (char)('a' + number);
            return letter;
           
        }
        int timeleft = 5;
        private void tmr_Tick(object sender, EventArgs e)
        {
            if(timeleft > 0)
            {
                timeleft = 0;
                label4.Text = timeleft + "Mins";
            }
            else
            {
                tmr.Stop();
                label4.Text = "Time up";
            }
        }

        

        void Multibuttonclick(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            RichTextBox[] display = { richTextBox1, richTextBox2, richTextBox3, richTextBox4, richTextBox5, richTextBox6, richTextBox7 };
            int i = boxCount;
            
                if (button == button2 && boxCount<7)
                { display[i].Text = button2.Text;
                finalWord = finalWord + button2.Text; }

                else if (button == button3 && boxCount < 7)
                { display[i].Text = button3.Text;
                finalWord = finalWord + button2.Text; }

                else if (button == button4 && boxCount < 7)
                { display[i].Text = button4.Text; }

                else if (button == button5 && boxCount < 7)
                { display[i].Text = button5.Text;
                finalWord = finalWord + button2.Text; }

                else if (button == button6 && boxCount < 7)
                { display[i].Text = button6.Text;
                finalWord = finalWord + button2.Text; }

                else if (button == button7 && boxCount < 7)
                { display[i].Text = button7.Text;
                finalWord = finalWord + button2.Text; }

                else if (button == button8 && boxCount < 7)
                { display[i].Text = button8.Text;
                finalWord = finalWord + button2.Text; }
        
                else if (button == button9 && boxCount < 7)
                { display[i].Text = button9.Text;
                finalWord = finalWord + button2.Text; }

                else if (button == button10 && boxCount < 7)
                { display[i].Text = button10.Text;
                finalWord = finalWord + button2.Text; }

            boxCount++;
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            tmr.Start();
            bool clicked = true;
            if(clicked)
            {
                button1.Text = "Enter";
                button1.BackColor= Color.DarkGray;
                Button delete = new Button();
                
               
            }

            else
            {
                button1 = new Button();
                bool clickedsecond = true;
                if (clickedsecond)
                {
                    int counter = 0;
                    while (!wordlist.Contains(finalWord))
                    { counter++; }

                }
            }

        }
    }
}
