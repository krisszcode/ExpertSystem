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

        public List<Fact> addide()
        {
            return factList;
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

            public Fact Current
            {
                get
                {
                    try
                    {
                        return factList[index];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    try
                    {
                        return factList[index];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }


            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                index++;
                return index < factList.Count;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
                        