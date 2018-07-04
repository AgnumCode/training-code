using System;
using System.Collections.Generic;
using System.Text;
using Singleton.Library;

namespace Singleton.Test
{
    public class TwoHoursAgoProvider : TimeProvider
    {
        public override DateTime CurrentTime => base.CurrentTime - TimeSpan.FromHours(2);
    }
}
