namespace BookExercise;

internal class Book
{
    Author author;
    Content content;
    Title title;

    void InitializeBook()
    {
        author = new Author();
        content = new Content();
        title = new Title();
    }

    public Book()
    {
        InitializeBook();
    }

    public string Author
    {
        get => author.Data;
        set { author.Data = value; }
    }

    public string Content
    {
        get => content.Data;
        set { content.Data = value; }
    }

    public string Title
    {
        get => title.Data;
        set { title.Data = value; }
    }

    public void Show()
    {
        author.Show();
        title.Show();
        content.Show();
    }
}
