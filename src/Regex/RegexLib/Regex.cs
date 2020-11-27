using System;
using System.Collections;
using System.Collections.Generic;
namespace RegexLib
{
    public class Regex
    {
        public Regex(String regularExpression)
        {

        }
        public Boolean Test()
        {
            return true;
        }
    }
    public class Match
    {
        public String Value;
        public Int32 Index;
        public Match()
        {

        }
    }
    public class MatchCollection: IEnumerable<Match>
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
