using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Library
{
    public class History
    {
        private readonly Stack<DateTime> records = new Stack<DateTime>();

        /// <summary>
        /// make a new record at the current time
        /// </summary>

        public void Record()
        {
            records.Push(TimeProvider.Current.CurrentTime);
        }


        /// <summary>
        /// check if the most recent record is older than one hour
        /// </summary>
        /// <returns> true if the newest record is too old</returns>
        public bool IsOutdated()
        {
            DateTime newestRecord = records.Peek();
            //var currentTime = DateTime.Now;
            DateTime currentTime = TimeProvider.Current.CurrentTime;
            TimeSpan diff = currentTime - newestRecord;
            return diff >= TimeSpan.FromHours(1); // waiting for 1 hour
        }
    }
}
