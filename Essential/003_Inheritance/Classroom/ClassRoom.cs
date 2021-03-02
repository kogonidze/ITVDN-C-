using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class ClassRoom
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

        public void ShowHowPupilsRead()
        {
            foreach (var pupil in pupils)
            {
                pupil.Read();
            }
        }

        public void ShowHowPupilsWrite()
        {
            foreach (var pupil in pupils)
            {
                pupil.Write();
            }
        }

        public void ShowHowPupilsRelax()
        {
            foreach (var pupil in pupils)
            {
                pupil.Relax();
            }
        }

        public void ShowHowPupilsStudy()
        {
            foreach (var pupil in pupils)
            {
                pupil.Study();
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
}
