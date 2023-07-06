namespace DocumentHandlerApp.Handlers;

abstract class AbstractHandler
{
    protected string filename;

    public AbstractHandler(string filename)
    {
        this.filename = filename;
    }

    public abstract void Open();

    public abstract void Create();

    public abstract void Change();

    public abstract void Save();
}
