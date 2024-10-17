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
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //temp
            Double size = 30;
            Double contents = 14;
            int amount = 2;
            //Double size = Convert.ToDouble(tbSize.Text);
            //Double contents = Convert.ToDouble(tbContents.Text);
            //int amount = Convert.ToInt32(tbAmount.Text);


            double totalVolume = size * amount;
            double volumeOfAlcohol = totalVolume * (contents / 100);
            double volumeOfRest = totalVolume - volumeOfAlcohol;

            
            //Console.WriteLine($"Volume of alcohol: {volumeOfAlcohol} ml");
            //Console.WriteLine($"Volume of the rest of the drink: {volumeOfRest} ml");

            tbSize.Text = volumeOfAlcohol.ToString();
            tbContents.Text = volumeOfRest.ToString();
            

        }
    }
}
