using ClassRoomApp.Models;
using ClassRoomApp.Models.Pupils;

var firstClass = new ClassRoom(new ExcellentPupil(), new BadPupil());

firstClass.Study();
firstClass.Write();
firstClass.Relax();
firstClass.Read();

Console.ReadKey();