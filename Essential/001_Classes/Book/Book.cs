namespace Book
{
    class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book()
        {
            this.author = new Author("Author");
            this.title = new Title("Title");
            this.content = new Content("Content");
        }

        public Book(string title)
        {
            this.title = new Title(title);
        }

        public Book(string author, string title) : this(title)
        {
            this.author = new Author(author);
        }

        public Book(string title, string author, string content) : this(author, title)
        {
            this.content = new Content(content);
        }

        public string Title
        {
            set
            {
                title = new Title(value);
            }
        }

        public string Author
        {
            set
            {
                author = new Author(value);
            }
        }

        public string Content
        {
            set
            {
                content = new Content(value);
            }
        }

        public void Show()
        {
            author.Show();
            title.Show();
            content.Show();
        }
    }
}
