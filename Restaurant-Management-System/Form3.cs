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
        public static string SetValueForText1;
        public static string reserveColor;
        public Form3()
        {
            InitializeComponent();
        }
        
        private void TableFunc()
        {
            int tableNo = Convert.ToInt32(tableComboBox.Text);
            SetValueForText1 = tableNo.ToString();
        }

        

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
        
            reserveColor = "Red";
            if(tableComboBox.Text == "")
            {
                MessageBox.Show("Please Select Table No first :)");
            }
            else
            {
            TableFunc();
            new Form2().Show();
            this.Hide();
            }
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            reserveColor = "Yellow";
            if (tableComboBox.Text == "")
            {
                MessageBox.Show("Please Select Table No first :)");
            }
            else
            {
                TableFunc();
                new Form2().Show();
                this.Hide();
            }
        }

        private void tableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
