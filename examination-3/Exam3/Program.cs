using System;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            // Deck game = new Deck();
            // game.createDeck();
            // game.ShowCards();

            Game game1 = new Game();
            game1.Play();
        }
    }
}
