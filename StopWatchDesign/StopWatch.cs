using System;

namespace StopWatch
{
    public static class StopWatch
    {
        private static bool _isStopClicked = true ;
        private static TimeSpan _startTime;
        private static TimeSpan _endTime;


        public static TimeSpan Start()
        {
            
                if (_isStopClicked == false)
                {
                    throw new InvalidOperationException("The stopwatch is still running!!");

                }

                _isStopClicked = false;
                _startTime = DateTime.Now.TimeOfDay;
                return _startTime;

            
            
           
        }

        public static TimeSpan Stop()
        {
            if (_isStopClicked == true)
            {
                throw new InvalidOperationException("The stopwatch isn't working!");
            }
            _isStopClicked = true;
            _endTime = DateTime.Now.TimeOfDay;
            return _endTime;

        }


        public static TimeSpan Duration()
        {
            return (_endTime - _startTime);

        }


    }
}
