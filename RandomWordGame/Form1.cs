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
        public Form1()
        {
            InitializeComponent();
            tmr.Start ();
            int timer = Int32.Parse(lable4.Text);

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

        private void button11_Click(object sender, EventArgs e)
        {
            bool click = true;
            if(click)
            {
                
                
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
