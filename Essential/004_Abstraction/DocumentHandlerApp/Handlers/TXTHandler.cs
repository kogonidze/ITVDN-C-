namespace DocumentHandlerApp.Handlers;

internal class TXTHandler : AbstractHandler
{
    public TXTHandler(string filename)
        : base(filename)
    {
    }

    public override void Change()
    {
        Console.WriteLine($"Document {filename} was changed by TXTHandler");
    }

    public override void Create()
    {
        Console.WriteLine($"Document {filename} was created by TXTHandler");
    }

    public override void Open()
    {
        Console.WriteLine($"Document {filename} was opened by TXTHandler");
    }

    public override void Save()
    {
        Console.WriteLine($"Document {filename} was saved by TXTHandler");
    }
}
