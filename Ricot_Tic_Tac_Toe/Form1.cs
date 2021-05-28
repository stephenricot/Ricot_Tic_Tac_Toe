using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ricot_Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = X turn; false = Y turn
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void click_exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void click_box(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
        }

        private void click_res(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
