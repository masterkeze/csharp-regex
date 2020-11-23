using System;
using System.Collections.Generic;

namespace FSM {
    class State {
        private Boolean _isEnd;
        private Dictionary<String, State> _transition;
        private List<State> _epsilonTransitions;
        public State (Boolean isEnd) {
            this._isEnd = isEnd;
            this._transition = new Dictionary<String, State> ();
            this._epsilonTransitions = new List<State> ();
        }
        public void addTransition (State to, String symbol) {
            this._transition[symbol] = to;
        }
        public void addEpsilonTransition (State to) {
            this._epsilonTransitions.Add(to);
        }
    }
    class Basis {
        public State startState;
        public State endState;
        public Basis(){
            this.startState = new State(false);
            this.endState = new State(true);
        }
    }
    class SymbolBasis : Basis {
        public SymbolBasis(String symbol) : base(){
            this.startState.addTransition(this.endState,symbol);
        }
    }
    class EpsilonBasis : Basis {
        public EpsilonBasis() : base(){;
            this.startState.addEpsilonTransition(this.endState);
        }
    }
}