using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication3.PL;
namespace WindowsFormsApplication3.BL
{
    class Game
    {
        public Game(){

           create_deck_of_cards(CARD_NAMES);

            foreach (var item in deck_of_cards)
            {
                // Console.Write(item + "\n");
            }
        }
      List<string> CARD_NAMES = new List<string>()  {
	                                "8-ball",
	                                "baked-potato",
	                                "dinosaur",
	                                "kronos",
	                                "rocket",
	                                "skinny-unicorn",
	                                "that-guy",
	                                "zeppelin"
                                  };
     
        public List<string> deck_of_cards = new List<string>();
        public void create_deck_of_cards(List<string> card_names)
        {

            List<string> possible_cards = new List<string>();

            // loop through card_names and add each card twice to a temporary array (possible_cards)
            for (var i = 0; i < card_names.Count; i++)
            {
                possible_cards.Add(card_names[i]);
                possible_cards.Add(card_names[i]);
            }
            // loop through possible_cards
            for (var i = 0; i < 16; i++)
            {
                // generate random index to pick a random card from possible_cards
                var possible_rand = new Random().Next(possible_cards.Count);
                // add the picked card to deck_of_cards
                deck_of_cards.Add(possible_cards[possible_rand]);
                // remove the selected card from possible_cards
                possible_cards.Remove(possible_cards[possible_rand]);

            }

        }



        public List<string> name_card = new List<string>();
        public bool  check_card()
        {
            if (name_card.Count == 2)
            {
                if (name_card[0] == name_card[1])
                {
                   //score  ++
                    Console.Write(name_card[0] + "       " + name_card[1]+"\n");
                    name_card.RemoveRange(0, 2);
                    return false;
                    
                }
                else
                {
                    Console.Write(name_card[0] + "       " + name_card[1] + "\n");
                    name_card.RemoveRange(0, 2);
                    return true;
                  
                }
               
            }
           
            return false ;
        }

    }
}
