using System;

namespace Poker_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] all_Cards = new string[]
            {
                "S_A","S_K","S_Q","S_J","S_10","S_9","S_8","S_7","S_6",//Spades
                "H_A","H_K","H_Q","H_J","H_10","H_9","H_8","H_7","H_6",//Heart
                "D_A","D_K","D_Q","D_J","D_10","D_9","D_8","D_7","D_6",//Diamond
                "C_A","C_K","C_Q","C_J","C_10","C_9","C_8","C_7","C_6"//Clubs

            };
            string[] Keeped_Cards = new string[]
            {
                "S_A","S_K","S_Q","S_J","S_10","S_9","S_8","S_7","S_6",//Spades
                "H_A","H_K","H_Q","H_J","H_10","H_9","H_8","H_7","H_6",//Heart
                "D_A","D_K","D_Q","D_J","D_10","D_9","D_8","D_7","D_6",//Diamond
                "C_A","C_K","C_Q","C_J","C_10","C_9","C_8","C_7","C_6"//Clubs

            };
            Random randomINT = new Random();

            int[] indexerNUM = new int[36];
            string[] randomcards = new string[36];

            indexerNUM = Shuffle(randomINT, all_Cards);

            randomcards = FillTheCardsFromIndex(indexerNUM, Keeped_Cards);

            int[] Choosedcards = new int[5];
            Choosedcards = ChooseYourCards();
            string[] player_cards = FillingTheHand(Choosedcards, randomcards);

            Show_hand(player_cards);
            System.Console.WriteLine("do you want to keep them? y/n");
            bool keepthem = true;
            if (Console.ReadLine() != "y")
            {
                keepthem = false;
            }

            if (!keepthem)
            {
                player_cards = AgainFilltheHand(player_cards, randomcards, Choosedcards);
                Show_hand(player_cards);

            }

        }
        public static string[] AgainFilltheHand(string[] inputHand, string[] randomdata, int[] blanket)//we let player remove and fill unwanted cards
        {
            System.Console.WriteLine("how many card do you want to put out: ");
            int delete_Card_count = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine($"choose {delete_Card_count} card be out by its number:");
            for (int i = 0; i < delete_Card_count; i++)
            {
                inputHand[Convert.ToInt32(Console.ReadLine()) - 1] = null;
            }
            Show_hand(inputHand);
            System.Console.WriteLine($"ok! choose new {delete_Card_count} Cards,except {blanket[0] + 1} & {blanket[1] + 1} & {blanket[2] + 1} & {blanket[3] + 1} & {blanket[4] + 1} ");
            for (int i = 0; i < inputHand.Length; i++)
            {
                int index;
                if (inputHand[i] == null)
                {
                    index = Convert.ToInt32(Console.ReadLine());
                    inputHand[i] = randomdata[index - 1];
                    randomdata[index] = null;
                }
            }

            return inputHand;
        }
        public static string[] FillingTheHand(int[] choosed_Index, string[] randomData)//use those 5 number we get from ChoosingYourHand()
        {
            string[] player_cards = new string[5];
            for (int i = 0; i < player_cards.Length; i++)
            {
                player_cards[i] = randomData[choosed_Index[i]];
                randomData[choosed_Index[i]] = null;
            }
            return player_cards;
        }
        public static int[] ChooseYourCards()//choose 5 number to fill player hand
        {
            System.Console.WriteLine("choose 5 number between 1 and 36");
            int[] Choosedcards = new int[5];
            for (int i = 0; i < Choosedcards.Length; i++)
            {
                Choosedcards[i] = Convert.ToInt32(Console.ReadLine()) - 1;
            }
            return Choosedcards;

        }
        public static string[] FillTheCardsFromIndex(int[] indexer, string[] data)//fill the empty string by using indexes from Suffle() and the pattern cards 
        {
            string[] emptyHand = new string[36];
            for (int i = 0; i < emptyHand.Length; i++)
            {
                emptyHand[i] = data[indexer[i]];
            }
            return emptyHand;
        }
        public static int[] Shuffle(Random random, string[] all_Cards)//creating of indexes for shuffling
        {
            int[] index_creator = new int[36];
            for (int i = 0; i < index_creator.Length; i++)
            {

                int randomCardNumber = random.Next(0, all_Cards.Length);

                if (all_Cards[randomCardNumber] != null)
                {
                    index_creator[i] = randomCardNumber;
                    all_Cards[randomCardNumber] = null;
                }
                else
                {
                    for (int k = 0; k < all_Cards.Length; k++)
                    {
                        if (all_Cards[k] != null)
                        {
                            index_creator[i] = k;
                            all_Cards[k] = null;
                            break;
                        }
                    }

                }

            }
            return index_creator;
        }
        static void Show_hand(string[] hand)//writeLine the player hand
        {
            int i = 1;
            foreach (var item in hand)
            {
                if (item != null)
                {
                    System.Console.WriteLine(i + ": " + item);

                }
                else { System.Console.WriteLine(i + ": " + "you choosed this one NULL"); }
                i++;
            }
        }
        static void wrong_Poker()//i used a neasted array and it was wrong but i keep it for its complicated Shuffle method
        {
            string[,] all_Cards = new string[4, 9]
           {
                {"A","K","Q","J","10","9","8","7","6"},//Spades
                {"A","K","Q","J","10","9","8","7","6"},//Heart
                {"A","K","Q","J","10","9","8","7","6"},//Diamond
                {"A","K","Q","J","10","9","8","7","6"},//Clubs

           };
            string[,] Keeped_Cards = new string[4, 9]
            {
                {"A","K","Q","J","10","9","8","7","6"},//Spades
                {"A","K","Q","J","10","9","8","7","6"},//Heart
                {"A","K","Q","J","10","9","8","7","6"},//Diamond
                {"A","K","Q","J","10","9","8","7","6"},//Clubs

            };
            Random random = new Random();
            int[] indexerMark = new int[36];
            int[] indexerNUM = new int[36];
            string[] randomcards = new string[36];
            for (int i = 0; i < indexerNUM.Length; i++)
            {

                int randomcardMARK = random.Next(0, all_Cards.GetLength(0));
                int randomCardNumber = random.Next(0, all_Cards.GetLength(1));

                if (all_Cards[randomcardMARK, randomCardNumber] != null)
                {
                    indexerMark[i] = randomcardMARK;
                    indexerNUM[i] = randomCardNumber;
                    all_Cards[randomcardMARK, randomCardNumber] = null;

                }
                else
                {

                    for (int k = 0; k < all_Cards.GetLength(0); k++)
                    {
                        bool getout = false;
                        for (int Q = 0; Q < all_Cards.GetLength(1); Q++)
                        {
                            if (all_Cards[k, Q] != null)
                            {

                                indexerNUM[i] = Q;
                                indexerMark[i] = k;
                                all_Cards[k, Q] = null;
                                getout = true;
                                break;
                            }

                        }
                        if (getout)
                        {
                            break;
                        }
                    }
                }

            }
            for (int i = 0; i < randomcards.Length; i++)
            {
                randomcards[i] = Keeped_Cards[indexerMark[i], indexerNUM[i]];
            }
            int p = 0;
            foreach (var item in randomcards)
            {
                p++;
                System.Console.WriteLine(p + " :" + item);
            }

        }

    }
}
