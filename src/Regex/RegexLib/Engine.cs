using System;
using System.Collections.Generic;
using System.Text;

namespace RegexLib
{
    class Engine
    {
        // concat two NFAs
        public NFA Concat(NFA first, NFA second)
        {
            first.end.addEpsilonTransition(second.end);
            first.end.setIsEnd(false);
            NFA concated = new NFA(first.start, second.end);
            return concated;
        }
        // union two NFAs
        public NFA Union(NFA first, NFA second)
        {
            State start = new State(false);
            State end = new State(true);

            start.addEpsilonTransition(first.start);
            end.addEpsilonTransition(second.start);

            first.end.addEpsilonTransition(end);
            first.end.setIsEnd(false);
            second.end.addEpsilonTransition(end);
            second.end.setIsEnd(false);

            NFA unioned = new NFA(start, end);
            return unioned;
        }
        // closure nfa
        public NFA Closure(NFA nfa)
        {
            State start = new State(false);
            State end = new State(true);

            start.addEpsilonTransition(end);
            start.addEpsilonTransition(nfa.start);

            nfa.end.addEpsilonTransition(end);
            nfa.end.addEpsilonTransition(nfa.start);
            nfa.end.setIsEnd(false);

            NFA closured = new NFA(start, end);
            return closured;
        }
        // postfixExp to NFA
        public NFA TransiteToFNA(String postfixExp)
        {
            if (postfixExp.Length == 0)
            {
                return new EpsilonNFA();
            }

            Stack<NFA> stack = new Stack<NFA>();
            foreach (Char token in postfixExp){
                if (token == '*')
                {
                    stack.Push(Closure(stack.Pop()));
                } else if (token == '|')
                {
                    NFA right = stack.Pop();
                    NFA left = stack.Pop();
                    stack.Push(Union(left, right));
                } else if (token == '.')
                {
                    NFA right = stack.Pop();
                    NFA left = stack.Pop();
                    stack.Push(Concat(left, right));
                } else
                {
                    stack.Push(new SymbolNFA(token));
                }
            }

            return stack.Pop();
        }
    }
}
