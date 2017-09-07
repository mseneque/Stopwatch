using System;

namespace StopWatch
{
    public class Stopwatch
    {
        public enum State { Stopped, Timing }

        public State Status { get; private set; }
        private DateTime _startTime;

        public Stopwatch()
        {
            Status = State.Stopped;
        }

        private TimeSpan _Start()
        {
            _startTime = DateTime.Now;
            Status = State.Timing;
            return _startTime - _startTime;
        }

        private TimeSpan _Stop()
        {
            Status = State.Stopped;
            return DateTime.Now - _startTime;
        }

        public TimeSpan StartStop()
        {
            return Status == State.Stopped ? _Start() : _Stop();
        }
    }
}
