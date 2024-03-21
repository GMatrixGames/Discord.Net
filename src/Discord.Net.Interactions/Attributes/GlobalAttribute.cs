using System;

namespace Discord.Interactions
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class GlobalAttribute : Attribute
    {
    }
}