using System;
using System.Collections.Generic;

namespace regex {
    class State {
        private Boolean _isEnd;
        private Dictionary<String, State> _transition;
        private List<State> _epsilonTransitions;
        public void State (Boolean isEnd) {
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
}