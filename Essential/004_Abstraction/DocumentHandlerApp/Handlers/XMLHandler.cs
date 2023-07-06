namespace DocumentHandlerApp.Handlers;

internal class XMLHandler : AbstractHandler
{
    public XMLHandler(string filename)
        : base(filename)
    {
    }

    public override void Change()
    {
        Console.WriteLine($"Document {filename} was changed by XMLHandler");
    }

    public override void Create()
    {
        Console.WriteLine($"Document {filename} was created by XMLHandler");
    }

    public override void Open()
    {
        Console.WriteLine($"Document {filename} was opened by XMLHandler");
    }

    public override void Save()
    {
        Console.WriteLine($"Document {filename} was saved by XMLHandler");
    }
}
