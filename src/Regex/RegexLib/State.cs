using System;
using System.Collections.Generic;
using System.Text;

namespace RegexLib
{
    // Nondeterministic Finite Automata State
    class State
    {
        // define whether this state is an accepting state
        Boolean isEnd;
        // transition by input character
        Dictionary<Char, State> transition;
        // transition with empty string
        List<State> epsilonTransitions;
        // creation
        public State(Boolean isEnd)
        {
            this.isEnd = isEnd;
            this.transition = new Dictionary<Char, State>();
            this.epsilonTransitions = new List<State>();
        }
        // add transition
        public void addTransition(Char symbol, State to)
        {
            this.transition.Add(symbol, to);
        }
        // add epsilon transition
        public void addEpsilonTransition(State to)
        {
            this.epsilonTransitions.Add(to);
        }
        // set isEnd
        public void setIsEnd(Boolean isEnd)
        {
            this.isEnd = isEnd;
        }
    }
}
