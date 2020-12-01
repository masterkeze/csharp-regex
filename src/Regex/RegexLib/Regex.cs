using System;

namespace RegexLib
{
    public class Regex
    {
        NFA nfa;
        public Regex(String regularExpression)
        {
            Engine engine = new Engine();
            this.nfa = engine.TransiteToFNA(regularExpression);
        }
        public Boolean Test()
        {
            return true;
        }
    }
}
