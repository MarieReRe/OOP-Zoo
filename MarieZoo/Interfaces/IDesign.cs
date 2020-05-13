using System;
using System.Collections.Generic;
using System.Text;

namespace MarieZoo.Interfaces
{
    interface IDesign
    {
        decimal LengthInInches { get; }
        string Color { get; }

        string LegsOrFins { get; }

        string Movement { get; }
    }
}
