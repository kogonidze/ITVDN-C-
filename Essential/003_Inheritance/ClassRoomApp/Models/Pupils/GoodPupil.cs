namespace ClassRoomApp.Models.Pupils;

internal class GoodPupil : Pupil
{
    public override void Read()
    {
        Console.WriteLine("Method Read() from class GoodPupil");
    }

    public override void Relax()
    {
        Console.WriteLine("Method Relax() from class GoodPupil");
    }

    public override void Study()
    {
        Console.WriteLine("Method Study() from class GoodPupil");
    }

    public override void Write()
    {
        Console.WriteLine("Method Write() from class GoodPupil");
    }
}
