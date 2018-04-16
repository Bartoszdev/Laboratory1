using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory1
{
    public class Greyhound
    {
        public int StartingPosition; // Miejsce ,gdzie rozpoczyna się PictureBox
        public int RacetrackLenght; // Jak długa jest trasa
        public PictureBox MyPictureBox = null; //Mój obiekt PictureBox
        public int Location = 0;// Moje położenie na torze wyścigowym
        public Random MyRandom; // Instancja klasy Random


        public bool Run()
        {
            MyPictureBox.Left += MyRandom.Next(10, 20);
            MyPictureBox.Update();

            if (MyPictureBox.Left >= RacetrackLenght - MyPictureBox.Width)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public void TakeStartingPosition()
        {
            
            MyPictureBox.Left = StartingPosition;
         
        }
    }
}
