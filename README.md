![Icon](https://raw.github.com/Fody/Anotar/master/Icons/package_icon.png)

## This is an add-in for  [Fody](https://github.com/Fody/Fody) 

Simplifies logging through a static class and some IL manipulation

[Introduction to Fody](https://github.com/Fody/Fody/wiki/SampleUsage)

## Supported Logging Libraries

* [Catel](http://www.catelproject.com/)
* Custom (for frameworks/toolkits with custom logging)
* [CommonLogging](http://netcommon.sourceforge.net/)
* [LibLog](https://github.com/damianh/LibLog) 
* [Log4Net](http://logging.apache.org/log4net/) 
* [MetroLog](https://github.com/mbrit/MetroLog)
* [NLog](http://nlog-project.org/) 
* [NServiceBus](http://particular.net/nservicebus) 
* [Serilog](http://serilog.net/)
* [Splat](https://github.com/paulcbetts/splat)

## Nuget
  
 * Catel package http://nuget.org/packages/Anotar.Catel.Fody [![NuGet Status](http://img.shields.io/nuget/v/Anotar.Catel.Fody.svg?style=flat)](https://www.nuget.org/packages/Anotar.Catel.Fody/)

    PM> Install-Package Anotar.Catel.Fody
 
 * CommonLogging package http://nuget.org/packages/Anotar.CommonLogging.Fody [![NuGet Status](http://img.shields.io/nuget/v/Anotar.CommonLogging.Fody.svg?style=flat)](https://www.nuget.org/packages/Anotar.CommonLogging.Fody/)

    PM> Install-Package Anotar.CommonLogging.Fody
 
 * Custom package http://nuget.org/packages/Anotar.Custom.Fody [![NuGet Status](http://img.shields.io/nuget/v/Anotar.Custom.Fody.svg?style=flat)](https://www.nuget.org/packages/Anotar.Custom.Fody/)

    PM> Install-Package Anotar.Custom.Fody

 * LibLog package http://nuget.org/packages/Anotar.LibLog.Fody [![NuGet Status](http://img.shields.io/nuget/v/Anotar.LibLog.Fody.svg?style=flat)](https://www.nuget.org/packages/Anotar.LibLog.Fody/)

    PM> Install-Package Anotar.LibLog.Fody

 * Log4Net package http://nuget.org/packages/Anotar.Log4Net.Fody [![NuGet Status](http://img.shields.io/nuget/v/Anotar.Log4Net.Fody.svg?style=flat)](https://www.nuget.org/packages/Anotar.Log4Net.Fody/)

    PM> Install-Package Anotar.Log4Net.Fody
 
 * MetroLog package http://nuget.org/packages/Anotar.MetroLog.Fody [![NuGet Status](http://img.shields.io/nuget/v/Anotar.MetroLog.Fody.svg?style=flat)](https://www.nuget.org/packages/Anotar.MetroLog.Fody/)

    PM> Install-Package Anotar.MetroLog.Fody

 * NLog package http://nuget.org/packages/Anotar.NLog.Fody [![NuGet Status](http://img.shields.io/nuget/v/Anotar.NLog.Fody.svg?style=flat)](https://www.nuget.org/packages/Anotar.NLog.Fody/)

    PM> Install-Package Anotar.NLog.Fody
 
 * NServiceBus package http://nuget.org/packages/Anotar.NServiceBus.Fody [![NuGet Status](http://img.shields.io/nuget/v/Anotar.NServiceBus.Fody.svg?style=flat)](https://www.nuget.org/packages/Anotar.NServiceBus.Fody/)

    PM> Install-Package Anotar.NServiceBus.Fody
 
 * Serilog package http://nuget.org/packages/Anotar.Serilog.Fody [![NuGet Status](http://img.shields.io/nuget/v/Anotar.Serilog.Fody.svg?style=flat)](https://www.nuget.org/packages/Anotar.Serilog.Fody/)

    PM> Install-Package Anotar.Serilog.Fody
 
 * Splat package http://nuget.org/packages/Anotar.Splat.Fody [![NuGet Status](http://img.shields.io/nuget/v/Anotar.Splat.Fody.svg?style=flat)](https://www.nuget.org/packages/Anotar.Splat.Fody/)

    PM> Install-Package Anotar.Splat.Fody
 
## Explicit Logging


### Your Code

```
public class MyClass
{
    void MyMethod()
    {
        LogTo.Debug("TheMessage");
    }
}
```

### What gets compiled

#### In Catel

```
public class MyClass
{
    static ILog logger = LogManager.GetLogger(typeof(MyClass));

    void MyMethod()
    {
        logger.WriteWithData("Method: 'Void MyMethod()'. Line: ~12. TheMessage", null, LogEvent.Debug);
    }
}
```

#### In CommonLogging

```
public class MyClass
{
    static ILog logger = LoggerManager.GetLogger("MyClass");

    void MyMethod()
    {
        logger.Debug("Method: 'Void MyMethod()'. Line: ~12. TheMessage");
    }
}
```

#### In Custom

```
public class MyClass
{
    static ILogger AnotarLogger = LoggerFactory.GetLogger<MyClass>();

    void MyMethod()
    {
        AnotarLogger.Debug("Method: 'Void MyMethod()'. Line: ~12. TheMessage");
    }
}
```

#### In LibLog

```
public class MyClass
{
    static ILog logger = LogProvider.GetLogger("MyClass");

    void MyMethod()
    {
        logger.Debug("Method: 'Void MyMethod()'. Line: ~12. TheMessage");
    }
}
```

#### In Log4Net

```
public class MyClass
{
    static ILog logger = LogManager.GetLogger("MyClass");

    void MyMethod()
    {
        logger.Debug("Method: 'Void MyMethod()'. Line: ~12. TheMessage");
    }
}
```

#### In MetroLog

```
public class MyClass
{
    static ILogger logger = LogManagerFactory.DefaultLogManager.GetLogger("MyClass");

    void MyMethod()
    {
        logger.Debug("Method: 'Void :MyMethod()'. Line: ~24. TheMessage");
    }
}
```

#### In NLog

```
public class MyClass
{
    static Logger logger = LogManager.GetLogger("MyClass");

    void MyMethod()
    {
        logger.Debug("Method: 'Void MyMethod()'. Line: ~12. TheMessage");
    }
}
```

#### In NServiceBus

```
public class MyClass
{
    static ILog logger = LogManager.GetLogger("MyClass");

    void MyMethod()
    {
        logger.DebugFormat("Method: 'Void MyMethod()'. Line: ~12. TheMessage");
    }
}
```

#### In Serilog

```
public class MyClass
{
    static ILogger logger = Log.ForContext<MyClass>();

    void MyMethod()
    {
		if (logger.IsEnabled(LogEventLevel.Debug))
		{
			logger
				.ForContext("MethodName", "Void MyMethod()")
				.ForContext("LineNumber", 8)
				.Debug("TheMessage");
		}
    }
}
```

#### In Splat

```
public class MyClass
{
    static IFullLogger logger = ((ILogManager) Locator.Current.GetService(typeof(ILogManager), null))
								.GetLogger(typeof(ClassWithLogging));

    void MyMethod()
    {
        logger.Debug("Method: 'Void MyMethod()'. Line: ~12. TheMessage");
    }
}
```

### Other Log Overloads in Explicit Logging

There are also appropriate methods for Warn, Info, Error etc as applicable to each of the logging frameworks. 

Each of these methods has the expected 'message', 'params' and 'exception' overloads. 

## Checking logging level

The `LogTo` class also has `IsLevelEnabled` properties that redirect to the respective level enabled checks in each framework. 

### Your code

```
public class MyClass
{
    void MyMethod()
    { 
        if (LogTo.IsDebugEnabled)
        {
            LogTo.Debug("TheMessage");
        }
    }
}
```

### What gets compiled

```
public class MyClass
{
    static Logger logger = LogManager.GetLogger("MyClass");

    void MyMethod()
    {
        if (logger.IsDebugEnabled)
        {
            logger.Debug("Method: 'Void MyMethod()'. Line: ~12. TheMessage");
        }
    }
}
```
 
## Delegate Logging

All the `LogTo` methods have equivalent overloads that accept a `Func<string>` instead of a string. This delegate is used to construct the message and should be used when that message construction is resource intensive. At compile time the logging will be wrapped in a `IsEnabled` check so as to only incur the cost if that level of logging is required.

### Your code

```
public class MyClass
{
    void MyMethod()
    { 
        LogTo.Debug(()=>"TheMessage");
    }
}
```

### What gets compiled

```
public class MyClass
{
    static Logger logger = LogManager.GetLogger("MyClass");

    void MyMethod()
    {
        if (logger.IsDebugEnabled)
        {
            Func<string> messageConstructor = () => "TheMessage";
            logger.Debug("Method: 'Void DebugStringFunc()'. Line: ~58. " + messageConstructor());
        }
    }
}
```

## Exception logging
    
### Your code

    [LogToErrorOnException]
    void MyMethod(string param1, int param2)
    {
        //Do Stuff
    }
    
### What gets compiled

#### In NLog

```
void MyMethod(string param1, int param2)
{
    try
    {
        //Do Stuff
    }
    catch (Exception exception)
    {
        if (logger.IsErrorEnabled)
        {
            var message = string.Format("Exception occurred in SimpleClass.MyMethod. param1 '{0}', param2 '{1}'", param1, param2);
            logger.ErrorException(message, exception);
        }
        throw;
    }
}
```


## Custom logging

The custom logging variant exist for several reasons

  1. Projects targeting an obscure logging libraries i.e. not NLog, MetroLog, SeriLog or Log4Net. Or wraps a logging library with a custom API.
  2. Projects that have their own logging custom logging libraries
  3. Projects that support multiple different logging libraries
  
It works by allowing you to have custom logger construction and a custom logger instance.

### Expected factory and instance formats

#### Factory

The Logger Factory is responsible for building an instance of a logger. 

  * Named `LoggerFactory`.
  * Namespace doesnt matter.
  * Have a static method GetLogger. 
  
For example

    public class LoggerFactory
    {
        public static Logger GetLogger<T>()
        {
            return new Logger();
        }
    }
    
#### Instance

The Logger instance is responsible for building an instance of a logger. 

  * Name doesn't matter. It will be derived from the return type of `LoggerFactory.GetLogger`.
  * Must not be generic.
  * Namespace doesn't matter.
  * Can be either an interface, a concrete class or an abstract class.
  * Can contain the members listed below. All members are optional. However an build error will be thrown if you attempt to use one of the members that doesn't exist. So for example if you call `LogTo.Debug` and `Logger.Debug` (with the same parameters) doesn't.
  
For example

```
public class Logger
{
    public void Debug(string format, params object[] args){}
    public void Debug(Exception exception, string format, params object[] args){}
    public bool IsDebugEnabled { get; private set; }
    public void Information(string format, params object[] args){}
    public void Information(Exception exception, string format, params object[] args){}
    public bool IsInformationEnabled { get; private set; }
    public void Warning(string format, params object[] args){}
    public void Warning(Exception exception, string format, params object[] args){}
    public bool IsWarningEnabled { get; private set; }
    public void Error(string format, params object[] args){}
    public void Error(Exception exception, string format, params object[] args){}
    public bool IsErrorEnabled { get; private set; }
    public void Fatal(string format, params object[] args){}
    public void Fatal(Exception exception, string format, params object[] args){}
    public bool IsFatalEnabled { get; private set; }
}
```
        
### Discovery

#### Current Assembly

If `LoggerFactory` and `Logger` exist in the current assembly they will be picked up automatically.

#### Other Assembly

If `LoggerFactory` and `Logger` exist in a different assembly You will need to use a `[LoggerFactoryAttribute]` to tell Anotar where to look.

    [assembly: LoggerFactoryAttribute(typeof(MyUtilsLibrary.LoggerFactory))]


## Nothing to deploy

After compilation the reference to the Anotar assemblies will be removed so you don't need to deploy the assembly.
    
## But why? What purpose does this serve?

### 1. Dont make me think

When I am coding I often want to quickly add a line of logging code. If I dont already have the static `logger` field I have to jump back to the top of the file to add it. This breaks my train of thought. I know this is minor but it is still an annoyance. Static logging methods are much less disruptive to call.

### 2. I want some extra information

Often when I am logging I want to know the method and line number I am logging from. I don't want to manually add this. So using IL I just prefix the message with the method name and line number. Note that the line number is prefixed with '~'. The reason for this is that a single line of code can equate to multiple IL instructions. So I walk back up the instructions until I find one that has a line number and use that. Hence it is an approximation.

## I don't want extra information

If you don't want the extra information, method name and line number, then add this to AssemblyInfo.cs:

    [assembly: LogMinimalMessage]

## Why not use CallerInfoAttributes

The CallerInfoAttributes consist of  [CallerLineNumberAttribute](http://msdn.microsoft.com/en-us/library/system.runtime.compilerservices.callerlinenumberattribute.aspx),  [CallerFilePathAttribute](http://msdn.microsoft.com/en-us/library/system.runtime.compilerservices.callerfilepathattribute.aspx) and [CallerMemberNameAttribute](http://msdn.microsoft.com/en-us/library/system.runtime.compilerservices.callermembernameattribute.aspx). The allow you to pass information about the caller method to the callee method. 

So some of this could be achieved using these attributes however there are a couple of points that complicate things.

### 1. Only .net 4.5 and up

So this makes it a little difficult to use with other runtimes.

### 2. Cant be used when passing arrays as `params`

Logging APIs all make use of `params` to pass arguments to a `string.Format`. Since you cant use `params` with CallerInfoAttributes most logging APIs choose not to use these attributes.

You can vote for [Compatibility between `params` with CallerInfoAttributes](http://visualstudio.uservoice.com/forums/121579-visual-studio/suggestions/2762025-caller-membername-filepath-linenumber-of-net-4-5-) 
    
## Icon

Icon courtesy of [The Noun Project](http://thenounproject.com)
