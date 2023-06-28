namespace ClassRoomApp.Models.Pupils;

internal class BadPupil : Pupil
{
    public override void Read()
    {
        Console.WriteLine("Method Read() from class BadPupil");
    }

    public override void Relax()
    {
        Console.WriteLine("Method Relax() from class BadPupil");
    }

    public override void Study()
    {
        Console.WriteLine("Method Study() from class BadPupil");
    }

    public override void Write()
    {
        Console.WriteLine("Method Write() from class BadPupil");
    }
}
