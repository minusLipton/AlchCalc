using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlchCalc

    /*
     * Zrobiłem coś musisz mi napisać jak masz zastrzeżenia do comboboxów, nie wiedzialem co mam wpiszać
     * wpadłem na pomysł, ale pewnie wiecej roboty bedzie, że jak wybierze sie białe wino to masz tylko kieliszki do bialego wina
     * ale nie wiem czy to nie za ambitne :) 19.10.2024 13:30
     * */
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSize.Text) || String.IsNullOrEmpty(tbContents.Text) || String.IsNullOrEmpty(tbAmount.Text))
            {
                MessageBox.Show("enter data");
            }
            else
            {
                try
                {

                    Double size = Convert.ToDouble(tbSize.Text);
                    Double contents = Convert.ToDouble(tbContents.Text);
                    int amount = Convert.ToInt32(tbAmount.Text);

                    double totalVolume = size * amount;
                    double volumeOfAlcohol = totalVolume * (contents / 100);
                    double volumeOfRest = totalVolume - volumeOfAlcohol;

                    tbResult1.Text = (Convert.ToString(volumeOfRest)+" ml");
                    tbResult2.Text = (Convert.ToString(volumeOfAlcohol) + " ml");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("enter numbers only");
                }
            }
        }
    }
}
