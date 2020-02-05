using System;
using static ExpertSystem.toolbox;
using System.Collections.Generic;
using System.Collections;

namespace ExpertSystem
{
    public class FactRepository
    {
        public static List<Fact> factList = new List<Fact>();
        public FactRepository()
        {
            FactEnumerator factEnumerator = new FactEnumerator();
        }

        public void AddFact(Fact fact)
        {
            factList.Add(fact);
        }
        public IEnumerator<Fact> GetEnumerator()
        {
            return new FactEnumerator();
        }
        public class FactEnumerator : IEnumerator<Fact>
        {
            int index = -1;

            object IEnumerator.Current => throw new NotImplementedException();

            Fact IEnumerator<Fact>.Current => throw new NotImplementedException();

            public void Dispose()
            {
            }
            public Fact Current
            {
                get
                {
                    return factList[index];
                }
            }
            public bool MoveNext()
            {
                index++;
                return index < factList.Count;
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new InvalidOperationException();
            }
        }
    }
}
