namespace ClassRoomApp.Models.Pupils;

internal class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Method Study() from class Pupil");
    }

    public virtual void Read()
    {
        Console.WriteLine("Method Read() from class Pupil");
    }

    public virtual void Write()
    {
        Console.WriteLine("Method Write() from class Pupil");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Method Relax() from class Pupil");
    }
}
