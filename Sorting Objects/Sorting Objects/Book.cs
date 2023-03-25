namespace Sorting_Objects;

class Book : Comparable
{
    public Book(string title, double price)
    {
        Title = title ?? throw new ArgumentNullException(nameof(title));
        Price = price;
    }

    public string Title { get; }
    public double Price { get; }

    public override string ToString()
    {
        return $"{Title} - {Price:0.00}";
    }

    public override int CompareTo(object obj)
    {
        Book other = (Book)obj;

        if (this.Price > other.Price)
        {
            return 1;
        }

        if (this.Price < other.Price)
        {
            return -1;
        }

        return 0;
    }
}

