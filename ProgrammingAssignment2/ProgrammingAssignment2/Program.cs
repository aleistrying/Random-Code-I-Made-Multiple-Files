using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.SetCursorPosition(Console.BufferWidth / 2 - 13, 0);
            //Writes text
            Console.WriteLine("Welcome User.");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 26, 1);
            Console.WriteLine("This program will deal 2 cards to 3 players");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 26, 2);
            Console.WriteLine(" and display the cards from the players.");

            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();
            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)

            //takes the first card for players 1,2,3 
            Card p1_C1 = deck.TakeTopCard();
            Card p2_C1 = deck.TakeTopCard();
            Card p3_C1 = deck.TakeTopCard();
            //takes the second card for players 1,2,3
            Card p1_C2 = deck.TakeTopCard();
            Card p2_C2 = deck.TakeTopCard();
            Card p3_C2 = deck.TakeTopCard();

            // flip all the cards over
            p1_C1.FlipOver();
            p1_C2.FlipOver();
            p2_C1.FlipOver();
            p2_C2.FlipOver();
            p3_C1.FlipOver();
            p3_C2.FlipOver();

            // print the cards for player 1
            Console.WriteLine("Player one Card one: {0} of {1}", p1_C1.Rank, p1_C1.Suit);
            Console.WriteLine("Player one Card two: {0} of {1}", p1_C2.Rank, p1_C2.Suit);
            // space
            Console.WriteLine();
            // print the cards for player 2
            Console.WriteLine("Player one Card one: {0} of {1}", p2_C1.Rank, p2_C1.Suit);
            Console.WriteLine("Player one Card two: {0} of {1}", p2_C2.Rank, p2_C2.Suit);
            // space
            Console.WriteLine();
            // print the cards for player 3
            Console.WriteLine("Player one Card one: {0} of {1}", p3_C1.Rank, p3_C1.Suit);
            Console.WriteLine("Player one Card two: {0} of {1}", p3_C2.Rank, p3_C2.Suit);
            // space
            Console.WriteLine();
            Console.WriteLine("Press any Key to close the Program . . .");
            Console.ReadKey();
        }
    }
}
