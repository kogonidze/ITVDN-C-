namespace DocumentHandlerApp.Handlers;

internal class DOCHandler : AbstractHandler
{
    public DOCHandler(string filename) 
        : base(filename)
    {
    }

    public override void Change()
    {
        Console.WriteLine($"Document {filename} was changed by DOCHandler");
    }

    public override void Create()
    {
        Console.WriteLine($"Document {filename} was created by DOCHandler");
    }

    public override void Open()
    {
        Console.WriteLine($"Document {filename} was opened by DOCHandler");
    }

    public override void Save()
    {
        Console.WriteLine($"Document {filename} was saved by DOCHandler");
    }
}
