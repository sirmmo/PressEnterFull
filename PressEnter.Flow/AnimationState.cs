using System;
using System.Collections.Generic;
using System.Text;

namespace PressEnter.Flow
{
    public class AnimationState : PressState
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _time;

        public int Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public AnimationState(string name, int time)
        {
            Name = name;
            Time = time;
        }
    }
}
