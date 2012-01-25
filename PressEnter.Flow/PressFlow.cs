using System;
using System.Collections.Generic;
using System.Text;

namespace PressEnter.Flow
{
    public class PressFlow
    {
        Dictionary<string, Dictionary<string, string>> _stateChanges = new Dictionary<string, Dictionary<string, string>>();
        Dictionary<string, PressState> _stateDescr = new Dictionary<string, PressState>();

        private List<String> _buttons  = new List<string>();

        public List<String> Buttons
        {
            get { return _buttons; }
            set { _buttons = value; }
        }
        private string _initialState;
        private string _currentState;

        public string CurrentState
        {
            get { return _currentState; }
            set { _currentState = value; }
        }

        public string InitialState
        {
            get { return _initialState; }
            set { _initialState = value; }
        }
    
        public static PressFlow Load()
        {
            throw new System.NotImplementedException();
        }

        public static PressFlow LoadString(string path) {
            PressFlow flow = new PressFlow();

        }

        public static PressFlow DoLoad() {
            PressFlow p = new PressFlow();
            p._buttons.Add("b1");
            p._buttons.Add("b2");

            p.AddState("state1", new ImageState("file"));
            p.AddState("state2", new AnimationState("file2", 50));
            p.AddTransition("state1", "b2", "state2");
            p.AddTransition("state2", "b1", "state1");

            p.SetInitial("state1");

            return p;
        }

        public void AddState(string name, PressState state) {
            _stateChanges.Add(name, new Dictionary<string, string>());
            _stateDescr.Add(name, state);
        }
        public void AddTransition(string start, string act, string end) {

            _stateChanges[start][act] = end;
        }

        private void SetInitial(string state)
        {
            _initialState = state;
            _currentState = state;
        }

        public void SendEvent(string p)
        {
            if (_stateChanges.ContainsKey(_currentState))
                if (_stateChanges[_currentState].ContainsKey(p))
                {
                    _currentState = _stateChanges[_currentState][p];
                    if (StateChanged != null)
                        StateChanged(_currentState, new EventArgs());
                }
        }
        public event EventHandler StateChanged;
    }
}
