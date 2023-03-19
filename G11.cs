namespace G11_230316;

internal class Program
{
    static void Main(string[] args)
    {
        //Book book1 = new Book("Dedaena", 29);
        //Book book2 = new Book("Dedaena", 17);
        //Console.WriteLine(book1.Equals(book2));

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
    }
}

public static class ArrayTools
{
    public static void Sort(object[] array)
    {
        object temp;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                //if (array[j] > array[j + 1])
                //{
                //    temp = array[j];
                //    array[j] = array[j + 1];
                //    array[j + 1] = temp;
                //}
            }
        }
    }

    public static void Sort(string[] array)
    {
        string temp;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j].Length > array[j + 1].Length)
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public static void Sort(int[] array)
    {
        int temp;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}

public class Book
{
    public Book(string title, double price)
    {
        Title = title ?? throw new ArgumentNullException(nameof(title));
        Price = price;
    }

    public string Title { get; } = null!;
    public double Price { get; }

    public override string ToString()
    {
        return $"{Title} - {Price:0.00}";
    }

    public override bool Equals(object? obj)
    {
        Book other = obj as Book;

        if (this.Title == other.Title && this.Price == other.Price)
        {
            return true;
        }
        return false;
    }
}
