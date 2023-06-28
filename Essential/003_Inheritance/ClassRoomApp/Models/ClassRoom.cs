using ClassRoomApp.Models.Pupils;

namespace ClassRoomApp.Models;

internal class ClassRoom
{
    private readonly Pupil[] pupils = new Pupil[4];

    public ClassRoom(Pupil firstPupil, Pupil secondPupil, Pupil thirdPupil, Pupil forthPupil)
    {
        pupils[0] = firstPupil;
        pupils[1] = secondPupil;
        pupils[2] = thirdPupil;
        pupils[3] = forthPupil;
    }

    public ClassRoom(Pupil firstPupil, Pupil secondPupil, Pupil thirdPupil)
    {
        pupils[0] = firstPupil;
        pupils[1] = secondPupil;
        pupils[2] = thirdPupil;
        pupils[3] = GeneratePupil();
    }

    public ClassRoom(Pupil firstPupil, Pupil secondPupil)
    {
        pupils[0] = firstPupil;
        pupils[1] = secondPupil;
        pupils[2] = GeneratePupil();
        pupils[3] = GeneratePupil();
    }

    public void Read()
    {
        foreach (var pupil in pupils)
        {
            pupil.Read();
        }
    }

    public void Study()
    {
        foreach (var pupil in pupils)
        {
            pupil.Study();
        }
    }

    public void Write()
    {
        foreach (var pupil in pupils)
        {
            pupil.Write();
        }
    }

    public void Relax()
    {
        foreach (var pupil in pupils)
        {
            pupil.Relax();
        }
    }

    private Pupil GeneratePupil()
    {
        var random = new Random();
        var typeOfPupil = random.Next(1, 3);

        switch (typeOfPupil)
        {
            case 1:
                return new ExcellentPupil();
            case 2:
                return new GoodPupil();
            case 3:
                return new BadPupil();
            default:
                break;
        }

        return null;
    }
}
