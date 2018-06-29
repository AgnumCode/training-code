using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class BlueRobin : Bird
    {
        public BlueRobin() : base(4)
        {

        }

        public override void MakeSound()
        {
            //add extra behavior before
            base.MakeSound();
            //add etra behavior after
        }
    }
}
