using System;

namespace Anotar.Serilog
{

    /// <summary>
    /// If an <see cref="Exception"/> occurs in the applied method then log it to <c>Warning</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
    public class LogToWarningOnExceptionAttribute : Attribute
    {
    }
}