using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        int counter = 0;
        int len = 0;
        string txt;

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            txt = welcomeText3.Text;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            len = txt.Length;
            welcomeText3.Text = "";
            counter++;
            if(counter > len)
            {
                counter = 0;
                welcomeText3.Text = "";
            }
            else
            {
                
                welcomeText3.Text = txt.Substring(0, counter);
            }
        }
    }
}
