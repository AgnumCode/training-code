using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library2
{
    public interface IAnimal
    {
        string Name { get; set; }
        void MakeSound();
        void GoToLocation(string location);
    }
}
