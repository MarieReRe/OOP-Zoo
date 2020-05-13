using System;
using System.Collections.Generic;
using System.Text;

namespace MarieZoo.Mammals
{
    interface IEnvironment
    {
        string Predators { get; }

        string FunFact { get; }
    }
}
