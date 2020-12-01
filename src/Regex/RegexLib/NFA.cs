using System;
using System.Collections.Generic;
using System.Text;

namespace RegexLib
{
    // group two states into a NFA
    class NFA
    {
        public State start;
        public State end;

        // initialize with two states
        public NFA()
        {
            this.start = new State(false);
            this.end = new State(true);
        }
        public NFA(State first, State sencond)
        {
            this.start = first;
            this.end = sencond;
        }
    }
    // Epsilon-NFA
    class EpsilonNFA : NFA
    {
        // initialize with an epsilon transition
        public EpsilonNFA() : base()
        {
            this.start.addEpsilonTransition(this.end);
        }
    }
    // Symbol-NFA
    class SymbolNFA : NFA
    {
        // initialize with a symbol transition
        public SymbolNFA(Char symbol) : base()
        {
            this.start.addTransition(symbol, this.end);
        }
    }
}
