namespace PickRandomCardsReally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter the number of cards to pick: ");
                string? line = Console.ReadLine();
                if (int.TryParse(line, out int numberOfCards))
                {

                    string[] cards = CardPicker.PickSomeCards(numberOfCards);

                    foreach (string card in cards)
                    {
                        Console.WriteLine($"Your Cards: {card}");
                    }
                }
                else
                {
                    Console.WriteLine("Enter Correct number please");
                }
                Console.WriteLine("\nPress x to exit or anything else to continue\n");
                string bob = Console.ReadLine();
                if (bob == "x") return;

            }
        }
    }
}
