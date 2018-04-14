using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory1
{
    public class Guy

    {
        public string Name; // Imię faceta
        public Bet MyBet;// Instancja klasy Bet przechowywująca dane o zakładzie
        public int Cash;//Jak dużo pieniędzy posiada
        public RadioButton MyRadioButton;// Moje pole wyboru 
        public Label MyLabel;//Moja etykieta 



        public void UpdateLabels()
        {
            if (MyBet == null)
            { 
            MyRadioButton.Text = Name + " ma " + Cash + " zł";
            MyLabel.Text = Name + " nie zawarł zakładu";
            }
            else
            {
                MyLabel.Text = Name + " postawił" + MyBet.Amount + " zł" + " na psa numer " + MyBet.Dog;
            }



        
        }


        public void ClearBet()
        {
            MyBet = null;
        }
        public bool PlaceBet(int amount,int DogToWin)
        {
            MyBet = new Bet() { Amount = amount , Dog =  DogToWin , Bettor = this };

            if(this.MyBet.Bettor.Cash > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }

        public void Collect(int Winner)
         {
            MyBet = new Bet() { Dog = Winner , Bettor= this};

            MyBet.PayOut(Winner);
            
          }


        }
    }


