using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
        private int timeleft;
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
        
        private void tmr_Tick(object sender, EventArgs e)
        {
            if(timeleft > 0)
            {
                timeleft = timeleft - 1;
                int secondsleft = timeleft % 60;
                int minsleft = timeleft / 60;
                textBox1.Text   = minsleft.ToString()  +" : "+ secondsleft.ToString();
                
            }
            else
            {
                tmr.Stop();
                textBox1.Text = "Time up";
            }
        }

        
        // buttons for the letters
        public void Multibuttonclick(object sender, EventArgs e)
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
            
            string[] totalseconds = textBox1.Text.Split(':');
            int mins = Convert.ToInt32(totalseconds[0]);
            int seconds = Convert.ToInt32(totalseconds[1]);
            timeleft = (mins * 60) + seconds;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();

            StreamReader file = new StreamReader("C:\\Users\\231730\\source\\repos\\RandomWordGame\\RandomWordGame\\Resources\\ukenglish.txt");
            int counter = 0;
            bool clicked = true;
            if(clicked)
            {
                button1.Text = "Enter";
                button1.BackColor= Color.DarkGray;    
            }
            if(button1.Text == "Enter" && button1.BackColor == Color.DarkGray)
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    if (string.Equals(finalWord, ln, StringComparison.OrdinalIgnoreCase))
                    {
                        int pts = int.Parse(label2.Text);
                        pts = pts + 1;
                        break;
                    }
                    counter++;
                }
            }

        }

        // delete button
        private void button11_Click(object sender, EventArgs e)
        {
            RichTextBox[] display = { richTextBox1, richTextBox2, richTextBox3, richTextBox4, richTextBox5, richTextBox6, richTextBox7 };
            for (int i = 0; i < display.Length; i++) 
            {
                display[i].Clear();
                
            }
            bool cleared = true;
            if(cleared)
            {
                boxCount = 0;
            }
            

        }
    }
}
