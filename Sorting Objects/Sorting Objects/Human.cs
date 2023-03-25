namespace Sorting_Objects;

class Human : Comparable
{
    public Human(string name, double height)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Height = height;
    }

    public string Name { get; }
    public double Height { get; }

    public override string ToString()
    {
        return $"{Name} - {Height}";
    }

    public override int CompareTo(object obj)
    {
        Human other = (Human) obj;

        if (this.Height > other.Height)
        {
            return 1;
        }

        if (this.Height < other.Height)
        {
            return -1;
        }

        return 0;
    }
}

