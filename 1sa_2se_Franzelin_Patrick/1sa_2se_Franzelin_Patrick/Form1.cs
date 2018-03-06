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
        int tankinhalt = 0;
        string gefahrenekm;
 
        public Form1()
        {
            InitializeComponent();
           
        }
        
        private void fahrenbtn_Click(object sender, EventArgs e)
        {
            ausfahren.Text = "";
            gefahrenekm = fahrenlbl.Text;
            ausfahren.Text = "gefahrene km:"+gefahrenekm.ToString();
        }
        private void autobtn_Click(object sender, EventArgs e)
        {   string tankgröße, marke, ps, verbrauch;

        TextBox1.Text = "";

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
            progressBar1.Maximum = Convert.ToInt32(tankgrößelbl.Text);
            austanken.Text = "";
            tankinhalt = Convert.ToInt32(tankenlbl.Text);
            progressBar1.Value = progressBar1.Value + tankinhalt;
            austanken.Text = "Tankihnhalt:" + tankinhalt.ToString();

        }
        

      
       
    }




}

