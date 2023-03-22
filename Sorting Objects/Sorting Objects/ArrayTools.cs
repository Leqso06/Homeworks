namespace Sorting_Objects;

public class ArrayTools
{
    public static void Sort(object[] array)
    {
        object temp;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] is Book book)
                {
                    Book book1 = array[j] as Book;
                    if (book1.Compare(array[j + 1]))
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }

                if (array[j] is Human human)
                {
                    Human human1 = array[j] as Human;
                    if (human1.Compare(array[j + 1]))
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }

    public static void Sort(string[] array)
    {
        string temp;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
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
            for (int j = 0; j < array.Length - i - 1; j++)
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

