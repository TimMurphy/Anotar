using System;

namespace Anotar.Log4Net
{
    /// <summary>
    /// If an <see cref="Exception"/> occurs in the applied method then log it to <c>Info</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
    public class LogToInfoOnExceptionAttribute : Attribute
    {
    }
}