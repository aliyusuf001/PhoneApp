using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FmHomePage : Form
    {
        public FmHomePage()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // get the raw numbers as text
            // process them

            string getUserNumbers = txtUsersNumbers.Text;

            string[] numbers;
            char[] splitTheNumber = { ' ', '+', ',', '.'};

            numbers = getUserNumbers.Split(splitTheNumber);
            
            // Using the variable below to get the total number of Phone numbers that are in correct format 
            int y = 0;
            
            for (int x = 0; x < numbers.Length; x++)
            {
                string checkNumber = "";
                checkNumber = numbers[x];  

                if (checkNumber.Length != 11)
                {
                    numbers[x] = "";
                }
                else if(checkNumber[0] != '0')
                {
                    numbers[x] = "";
                }
                else
                {
                    txtProcessedOutput.Text += numbers[x] + " ";
                    y++;
                }
            }
            txtTotalNumber.Text += y;
            
            //display the output in the second textbox!!!!!!!!!!!
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FmHomePage_Load(object sender, EventArgs e)
        {

        }

        private void lblTotalNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
