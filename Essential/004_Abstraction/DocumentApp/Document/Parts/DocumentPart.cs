namespace DocumentApp.Parts;

abstract class DocumentPart
{
    protected string content;

    abstract public string Content { get; set; }

    abstract public void Show();
}
