using System;

namespace Lab4
{
    class ClockFunctionality <T> where T : IInfo<Person>, ITime
    {
        private int[] time = new int[3];
        public void Timer(Clock<Person> clock, string endtime)
        {
            bool isEnd = false;
            if (CheckForCorrect(endtime))
            {
                GetHourMiniteSecond(endtime);
                int hour = time[0];
                int minute = time[1];
                int seconds = time[2];
                while (isEnd != true)
                {
                    clock.SetCurrentTime();
                    if (clock.DateTime.Hour == hour && clock.DateTime.Minute == minute && clock.DateTime.Second == seconds)
                    {
                        Console.WriteLine("ALARM! ALARM! ALARM! ALARM! ALARM!");
                        isEnd = true;
                    }
                }
            }
        }
        private void GetHourMiniteSecond(string date)
        {
            var DateTime = date.Split(':');
            if (DateTime.Length == 3)
                for (int i = 0; i < 3; ++i)
                    time[i] = Int32.Parse(DateTime[i]);
        }
        private bool CheckForCorrect(string date)
        {
            string[] dateTime = date.Split(':');
            if (dateTime.Length != 3)
            {
                Console.WriteLine("Input time Error Count.");
                return false;
            }
            else
            {
                int hour = Int32.Parse(dateTime[0]);
                int minute = Int32.Parse(dateTime[1]);
                int seconds = Int32.Parse(dateTime[2]);
                if ((hour > -1 && hour < 24) && (minute > -1 && minute < 60) && (seconds > -1 && seconds < 60))
                    return true;
                else
                {
                    Console.WriteLine("Input time Error.");
                    return false;
                }
            }
        }
    }
}
