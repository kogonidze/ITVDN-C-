using CollectionOfCitizens.Citizens;
using CollectionOfCitizens.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfCitizens
{
    class CitizenCollection
    {
        private Citizen[] citizens;
        private int position = -1;

        public CitizenCollection()
        {
            citizens = new Citizen[0];
        }

        public object Current => citizens[position];
        public int Count => citizens.Length;

        public int Add(Citizen newCitizen)
        {
            if (this.Contains(newCitizen, out int index))
            {
                throw new CitizensDuplicationAttemptException();
            }


            if (newCitizen is Retiree)
            {
                var lastRetireeCitizenIndex = -1;

                for (int i = 0; i < citizens.Length; i++)
                {
                    if (citizens[i] is Retiree)
                    {
                        lastRetireeCitizenIndex = i;
                    }
                }

                var newCitizens = new Citizen[Count + 1];
                Array.Copy(citizens, newCitizens, lastRetireeCitizenIndex + 1);
                newCitizens[lastRetireeCitizenIndex + 1] = newCitizen;
                Array.Copy(citizens, lastRetireeCitizenIndex + 1, newCitizens, 
                    lastRetireeCitizenIndex + 1, Count - (lastRetireeCitizenIndex + 1));

                citizens = newCitizens;

                return lastRetireeCitizenIndex + 1;
            }
            else
            {
                var newCitizens = new Citizen[Count + 1];
                Array.Copy(citizens, newCitizens, Count);

                citizens = newCitizens;

                return Count;
            }
        }

        public void Remove()
        {
            var citizensAfterRemove = new Citizen[Count - 1];
            Array.Copy(citizens, 1, citizensAfterRemove, 0, Count-1);
            citizens = citizensAfterRemove;
        }

        public void Remove(Citizen citizen)
        {
            var citizensAfterRemove = new Citizen[Count - 1];
            if (!Contains(citizen, out int indexOfRemovableCitizen))
            {
                throw new CitizenNotFoundException();
            }

            Array.Copy(citizens, citizensAfterRemove, indexOfRemovableCitizen);
            Array.Copy(citizens, indexOfRemovableCitizen + 1, citizensAfterRemove, 
                indexOfRemovableCitizen, Count - (indexOfRemovableCitizen + 1));

            citizens = citizensAfterRemove;
        }

        public bool Contains(Citizen citizen, out int index)
        {
            for (int i = 0; i < citizens.Length; i++)
            {
                if (citizens[i].Equals(citizen))
                {
                    index = i;
                    return true;
                }
            }

            index = -1;
            return false;
        }

        public Citizen ReturnLast(out int index)
        {
            if (citizens.Length == 0)
            {
                throw new CitizenCollectionEmptyException();
            }

            index = Count - 1;
            return citizens[Count - 1];
        }

        public void Clear()
        {
            citizens = new Citizen[0];
        }

        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator;
        }

        public bool MoveNext()
        {
            if (position < citizens.Length - 1)
            {
                position++;
                return true;
            }

            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
