using System;

namespace StopWatch
{
    enum State { stopped, timing }

    public class Stopwatch
    {
        private DateTime _startTime;

        private State _state;

        public String Status
        {
            get
            {
                return _state.ToString();
            }
        }

        public Stopwatch()
        {
            _state = State.stopped;
        }


        private TimeSpan _Start()
        {
            _startTime = DateTime.Now;
            _state = State.timing;
            return _startTime - _startTime;
        }

        private TimeSpan _Stop()
        {
            _state = State.stopped;
            return DateTime.Now - _startTime;
        }

        public TimeSpan StartStop()
        {
            if (_state == State.stopped)
                return _Start();
            return _Stop();
        }



    }
}
