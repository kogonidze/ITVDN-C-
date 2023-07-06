using DocumentHandlerApp.Handlers;

namespace DocumentHandlerApp;

internal class Processor
{
    AbstractHandler handler;

    public void ChooseDocument(string filename)
    {
        switch (Path.GetExtension(filename).ToLower())
        {
            case ".txt":
                handler = new TXTHandler(filename);
                break;

            case ".doc":
                handler = new DOCHandler(filename);
                break;

            case ".xml":
                handler = new XMLHandler(filename);
                break;

            default:
                Console.WriteLine("Unknown format!");
                break;
        }
    }

    public void Open()
    {
        if (handler != null)
        {
            handler.Open();
        }
    }

    public void Create()
    {
        if (handler != null)
        {
            handler.Create();
        }       
    }

    public void Change()
    {
        if (handler != null)
        {
            handler.Change();
        }
    }

    public void Save()
    {
        if (handler != null)
        {
            handler.Save();
        }
    }
}
