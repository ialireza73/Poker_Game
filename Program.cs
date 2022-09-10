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
            Random random = new Random();

            int[] indexerNUM = new int[36];
            string[] randomcards = new string[36];

            for (int i = 0; i < indexerNUM.Length; i++)
            {

                int randomCardNumber = random.Next(0, all_Cards.Length);

                if (all_Cards[randomCardNumber] != null)
                {
                    indexerNUM[i] = randomCardNumber;
                    all_Cards[randomCardNumber] = null;
                }
                else
                {
                    for (int k = 0; k < all_Cards.Length; k++)
                    {
                        if (all_Cards[k] != null)
                        {
                            indexerNUM[i] = k;
                            all_Cards[k] = null;
                            break;
                        }
                    }

                }

            }
            for (int i = 0; i < randomcards.Length; i++)
            {
                randomcards[i] = Keeped_Cards[indexerNUM[i]];
            }
            System.Console.WriteLine("choose 5 number between 0 and 35");
            int _1th = Convert.ToInt32(Console.ReadLine());
            int _2th = Convert.ToInt32(Console.ReadLine());
            int _3th = Convert.ToInt32(Console.ReadLine());
            int _4th = Convert.ToInt32(Console.ReadLine());
            int _5th = Convert.ToInt32(Console.ReadLine());


            string[] player_cards ={
                           randomcards[_1th],
                           randomcards[_2th],
                           randomcards[_3th],
                           randomcards[_4th],
                           randomcards[_5th]
                          };
            randomcards[_1th] = null;
            randomcards[_2th] = null;
            randomcards[_3th] = null;
            randomcards[_4th] = null;
            randomcards[_5th] = null;

            foreach (var item in player_cards)
            {
                System.Console.WriteLine(item);

            }
            System.Console.WriteLine("do you want to keep them? y/n");
            bool keepthem = true;
            if (Console.ReadLine() != "y")
            {
                keepthem = false;
            }
            else { keepthem = true; }

            if (!keepthem)
            {
                System.Console.WriteLine("how much card do you want to put out: ");
                int delete_Card_count = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine($"choose {delete_Card_count} card be out:");
                for (int i = 1; i <= delete_Card_count; i++)
                {
                    player_cards[Convert.ToInt32(Console.ReadLine())] = null;
                }

                System.Console.WriteLine($"ok! choose new{delete_Card_count} Cards,except {_1th} & {_2th} & {_3th} & {_4th} & {_5th} ");
                for (int i = 0; i < player_cards.Length; i++)
                {
                    if (player_cards[i] == null)
                    {
                        player_cards[i] = randomcards[Convert.ToInt32(Console.ReadLine())];
                    }

                }
                foreach (var item in player_cards)
                {
                    System.Console.WriteLine(item);

                }

            }


            // foreach (var item in player_cards)
            // {
            //     System.Console.WriteLine(item);

            // }

            // int p = 0;
            // foreach (var item in randomcards)
            // {
            //     p++;
            //     System.Console.WriteLine(p + " :" + item);
            // }


        }
        static void wrong_Poker()
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

            //  System.Console.WriteLine(all_Cards[0, 0]);
            for (int i = 0; i < indexerNUM.Length; i++)
            {

                int randomcardMARK = random.Next(0, all_Cards.GetLength(0));
                int randomCardNumber = random.Next(0, all_Cards.GetLength(1));

                if (all_Cards[randomcardMARK, randomCardNumber] != null)
                {
                    indexerMark[i] = randomcardMARK;
                    indexerNUM[i] = randomCardNumber;
                    //  System.Console.WriteLine();
                    all_Cards[randomcardMARK, randomCardNumber] = null;
                    //   System.Console.WriteLine(i + "ADDED: " + "_ " + "mark:" + indexerMark[i] + "....." + "Num:" + indexerNUM[i]);
                }
                else
                {
                    // foreach (var item in all_Cards)
                    // {
                    //     int
                    //     if(item!=null)
                    //     {
                    //         indexerMark[i]=item;
                    //     }
                    // }
                    //  System.Console.WriteLine("**we tried: " + randomcardMARK + " " + randomCardNumber);
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
                    //  System.Console.WriteLine(i + "null: " + "_ " + "mark:" + indexerMark[i] + "....." + "Num:" + indexerNUM[i]);
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
            // //int[, ,] arr3d3 = new int[2, 2, 3]{ { { 1, 2, 3}, {4, 5, 6} },{ { 7, 8, 9}, {10, 11, 12} }};
            // foreach (var item in all_Cards)
            // {
            //     System.Console.WriteLine(item);

            // }

        }

    }
}
