using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void convert_btn_click(object sender, EventArgs e)
        {

            if (amountTaka.Text == "" || convertToCombo.SelectedItem == null)
            {

                error.Text = "Please check all inputs";   //error message for null inputs
            }

            else
            {
                error.Text = "";

                int inputAmount = int.Parse(amountTaka.Text);    //input Taka

                string convertTo = (string)convertToCombo.SelectedItem;  //input convert to

                double convertedAmount = 0.00;





                switch (convertTo)
                {
                    case "Rupee":

                        convertedAmount = inputAmount * 0.862361;


                        break;
                    case "USD":
                        convertedAmount = inputAmount * 0.0117905;

                        break;

                    case "Euro":

                        convertedAmount = inputAmount * 0.00990342;

                        break;

                    case "Canadian dollar":
                        convertedAmount = inputAmount * 0.0154433;

                        break;

                    case "Austrailan dollar":
                        convertedAmount = inputAmount * 0.0160038;

                        break;
                }






                textBox_Result.Text = convertedAmount.ToString();  //update result in front end



            }
        }


        //reset input fields

        private void resetBtn_Click(object sender, EventArgs e)
        {
            amountTaka.Text = "";
            convertToCombo.Text = null;
            textBox_Result.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void amountTaka_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
