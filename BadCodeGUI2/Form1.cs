using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadCodeGUI2
{
    public partial class Form1 : Form
    {

        private int timePassed;
        private string[] enemies = new string[] {
            "hackers", "spies", "monsters", "supervillains", "conmans"};
        private string[] actions = new string[]
        {
            "detected", "distracted", "trapped in eternal time-stop", "teleported", "convinced that this job isn't worth it"
        };
        Random rng;
        public Form1()
        {
            InitializeComponent();
            timePassed = 0;
            rng = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("")) {
                label1.Text = "Por hacer trampa estás siendo rastreado";
            } else
            {
                label1.Text = "Mucho gusto, estás siendo rastreado";
            }
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "1 spy stopped";
            timePassed = 2;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.Text =  timePassed + " " + enemies[rng.Next(0, 4)] + " " + actions[rng.Next(0, 4)];
            timePassed++;
        }
    }
}
