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
            cb1.SelectedIndex = 0;
            cb1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            cb2.SelectedIndex = 0;
            cb2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;

        }
        
        private void bt1_Click(object sender, EventArgs e)
        {
            if (cb1.SelectedIndex == 0 && cb2.SelectedIndex == 0)
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

                        tbResult1.Text = (Convert.ToString(volumeOfRest) + " ml");
                        tbResult2.Text = (Convert.ToString(volumeOfAlcohol) + " ml");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("enter numbers only");
                    }
                }
            }
            else if (cb1.SelectedIndex != 0 && cb2.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(tbSize.Text) || String.IsNullOrEmpty(tbAmount.Text))
                {
                    MessageBox.Show("enter data");
                }
                else
                {
                    try
                    {

                        Double size = Convert.ToDouble(tbSize.Text);
                        Double contents = 0;
                        switch (cb1.SelectedIndex)
                        {
                            case 1:
                                contents = 5;
                                break;
                            case 2:
                                contents = 10;
                                break;
                            case 3:
                                contents = 12;
                                break;
                            case 4:
                                contents = 40;
                                break;
                            case 5:
                                contents = 16;
                                break;

                        }
                        int amount = Convert.ToInt32(tbAmount.Text);

                        double totalVolume = size * amount;
                        double volumeOfAlcohol = totalVolume * (contents / 100);
                        double volumeOfRest = totalVolume - volumeOfAlcohol;

                        tbResult1.Text = (Convert.ToString(volumeOfRest) + " ml");
                        tbResult2.Text = (Convert.ToString(volumeOfAlcohol) + " ml");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("enter numbers only");
                    }
                }
            }
            else if(cb1.SelectedIndex == 0 && cb2.SelectedIndex != 0)
            {
                if (String.IsNullOrEmpty(tbContents.Text) || String.IsNullOrEmpty(tbAmount.Text))
                {
                    MessageBox.Show("enter data");
                }
                else
                {
                    try
                    {

                        Double size = 0;
                        switch (cb2.SelectedIndex)
                        {
                            case 1:
                                size = 20;
                                break;
                            case 2:
                                size = 50;
                                break;
                            case 3:
                                size = 100;
                                break;
                            case 4:
                                size = 380;
                                break;
                            case 5:
                                size = 250;
                                break;
                            case 6:
                                size = 360;
                                break;
                            case 7:
                                size = 450;
                                break;
                            case 8:
                                size = 580;
                                break;

                        }
                        Double contents = Convert.ToDouble(tbContents.Text);
                        int amount = Convert.ToInt32(tbAmount.Text);

                        double totalVolume = size * amount;
                        double volumeOfAlcohol = totalVolume * (contents / 100);
                        double volumeOfRest = totalVolume - volumeOfAlcohol;

                        tbResult1.Text = (Convert.ToString(volumeOfRest) + " ml");
                        tbResult2.Text = (Convert.ToString(volumeOfAlcohol) + " ml");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("enter numbers only");
                    }
                }
            }
            else
            {
                if (String.IsNullOrEmpty(tbAmount.Text))
                {
                    MessageBox.Show("enter data");
                }
                else
                {
                    try
                    {

                        Double size = 0;
                        switch (cb2.SelectedIndex)
                        {
                            case 1:
                                size = 20;
                                break;
                            case 2:
                                size = 50;
                                break;
                            case 3:
                                size = 100;
                                break;
                            case 4:
                                size = 380;
                                break;
                            case 5:
                                size = 250;
                                break;
                            case 6:
                                size = 360;
                                break;
                            case 7:
                                size = 450;
                                break;
                            case 8:
                                size = 580;
                                break;

                        }
                        Double contents = 0;
                        switch (cb1.SelectedIndex)
                        {
                            case 1:
                                contents = 5;
                                break;
                            case 2:
                                contents = 10;
                                break;
                            case 3:
                                contents = 12;
                                break;
                            case 4:
                                contents = 40;
                                break;
                            case 5:
                                contents = 16;
                                break;

                        }
                        int amount = Convert.ToInt32(tbAmount.Text);

                        double totalVolume = size * amount;
                        double volumeOfAlcohol = totalVolume * (contents / 100);
                        double volumeOfRest = totalVolume - volumeOfAlcohol;

                        tbResult1.Text = (Convert.ToString(volumeOfRest) + " ml");
                        tbResult2.Text = (Convert.ToString(volumeOfAlcohol) + " ml");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("enter numbers only");
                    }
                }
            }

        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb1.SelectedIndex == 0)
            {
                tbContents.ReadOnly = false;
            }
            else
            {
                tbContents.ReadOnly = true;
            }
            
        }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb2.SelectedIndex == 0)
            {
                tbSize.ReadOnly = false;
            }
            else
            {
                tbSize.ReadOnly = true;
            }
        }
        //temp logic for both cb selected
        /*   private void bt2_Click(object sender, EventArgs e)
        {
            String choose1 = cb1.SelectedItem.ToString();
            String choose2 = cb2.SelectedItem.ToString();
            int selectedIndex = cb1.SelectedIndex;
            int selectedIndex2 = cb2.SelectedIndex;
            if (cb1.SelectedIndex == 3 && cb2.SelectedIndex >= 3)
            {
                MessageBox.Show("wybierz sposrod opcji do wodki tylko.");
                cb2.SelectedIndex = -1;
            }
        }*/
    }
}
