using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betRace
{
    public partial class Form1 : Form 
    {
        public int maxBetPrice;
        Decimal carNum1, carNum2, carNum3;
        Decimal betPrice1, betPrice2, betPrice3;
        public int Cash1, Cash2, Cash3;
        bool bPlaced = false;
        int betCount = 0 ;
     // Creating Object for All Punter classes to use their attributes

        Punter puntObj = new Punter();
        Joe joeObj = new Joe();
        Bob bobObj = new Bob();
        AI aiObj = new AI();

        public Form1()
        {
          //Initializing required variable in this scope 
            InitializeComponent();
            this.carNum1 = 0;
            this.carNum2 = 0;
            this.carNum3 = 0;

            this.betPrice1 = 0;
            this.betPrice2 = 0;
            this.betPrice3 = 0;

            this.maxBetPrice = puntObj.Amount(50);
            
            this.Cash1 = maxBetPrice;
            this.Cash2 = maxBetPrice;
            this.Cash3 = maxBetPrice;
            this.bPlaced = false;
            this.betCount = 0;


            dogNUD.Minimum = 1;
            dogNUD.Maximum = 3;
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
        }

        // Reseting all variable to initial value
        private void resetBtn_Click(object sender, EventArgs e)
        {
            carNum1 = 0;
            carNum2 = 0;
            carNum3 = 0;

            betPrice1 = 0;
            betPrice2 = 0;
            betPrice3 = 0;

            maxBetPrice = puntObj.Amount(50);
            Cash1 = maxBetPrice;
            Cash2 = maxBetPrice;
            Cash3 = maxBetPrice;
            mxBet.Text = maxBetPrice.ToString();
            betCount = 0;
            bPlaced = false;

            winLbl.Text = "";
            joeTB.Text = "Joe hasn't placed a bet ";
            bobTB.Text = "Bob hasn't placed a bet ";
            aiTB.Text = "AI hasn't placed a bet ";

            dogNUD.Value = 1;
            priceNUD.Value = 0;

            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Show();
            pictureBox5.Show();
            pictureBox6.Show();
        }

        //Radio Button for Joe 
        private void rbJoe_CheckedChanged(object sender, EventArgs e)
        {
            betterTb.Text = joeObj.getName("Joe");
            mxBet.Text = Cash1.ToString();
            priceNUD.Minimum = 0;
            priceNUD.Maximum = Cash1;
        }

        //Checkbox for Bob
        private void rbBob_CheckedChanged(object sender, EventArgs e)
        {
            betterTb.Text = bobObj.getName("Bob");
            mxBet.Text = Cash2.ToString();
            priceNUD.Minimum = 0;
            priceNUD.Maximum = Cash2;
        }


        private void rbAi_CheckedChanged(object sender, EventArgs e)
        {
            betterTb.Text = aiObj.getName("AI");
            mxBet.Text = Cash3.ToString();
            priceNUD.Minimum = 0;
            priceNUD.Maximum = Cash3;
        }

        private void placeBetBtn_Click(object sender, EventArgs e)
        {
            bPlaced = true;
            
            Decimal betPrice = priceNUD.Value;

            mxBet.Enabled = false;
            
            if (betPrice <= Cash1)
            {
                if (betterTb.Text == "Joe")
                {
                    betPrice1 = priceNUD.Value;
                    carNum1 = dogNUD.Value;
                    joeTB.Text = betterTb.Text + " bets $ " + betPrice1 + " On Car Number " + carNum1;
                }
            }
            else
            {
                if (betterTb.Text == "Joe")
                    joeTB.Text = "BUSTED";
            }
            if (betPrice <= Cash2)
            {
                if (betterTb.Text == "Bob")
                {
                    betPrice2 = priceNUD.Value;
                    carNum2 = dogNUD.Value;
                    bobTB.Text = betterTb.Text + " bets $ " + betPrice2 + " On Car Number " + carNum2;
                }
            }
            else
            {
                if (betterTb.Text == "Bob")
                    bobTB.Text = "BUSTED";
            }

            if (betPrice <= Cash3)
            {
                if (betterTb.Text == "AI")
                {
                    betPrice3 = priceNUD.Value;
                    carNum3 = dogNUD.Value;
                    aiTB.Text = betterTb.Text + " bets $ " + betPrice3 + " On Car Number " + carNum3;
                }
            }
            else
            {
                if (betterTb.Text == "AI")
                    aiTB.Text = "BUSTED";
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mxBet_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void raceBtn_Click(object sender, EventArgs e)
        {
            betCount++;
            if(bPlaced == true)
            {
                int wD = puntObj.winCar();
                winLbl.Text = "Car Number " + wD + " Won this race";
                if (wD == carNum1)
                {
                    Cash1 = Cash1 + Convert.ToInt32(betPrice2) + Convert.ToInt32(betPrice3);
                    Cash3 = Cash3 - Convert.ToInt32(betPrice3);
                    Cash2 = Cash2 - Convert.ToInt32(betPrice2);
                    joeTB.Text = "Joe won "+betCount+" round";


                }
                else if (wD == carNum2)
                {
                    Cash2 = Cash2 + Convert.ToInt32(betPrice1) + Convert.ToInt32(betPrice3);
                    Cash1 = Cash1 - Convert.ToInt32(betPrice1);
                    Cash3 = Cash3 - Convert.ToInt32(betPrice3);
                    bobTB.Text = "Bob won " + betCount + " round";
                }
                else if (wD == carNum3)
                {
                    Cash3 = Cash3 + Convert.ToInt32(betPrice1) + Convert.ToInt32(betPrice2);
                    Cash1 = Cash1 - Convert.ToInt32(betPrice1);
                    Cash2 = Cash2 - Convert.ToInt32(betPrice2);
                    aiTB.Text = "AI won " + betCount + " round";
                }
                else
                {
                    Cash1 = Cash1 - Convert.ToInt32(betPrice1);
                    Cash2 = Cash2 - Convert.ToInt32(betPrice2);
                    Cash3 = Cash3 - Convert.ToInt32(betPrice3);
                    joeTB.Text = "NoOne won " + betCount + " round";
                    bobTB.Text = "NoOne won " + betCount + " round";
                    aiTB.Text = "NoOne won " + betCount + " round";
                }

                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox6.Hide();

                MessageBox.Show("Joe have left $: " + Cash1.ToString() + "    \nBob have left  $: " + Cash2.ToString() + "   \nAI have left  $: " + Cash3.ToString() + " \nWinnig Car is: " + wD);
                if (Cash1 <= 0)
                {
                    joeTB.Text = "Joe You Lost";
                    rbJoe.Enabled = false;
                }
                if (Cash2 <= 0)
                {
                    bobTB.Text = "Bob You Lost";
                    rbBob.Enabled = false;
                }
                if (Cash3 <= 0)
                {
                    aiTB.Text = "AI You Lost";
                    rbAi.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Place Bet First");
            }
        }
    }
}
