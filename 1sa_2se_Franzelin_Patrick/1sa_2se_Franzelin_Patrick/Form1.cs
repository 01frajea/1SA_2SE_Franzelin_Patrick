using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1sa_2se_Franzelin_Patrick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void autobtn_Click(object sender, EventArgs e)
        {   string tankgröße, marke, ps, verbrauch;
            
            switch (farbebox.Text)
            {
                    

                case "rot":
                    TextBox1.Text += "Farbe: rot \n";
                    break;
                case "schwarz":
                    TextBox1.Text += "Farbe: schwarz\n";
                    break;
                case "weis":
                    TextBox1.Text += "Farbe: weis\n";
                    break;
                case "blau":
                    TextBox1.Text += "Farbe: blau\n";
                    break;
                case "gelb":
                    TextBox1.Text += "Farbe: gelb\n";
                    break;

            }
            tankgröße = tankgrößelbl.Text;
            marke = Markelbl.Text;
            ps = pslbl.Text;
            verbrauch = Verbrauchlbl.Text;         
            TextBox1.Text += "Tankgröße" + tankgröße + "\n marke:" + marke + "\n ps:" + ps;

        }

        private void tankenbtn_Click(object sender, EventArgs e)
        {
            int tankinhalt;

           tankinhalt =


        }
       
    }




}

