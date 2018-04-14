using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory1
{
    public partial class Form1 : Form
    {
        Guy[] Bettors;
        Greyhound[] Dogs;
        Bet MyBet;


        public Form1()
        {
            InitializeComponent();
            Random Randomizer = new Random();

            Bettors = new Guy[3];
            Dogs = new Greyhound[4];

            Bettors[0] = new Guy() { Name = "Janek", Cash = 50, MyRadioButton = joeRadioButton, MyLabel = joeBetLabel };
            Bettors[0].UpdateLabels();
            Bettors[0].ClearBet();
            Bettors[1] = new Guy() { Name = "Bartek", Cash = 75, MyRadioButton = bobRadioButton, MyLabel = bobBetLabel };
            Bettors[1].UpdateLabels();
            Bettors[1].ClearBet();
            Bettors[2] = new Guy() { Name = "Arek", Cash = 45, MyRadioButton = alRadioButton, MyLabel = alBetLabel };
            Bettors[2].UpdateLabels();
            Bettors[2].ClearBet();

            minimumBetLabel.Text = "Minimalny zakład :" + numericUpDown1.Value;
            nameLabel.Text = "Janek";

            Dogs[0] = new Greyhound() { MyPictureBox = pictureBox2, StartingPosition = pictureBox2.Left, RacetrackLenght = raceTrackPicturebox.Width - pictureBox2.Width, MyRandom = Randomizer };
            Dogs[1] = new Greyhound() { MyPictureBox = pictureBox3, StartingPosition = pictureBox3.Left, RacetrackLenght = raceTrackPicturebox.Width - pictureBox3.Width, MyRandom = Randomizer };
            Dogs[2] = new Greyhound() { MyPictureBox = pictureBox4, StartingPosition = pictureBox4.Left, RacetrackLenght = raceTrackPicturebox.Width - pictureBox4.Width, MyRandom = Randomizer };
            Dogs[3] = new Greyhound() { MyPictureBox = pictureBox5, StartingPosition = pictureBox5.Left, RacetrackLenght = raceTrackPicturebox.Width - pictureBox5.Width, MyRandom = Randomizer };
            
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Janek";
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            nameLabel.Text = "Bartek";
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            nameLabel.Text = "Arek";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guyNumber = 0;
            if (joeRadioButton.Checked)
            {
                guyNumber = 0;
            }
            else if (bobRadioButton.Checked)
            {
                guyNumber = 1;
            }
            else if (alRadioButton.Checked)
            {
                guyNumber = 2;
            }
            
            if(numericUpDown1.Value >= 5 && numericUpDown1.Value <= 15 && Bettors[guyNumber].Cash >= numericUpDown1.Value)
            {
                MyBet = new Bet();
                Bettors[guyNumber].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                Bettors[guyNumber].UpdateLabels();
                Bettors[guyNumber].MyRadioButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Maksymalna wartość dla pojedyńczego zakładu to 15 zł", "Komunikat");
            }
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Dogs.Length; i++)
                if (Dogs[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("Chart numer" + MyBet.Dog + "wygrał");
                    Bettors[i].Collect(i);

                }
                
            }
    }
    }

