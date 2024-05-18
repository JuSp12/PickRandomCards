using System;

namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wpisz liczbe generowania kart: ");

            string line = Console.ReadLine();

            //Przeksztalcamy string line na int ze wzgledu ze w CardPicker.PickSomeCards mamy (int parament) i sprawdzamy czy jest to mozliwe
            if (int.TryParse(line, out int numberOfCards)) 
            {
                string[] randomCards = CardPicker.PickSomeCards(numberOfCards);
                
                foreach (string card in randomCards) 
                {
                    Console.WriteLine(card);
                }

            }
            else
            {
                Console.WriteLine("Error");
            }



        }

    }
}