namespace Sorting_Objects;

internal class Program
{
    static void Main(string[] args)
    {
        Book[] books =
        {
            new Book("Dedaena", 29),
            new Book("Ai Ia", 9),
            new Book("Didostatis Marjvena", 25),
            new Book("Vefxistyaosani", 50),
            new Book("Nacarqeqia", 5.6),
        };

        ArrayTools.Sort(books);

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine(books[i]);
        }

        Console.WriteLine();

        Human[] humans =
        {
            new Human("Leqso", 1.81),
            new Human("Irakli", 1.75),
            new Human("Teo", 1.65),
            new Human("Nika", 1.90),
            new Human("Aleqsandre", 1.85),
        };

        ArrayTools.Sort(humans);

        for (int i = 0; i < humans.Length; i++)
        {
            Console.WriteLine(humans[i]);
        }
    }
}