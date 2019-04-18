using System;
using System.Linq;
using System.Text;

public class Book
{
    protected const int TITLE_MIN_LENGTH = 3;
    protected const int MIN_PRICE = 1;

    protected const string TITLE_ERROR = "Title not valid!";
    protected const string AUTHOR_NAME_ERROR = "Author not valid!";
    protected const string PRICE_ERROR = "Price not valid!";

    private string title;
    private string author;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    public string Title
    {
        get { return this.title; }
        set
        {
            if(value.Length < TITLE_MIN_LENGTH)
            {
                throw new ArgumentException(TITLE_ERROR);
            }
            this.title = value;
        }
    }

    public string Author
    {
        get { return this.author; }
        set
        {
            string[] authorNameTokens = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            if(authorNameTokens.Length > 1 && char.IsDigit(authorNameTokens[1][0]))
            {
                throw new ArgumentException(AUTHOR_NAME_ERROR);
            }
            this.author = value;
        }
    }

    public virtual decimal Price
    {
        get { return this.price; }
        set
        {
            if(value < MIN_PRICE)
            {
                throw new ArgumentException(PRICE_ERROR);
            }
            this.price = value;
        }
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder
            .AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");
        return builder.ToString().TrimEnd();
    }
}