using Animals.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCode_Animals.Library
{
    class BlueBird : Bird
    {

        public BlueBird() : base(wingSpan : 3)   // S.O.L.I.D and/or OOP Principles used
        {                                       // LISKOV SUBSTITUTION => BlueBird can be used in any place that the parent Class (Bird) can
                                                // Inheritance


        }

        public override void MakeSound()
        {
            // Add extra behavior before
            base.MakeSound();
            // Add extra behavior after as well
        }
    }
}
