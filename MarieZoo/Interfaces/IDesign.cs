using System;
using System.Collections.Generic;
using System.Text;

namespace MarieZoo.Mammals
{
    interface IDesign
    {
        decimal LengthInInches { get; }
        string Color { get; }

        string LegsOrFins { get; }

        string Movement { get; }
    }
}
