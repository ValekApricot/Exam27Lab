using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Pages { get; set; }

    public void AddNewBook(string title, string author, string genre, int pages)
    {
        if (string.IsNullOrEmpty(title))
        {
            throw new ArgumentException("Автор не может быть пустым");
        }

        if (string.IsNullOrEmpty(author))
        {
            throw new ArgumentException("Author cannot be empty");
        }

        if (string.IsNullOrEmpty(genre))
        {
            throw new ArgumentException("Жанр не может быть пустым");
        }

        if (pages <= 0)
        {
            throw new ArgumentException("Количество страниц должно быть больше 0");
        }

        Title = title;
        Author = author;
        Genre = genre;
        Pages = pages;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();

        try
        {
            book.AddNewBook("1836", "Сергеевич Пушкин", "Капитанская дочка", 1000);
            Console.WriteLine("Книга успешно добавлена");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

