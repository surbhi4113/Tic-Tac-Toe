using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private string ch = "O";
 
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_quit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_start(object sender, EventArgs e)
        {
            Start();
        }
        private void Start()
        {
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = true;
            button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
            button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor =Color.Gray;
        }

        private void ShowXorO(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "")
            {
                btn.Text = ch = (ch == "O") ? "X" : "O";
                if (Winner())
                {
                    MessageBox.Show(btn.Text +" "+"Is A Winner !","Congratulations");
                    Start();
                }
                else if (Draw())
                {
                    MessageBox.Show("it's Draw!","Game Over");
                    Start();
                }
            }
               
        }


       //123 456 789 147 258 369 159 357 Possiblity 
        private bool Winner()
        {
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text))
            {
                if (button1.Text != string.Empty)
                { 
                    return true;
                }
            }

            if ((button4.Text == button5.Text) && (button5.Text == button6.Text))
            {
                if (button4.Text != string.Empty)
                {
                 
                    return true;
                }
            }

            if ((button7.Text == button8.Text) && (button8.Text == button9.Text))
            {
                if (button7.Text != string.Empty)
                {
                   
                    return true;
                }
            }

            if ((button1.Text == button4.Text) && (button4.Text == button7.Text))
            {
                if (button1.Text != string.Empty)
                {
                    
                    return true;
                }
            }


            if ((button2.Text == button5.Text) && (button5.Text == button8.Text))
            {
                if (button2.Text != string.Empty)
                {
                    return true;
                }
            }


            if ((button3.Text == button6.Text) && (button6.Text == button9.Text))
            {
                if (button3.Text != string.Empty)
                {
                    return true;
                }
            }


            if ((button1.Text == button5.Text) && (button5.Text == button9.Text))
            {
                if (button1.Text != string.Empty)
                { 
                    return true;
                }
            }


            if ((button3.Text == button5.Text) && (button5.Text == button7.Text))
            {
                if (button3.Text != string.Empty)
                {
                    return true;
                }
            }
            return false;

        }
        private bool Draw()
        {
            return button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "" && !Winner();
        }

      

        
    }
}
