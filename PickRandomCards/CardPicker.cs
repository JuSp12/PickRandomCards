using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];

            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            // liczba losowa od 1 do 4
            int value = random.Next(1, 5);
            
            //1=pik, 2=kier, 3= trefl, 4=karo
            if (value == 1)
            {
                return "Pik";
            }
            else if (value == 2) { return "Kier"; }
            else if (value == 3) { return "Trefl"; }
            else { return "Karo"; }
        }

        private static string RandomValue()
        {
            // liczba losowa od 1 do 4
            int value = random.Next(1, 14);

            //1=As, 2=Walet, 3= Dama, 4=Krol
            if (value == 1)
            {
                return "As";
            }
            else if (value == 11) { return "Walet"; }
            else if (value == 12) { return "Dama"; }
            else if (value == 12) { return "Krol"; }

            //Zwraca numer od 2-10 w postaci string
            else { return value.ToString(); }
        }
    }
}
