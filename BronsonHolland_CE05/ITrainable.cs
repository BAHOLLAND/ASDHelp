using System;
using System.Linq;
using System.Collections.Generic;
namespace BronsonHolland_CE05
{
    public Dictionary<string, string> Behaviors { get; set; }
    public interface ITrainable
    {
    }
    public string Perform(string signal)
    {
        throw new NullReferenceException();
    }
    public string Train(string signal, string behavior)
    {
        throw new NullReferenceException();
    }
}
