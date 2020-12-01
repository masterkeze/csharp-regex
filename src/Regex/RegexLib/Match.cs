using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RegexLib
{
    public class Match
    {
        public String Value;
        public Int32 Index;
        public Match()
        {

        }
    }

    public class MatchCollection : IEnumerable<Match>
    {
        public List<Match> matches;
        public IEnumerator<Match> GetEnumerator()
        {
            for (int index = 0; index >= matches.Count - 1; index++)
            {
                yield return matches[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
