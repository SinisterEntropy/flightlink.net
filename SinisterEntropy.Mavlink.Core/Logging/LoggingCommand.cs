using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinisterEntropy.Mavlink.Core.Logging
{
	public class LoggingCommand : NLog.ILogger
	{
		public const string Target = "console";

		static LoggingCommand()
		{
			// Step 1. Create configuration object 
			var config = new LoggingConfiguration();

			// Step 2. Create targets and add them to the configuration
			var consoleTarget = new ColoredConsoleTarget();

			config.AddTarget(Target, consoleTarget);

			// Step 3. Set target properties 
			consoleTarget.Layout = @"${date:format=HH\:mm\:ss} ${logger} ${message}";

			// Step 4. Define rules
			var rule1 = new LoggingRule("*", LogLevel.Debug, consoleTarget);
			config.LoggingRules.Add(rule1);

			LogManager.Configuration = config;
		}

		public void Debug(string message, ulong argument)
		{
			LogManager.GetLogger(Target).Debug(message, argument);
		}

		public void Debug(IFormatProvider formatProvider, string message, ulong argument)
		{
			LogManager.GetLogger(Target).Debug(formatProvider, message, argument);
		}

		public void Debug(string message, uint argument)
		{
			LogManager.GetLogger(Target).Debug(message, argument);
		}

		public void Debug(IFormatProvider formatProvider, string message, uint argument)
		{
			LogManager.GetLogger(Target).Debug(formatProvider, message, argument);
		}

		public void Debug(string message, sbyte argument)
		{
			LogManager.GetLogger(Target).Debug(message, argument);
		}

		public void Debug(IFormatProvider formatProvider, string message, sbyte argument)
		{
			LogManager.GetLogger(Target).Debug(formatProvider, message, argument);
		}

		public void Debug(string message, object argument)
		{
			LogManager.GetLogger(Target).Debug(message, argument);
		}

		public void Debug(IFormatProvider formatProvider, string message, object argument)
		{
			LogManager.GetLogger(Target).Debug(formatProvider, message, argument);
		}

		public void Debug(string message, decimal argument)
		{
			LogManager.GetLogger(Target).Debug(message, argument);
		}

		public void Debug(IFormatProvider formatProvider, string message, decimal argument)
		{
			LogManager.GetLogger(Target).Debug(formatProvider, message, argument);
		}

		public void Debug(string message, double argument)
		{
			LogManager.GetLogger(Target).Debug(message, argument);
		}

		public void Debug(IFormatProvider formatProvider, string message, double argument)
		{
			LogManager.GetLogger(Target).Debug(formatProvider, message, argument);
		}

		public void Debug(string message, float argument)
		{
			LogManager.GetLogger(Target).Debug(message, argument);
		}

		public void Debug(IFormatProvider formatProvider, string message, float argument)
		{
			LogManager.GetLogger(Target).Debug(formatProvider, message, argument);
		}

		public void Debug(string message, long argument)
		{
			LogManager.GetLogger(Target).Debug(message, argument);
		}

		public void Debug(IFormatProvider formatProvider, string message, long argument)
		{
			LogManager.GetLogger(Target).Debug(formatProvider, message, argument);
		}

		public void Debug(string message, int argument)
		{
			LogManager.GetLogger(Target).Debug(message, argument);
		}

		public void Debug(IFormatProvider formatProvider, string message, int argument)
		{
			LogManager.GetLogger(Target).Debug(formatProvider, message, argument);
		}

		public void Debug(string message, string argument)
		{
			LogManager.GetLogger(Target).Debug(message, argument);
		}

		public void Debug(IFormatProvider formatProvider, string message, string argument)
		{
			LogManager.GetLogger(Target).Debug(formatProvider, message, argument);
		}

		public void Debug(string message, byte argument)
		{
			LogManager.GetLogger(Target).Debug(message, argument);
		}

		public void Debug(IFormatProvider formatProvider, string message, byte argument)
		{
			LogManager.GetLogger(Target).Debug(formatProvider, message, argument);
		}

		public void Debug(string message, char argument)
		{
			LogManager.GetLogger(Target).Debug(message, argument);
		}

		public void Debug(IFormatProvider formatProvider, string message, char argument)
		{
			LogManager.GetLogger(Target).Debug(formatProvider, message, argument);
		}

		public void Debug(string message, bool argument)
		{
			LogManager.GetLogger(Target).Debug(message, argument);
		}

		public void Debug(IFormatProvider formatProvider, string message, bool argument)
		{
			LogManager.GetLogger(Target).Debug(formatProvider, message, argument);
		}

		public void Debug(string message, object arg1, object arg2, object arg3)
		{
			LogManager.GetLogger(Target).Debug(message, arg1, arg2, arg3);
		}

		public void Debug(string message, object arg1, object arg2)
		{
			LogManager.GetLogger(Target).Debug(message, arg1, arg2);
		}

		public void Debug(IFormatProvider formatProvider, object value)
		{
			LogManager.GetLogger(Target).Debug(formatProvider, value);
		}

		public void Debug(object value)
		{
			LogManager.GetLogger(Target).Debug(value);
		}

		public void Debug<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			LogManager.GetLogger(Target).Debug<TArgument1, TArgument2, TArgument3>(message, argument1, argument2, argument3);
		}

		public void Debug<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			LogManager.GetLogger(Target).Debug<TArgument1, TArgument2, TArgument3>(formatProvider, message, argument1, argument2, argument3);
		}

		public void Debug<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
		{
			LogManager.GetLogger(Target).Debug<TArgument1, TArgument2>(message, argument1, argument2);
		}

		public void Debug<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2)
		{
			LogManager.GetLogger(Target).Debug<TArgument1, TArgument2>(formatProvider, message, argument1, argument2);
		}

		public void Debug<TArgument>(string message, TArgument argument)
		{
			LogManager.GetLogger(Target).Debug<TArgument>(message, argument);
		}

		public void Debug<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
		{
			LogManager.GetLogger(Target).Debug<TArgument>(formatProvider, message, argument);
		}

		public void Debug(string message, Exception exception)
		{
			LogManager.GetLogger(Target).Debug(message, exception);
		}

		public void Debug(string message, params object[] args)
		{
			LogManager.GetLogger(Target).Debug(message, args);
		}

		public void Debug(string message)
		{
			LogManager.GetLogger(Target).Debug(message);
		}

		public void Debug(IFormatProvider formatProvider, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Debug(formatProvider, message, args);
		}

		public void Debug(Exception exception, IFormatProvider formatProvider, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Debug(exception, formatProvider, message, args);
		}

		public void Debug(Exception exception, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Debug(exception, message, args);
		}

		public void Debug(LogMessageGenerator messageFunc)
		{
			LogManager.GetLogger(Target).Debug(messageFunc);
		}

		public void Debug<T>(IFormatProvider formatProvider, T value)
		{
			LogManager.GetLogger(Target).Debug<T>(formatProvider, value);
		}

		public void Debug<T>(T value)
		{
			LogManager.GetLogger(Target).Debug<T>(value);
		}

		[Obsolete("Use Debug(Exception exception, string message, params object[] args) method instead.")]
		public void DebugException(string message, Exception exception)
		{
			LogManager.GetLogger(Target).DebugException(message, exception);
		}

		public void Error(string message, ulong argument)
		{
			LogManager.GetLogger(Target).Error(message, argument);
		}

		public void Error(IFormatProvider formatProvider, string message, ulong argument)
		{
			LogManager.GetLogger(Target).Error(formatProvider, message, argument);
		}

		public void Error(string message, uint argument)
		{
			LogManager.GetLogger(Target).Error(message, argument);
		}

		public void Error(IFormatProvider formatProvider, string message, uint argument)
		{
			LogManager.GetLogger(Target).Error(formatProvider, message, argument);
		}

		public void Error(string message, sbyte argument)
		{
			LogManager.GetLogger(Target).Error(message, argument);
		}

		public void Error(IFormatProvider formatProvider, string message, sbyte argument)
		{
			LogManager.GetLogger(Target).Error(formatProvider, message, argument);
		}

		public void Error(string message, object argument)
		{
			LogManager.GetLogger(Target).Error(message, argument);
		}

		public void Error(IFormatProvider formatProvider, string message, object argument)
		{
			LogManager.GetLogger(Target).Error(formatProvider, message, argument);
		}

		public void Error(string message, decimal argument)
		{
			LogManager.GetLogger(Target).Error(message, argument);
		}

		public void Error(IFormatProvider formatProvider, string message, decimal argument)
		{
			LogManager.GetLogger(Target).Error(formatProvider, message, argument);
		}

		public void Error(string message, double argument)
		{
			LogManager.GetLogger(Target).Error(message, argument);
		}

		public void Error(IFormatProvider formatProvider, string message, double argument)
		{
			LogManager.GetLogger(Target).Error(formatProvider, message, argument);
		}

		public void Error(string message, float argument)
		{
			LogManager.GetLogger(Target).Error(message, argument);
		}

		public void Error(IFormatProvider formatProvider, string message, float argument)
		{
			LogManager.GetLogger(Target).Error(formatProvider, message, argument);
		}

		public void Error(string message, long argument)
		{
			LogManager.GetLogger(Target).Error(message, argument);
		}

		public void Error(IFormatProvider formatProvider, string message, long argument)
		{
			LogManager.GetLogger(Target).Error(formatProvider, message, argument);
		}

		public void Error(string message, int argument)
		{
			LogManager.GetLogger(Target).Error(message, argument);
		}

		public void Error(IFormatProvider formatProvider, string message, int argument)
		{
			LogManager.GetLogger(Target).Error(formatProvider, message, argument);
		}

		public void Error(string message, string argument)
		{
			LogManager.GetLogger(Target).Error(message, argument);
		}

		public void Error(IFormatProvider formatProvider, string message, string argument)
		{
			LogManager.GetLogger(Target).Error(formatProvider, message, argument);
		}

		public void Error(string message, byte argument)
		{
			LogManager.GetLogger(Target).Error(message, argument);
		}

		public void Error(IFormatProvider formatProvider, string message, byte argument)
		{
			LogManager.GetLogger(Target).Error(formatProvider, message, argument);
		}

		public void Error(string message, char argument)
		{
			LogManager.GetLogger(Target).Error(message, argument);
		}

		public void Error(IFormatProvider formatProvider, string message, char argument)
		{
			LogManager.GetLogger(Target).Error(formatProvider, message, argument);
		}

		public void Error(string message, bool argument)
		{
			LogManager.GetLogger(Target).Error(message, argument);
		}

		public void Error(IFormatProvider formatProvider, string message, bool argument)
		{
			LogManager.GetLogger(Target).Error(formatProvider, message, argument);
		}

		public void Error(string message, object arg1, object arg2, object arg3)
		{
			LogManager.GetLogger(Target).Error(message, arg1, arg2, arg3);
		}

		public void Error(string message, object arg1, object arg2)
		{
			LogManager.GetLogger(Target).Error(message, arg1, arg2);
		}

		public void Error(IFormatProvider formatProvider, object value)
		{
			LogManager.GetLogger(Target).Error(formatProvider, value);
		}

		public void Error(object value)
		{
			LogManager.GetLogger(Target).Error(value);
		}

		public void Error<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			LogManager.GetLogger(Target).Error<TArgument1, TArgument2, TArgument3>(message, argument1, argument2, argument3);
		}

		public void Error<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			LogManager.GetLogger(Target).Error<TArgument1, TArgument2, TArgument3>(formatProvider, message, argument1, argument2, argument3);
		}

		public void Error<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
		{
			LogManager.GetLogger(Target).Error<TArgument1, TArgument2>(message, argument1, argument2);
		}

		public void Error<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2)
		{
			LogManager.GetLogger(Target).Error<TArgument1, TArgument2>(formatProvider, message, argument1, argument2);
		}

		public void Error<TArgument>(string message, TArgument argument)
		{
			LogManager.GetLogger(Target).Error<TArgument>(message, argument);
		}

		public void Error<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
		{
			LogManager.GetLogger(Target).Error<TArgument>(formatProvider, message, argument);
		}

		public void Error(string message, Exception exception)
		{
			LogManager.GetLogger(Target).Error(message, exception);
		}

		public void Error(string message, params object[] args)
		{
			LogManager.GetLogger(Target).Error(message, args);
		}

		public void Error(string message)
		{
			LogManager.GetLogger(Target).Error(message);
		}

		public void Error(IFormatProvider formatProvider, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Error(formatProvider, message, args);
		}

		public void Error(Exception exception, IFormatProvider formatProvider, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Error(exception, formatProvider, message, args);
		}

		public void Error(Exception exception, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Error(exception, message, args);
		}

		public void Error(LogMessageGenerator messageFunc)
		{
			LogManager.GetLogger(Target).Error(messageFunc);
		}

		public void Error<T>(IFormatProvider formatProvider, T value)
		{
			LogManager.GetLogger(Target).Error<T>(formatProvider, value);
		}

		public void Error<T>(T value)
		{
			LogManager.GetLogger(Target).Error<T>(value);
		}

		[Obsolete("Use Error(Exception exception, string message, params object[] args) method instead.")]
		public void ErrorException(string message, Exception exception)
		{
			LogManager.GetLogger(Target).ErrorException(message, exception);
		}

		public void Fatal(string message, ulong argument)
		{
			LogManager.GetLogger(Target).Fatal(message, argument);
		}

		public void Fatal(IFormatProvider formatProvider, string message, ulong argument)
		{
			LogManager.GetLogger(Target).Fatal(formatProvider, message, argument);
		}

		public void Fatal(string message, uint argument)
		{
			LogManager.GetLogger(Target).Fatal(message, argument);
		}

		public void Fatal(IFormatProvider formatProvider, string message, uint argument)
		{
			LogManager.GetLogger(Target).Fatal(formatProvider, message, argument);
		}

		public void Fatal(string message, sbyte argument)
		{
			LogManager.GetLogger(Target).Fatal(message, argument);
		}

		public void Fatal(IFormatProvider formatProvider, string message, sbyte argument)
		{
			LogManager.GetLogger(Target).Fatal(formatProvider, message, argument);
		}

		public void Fatal(string message, object argument)
		{
			LogManager.GetLogger(Target).Fatal(message, argument);
		}

		public void Fatal(IFormatProvider formatProvider, string message, object argument)
		{
			LogManager.GetLogger(Target).Fatal(formatProvider, message, argument);
		}

		public void Fatal(string message, decimal argument)
		{
			LogManager.GetLogger(Target).Fatal(message, argument);
		}

		public void Fatal(IFormatProvider formatProvider, string message, decimal argument)
		{
			LogManager.GetLogger(Target).Fatal(formatProvider, message, argument);
		}

		public void Fatal(string message, double argument)
		{
			LogManager.GetLogger(Target).Fatal(message, argument);
		}

		public void Fatal(IFormatProvider formatProvider, string message, double argument)
		{
			LogManager.GetLogger(Target).Fatal(formatProvider, message, argument);
		}

		public void Fatal(string message, float argument)
		{
			LogManager.GetLogger(Target).Fatal(message, argument);
		}

		public void Fatal(IFormatProvider formatProvider, string message, float argument)
		{
			LogManager.GetLogger(Target).Fatal(formatProvider, message, argument);
		}

		public void Fatal(string message, long argument)
		{
			LogManager.GetLogger(Target).Fatal(message, argument);
		}

		public void Fatal(IFormatProvider formatProvider, string message, long argument)
		{
			LogManager.GetLogger(Target).Fatal(formatProvider, message, argument);
		}

		public void Fatal(string message, int argument)
		{
			LogManager.GetLogger(Target).Fatal(message, argument);
		}

		public void Fatal(IFormatProvider formatProvider, string message, int argument)
		{
			LogManager.GetLogger(Target).Fatal(formatProvider, message, argument);
		}

		public void Fatal(string message, string argument)
		{
			LogManager.GetLogger(Target).Fatal(message, argument);
		}

		public void Fatal(IFormatProvider formatProvider, string message, string argument)
		{
			LogManager.GetLogger(Target).Fatal(formatProvider, message, argument);
		}

		public void Fatal(string message, byte argument)
		{
			LogManager.GetLogger(Target).Fatal(message, argument);
		}

		public void Fatal(IFormatProvider formatProvider, string message, byte argument)
		{
			LogManager.GetLogger(Target).Fatal(formatProvider, message, argument);
		}

		public void Fatal(string message, char argument)
		{
			LogManager.GetLogger(Target).Fatal(message, argument);
		}

		public void Fatal(IFormatProvider formatProvider, string message, char argument)
		{
			LogManager.GetLogger(Target).Fatal(formatProvider, message, argument);
		}

		public void Fatal(string message, bool argument)
		{
			LogManager.GetLogger(Target).Fatal(message, argument);
		}

		public void Fatal(IFormatProvider formatProvider, string message, bool argument)
		{
			LogManager.GetLogger(Target).Fatal(formatProvider, message, argument);
		}

		public void Fatal(string message, object arg1, object arg2, object arg3)
		{
			LogManager.GetLogger(Target).Fatal(message, arg1, arg2, arg3);
		}

		public void Fatal(string message, object arg1, object arg2)
		{
			LogManager.GetLogger(Target).Fatal(message, arg1, arg2);
		}

		public void Fatal(IFormatProvider formatProvider, object value)
		{
			LogManager.GetLogger(Target).Fatal(formatProvider, value);
		}

		public void Fatal(object value)
		{
			LogManager.GetLogger(Target).Fatal(value);
		}

		public void Fatal<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			LogManager.GetLogger(Target).Fatal<TArgument1, TArgument2, TArgument3>(message, argument1, argument2, argument3);
		}

		public void Fatal<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			LogManager.GetLogger(Target).Fatal<TArgument1, TArgument2, TArgument3>(formatProvider, message, argument1, argument2, argument3);
		}

		public void Fatal<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
		{
			LogManager.GetLogger(Target).Fatal<TArgument1, TArgument2>(message, argument1, argument2);
		}

		public void Fatal<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2)
		{
			LogManager.GetLogger(Target).Fatal<TArgument1, TArgument2>(formatProvider, message, argument1, argument2);
		}

		public void Fatal<TArgument>(string message, TArgument argument)
		{
			LogManager.GetLogger(Target).Fatal<TArgument>(message, argument);
		}

		public void Fatal<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
		{
			LogManager.GetLogger(Target).Fatal<TArgument>(formatProvider, message, argument);
		}

		public void Fatal(string message, Exception exception)
		{
			LogManager.GetLogger(Target).Fatal(message, exception);
		}

		public void Fatal(string message, params object[] args)
		{
			LogManager.GetLogger(Target).Fatal(message, args);
		}

		public void Fatal(string message)
		{
			LogManager.GetLogger(Target).Fatal(message);
		}

		public void Fatal(IFormatProvider formatProvider, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Fatal(formatProvider, message, args);
		}

		public void Fatal(Exception exception, IFormatProvider formatProvider, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Fatal(exception, formatProvider, message, args);
		}

		public void Fatal(Exception exception, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Fatal(exception, message, args);
		}

		public void Fatal(LogMessageGenerator messageFunc)
		{
			LogManager.GetLogger(Target).Fatal(messageFunc);
		}

		public void Fatal<T>(IFormatProvider formatProvider, T value)
		{
			LogManager.GetLogger(Target).Fatal(formatProvider, value);
		}

		public void Fatal<T>(T value)
		{
			LogManager.GetLogger(Target).Fatal(value);
		}

		[Obsolete("Use Fatal(Exception exception, string message, params object[] args) method instead.")]
		public void FatalException(string message, Exception exception)
		{
			LogManager.GetLogger(Target).FatalException(message, exception);
		}

		public void Info(string message, ulong argument)
		{
			LogManager.GetLogger(Target).Info(message, argument);
		}

		public void Info(IFormatProvider formatProvider, string message, ulong argument)
		{
			LogManager.GetLogger(Target).Info(formatProvider, message, argument);
		}

		public void Info(string message, uint argument)
		{
			LogManager.GetLogger(Target).Info(message, argument);
		}

		public void Info(IFormatProvider formatProvider, string message, uint argument)
		{
			LogManager.GetLogger(Target).Info(formatProvider, message, argument);
		}

		public void Info(string message, sbyte argument)
		{
			LogManager.GetLogger(Target).Info(message, argument);
		}

		public void Info(IFormatProvider formatProvider, string message, sbyte argument)
		{
			LogManager.GetLogger(Target).Info(formatProvider, message, argument);
		}

		public void Info(string message, object argument)
		{
			LogManager.GetLogger(Target).Info(message, argument);
		}

		public void Info(IFormatProvider formatProvider, string message, object argument)
		{
			LogManager.GetLogger(Target).Info(formatProvider, message, argument);
		}

		public void Info(string message, decimal argument)
		{
			LogManager.GetLogger(Target).Info(message, argument);
		}

		public void Info(IFormatProvider formatProvider, string message, decimal argument)
		{
			LogManager.GetLogger(Target).Info(formatProvider, message, argument);
		}

		public void Info(string message, double argument)
		{
			LogManager.GetLogger(Target).Info(message, argument);
		}

		public void Info(IFormatProvider formatProvider, string message, double argument)
		{
			LogManager.GetLogger(Target).Info(formatProvider, message, argument);
		}

		public void Info(string message, float argument)
		{
			LogManager.GetLogger(Target).Info(message, argument);
		}

		public void Info(IFormatProvider formatProvider, string message, float argument)
		{
			LogManager.GetLogger(Target).Info(formatProvider, message, argument);

		}

		public void Info(string message, long argument)
		{
			LogManager.GetLogger(Target).Info(message, argument);

		}

		public void Info(IFormatProvider formatProvider, string message, long argument)
		{
			LogManager.GetLogger(Target).Info(formatProvider, message, argument);

		}

		public void Info(string message, int argument)
		{
			LogManager.GetLogger(Target).Info(message, argument);

		}

		public void Info(IFormatProvider formatProvider, string message, int argument)
		{
			LogManager.GetLogger(Target).Info(formatProvider, message, argument);

		}

		public void Info(string message, string argument)
		{
			LogManager.GetLogger(Target).Info(message, argument);

		}

		public void Info(IFormatProvider formatProvider, string message, string argument)
		{
			LogManager.GetLogger(Target).Info(formatProvider, message, argument);

		}

		public void Info(string message, byte argument)
		{
			LogManager.GetLogger(Target).Info(message, argument);

		}

		public void Info(IFormatProvider formatProvider, string message, byte argument)
		{
			LogManager.GetLogger(Target).Info(formatProvider, message, argument);

		}

		public void Info(string message, char argument)
		{
			LogManager.GetLogger(Target).Info(message, argument);

		}

		public void Info(IFormatProvider formatProvider, string message, char argument)
		{
			LogManager.GetLogger(Target).Info(formatProvider, message, argument);

		}

		public void Info(string message, bool argument)
		{
			LogManager.GetLogger(Target).Info(message, argument);

		}

		public void Info(IFormatProvider formatProvider, string message, bool argument)
		{
			LogManager.GetLogger(Target).Info(formatProvider, message, argument);

		}

		public void Info(string message, object arg1, object arg2, object arg3)
		{
			LogManager.GetLogger(Target).Info(message, arg1, arg2, arg3);

		}

		public void Info(string message, object arg1, object arg2)
		{
			LogManager.GetLogger(Target).Info(message, arg1, arg2);
		}

		public void Info(IFormatProvider formatProvider, object value)
		{
			LogManager.GetLogger(Target).Info(formatProvider, value);
		}

		public void Info(object value)
		{
			LogManager.GetLogger(Target).Info(value);
		}

		public void Info<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			LogManager.GetLogger(Target).Info<TArgument1, TArgument2, TArgument3>(message, argument1, argument2, argument3);
		}

		public void Info<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			LogManager.GetLogger(Target).Info<TArgument1, TArgument2, TArgument3>(formatProvider, message, argument1, argument2, argument3);
		}

		public void Info<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
		{
			LogManager.GetLogger(Target).Info<TArgument1, TArgument2>(message, argument1, argument2);
		}

		public void Info<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2)
		{
			LogManager.GetLogger(Target).Info<TArgument1, TArgument2>(formatProvider, message, argument1, argument2);
		}

		public void Info<TArgument>(string message, TArgument argument)
		{
			LogManager.GetLogger(Target).Info<TArgument>(message, argument);
		}

		public void Info<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
		{
			LogManager.GetLogger(Target).Info<TArgument>(formatProvider, message, argument);
		}

		public void Info(string message, Exception exception)
		{
			LogManager.GetLogger(Target).Info(message, exception);
		}

		public void Info(string message, params object[] args)
		{
			LogManager.GetLogger(Target).Info(message, args);
		}

		public void Info(string message)
		{
			LogManager.GetLogger(Target).Info(message);
		}

		public void Info(IFormatProvider formatProvider, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Info(formatProvider, message, args);
		}

		public void Info(Exception exception, IFormatProvider formatProvider, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Info(exception, formatProvider, message, args);
		}

		public void Info(Exception exception, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Info(exception, message, args);
		}

		public void Info(LogMessageGenerator messageFunc)
		{
			LogManager.GetLogger(Target).Info(messageFunc);
		}

		public void Info<T>(IFormatProvider formatProvider, T value)
		{
			LogManager.GetLogger(Target).Info<T>(formatProvider, value);
		}

		public void Info<T>(T value)
		{
			LogManager.GetLogger(Target).Info<T>(value);
		}

		[Obsolete("Use Info(Exception exception, string message, params object[] args) method instead.")]
		public void InfoException(string message, Exception exception)
		{
			LogManager.GetLogger(Target).InfoException(message, exception);
		}

		public bool IsDebugEnabled
		{
			get 
			{
				return LogManager.GetLogger(Target).IsDebugEnabled;
			}
		}

		public bool IsErrorEnabled
		{
			get
			{
				return LogManager.GetLogger(Target).IsErrorEnabled;
			}
		}

		public bool IsFatalEnabled
		{
			get
			{
				return LogManager.GetLogger(Target).IsFatalEnabled;
			}
		}

		public bool IsInfoEnabled
		{
			get
			{
				return LogManager.GetLogger(Target).IsInfoEnabled;
			}
		}

		public bool IsTraceEnabled
		{
			get
			{
				return LogManager.GetLogger(Target).IsTraceEnabled;
			}
		}

		public bool IsWarnEnabled
		{
			get
			{
				return LogManager.GetLogger(Target).IsWarnEnabled;
			}
		}

		public void Trace(string message, ulong argument)
		{
			LogManager.GetLogger(Target).Trace(message, argument);
		}

		public void Trace(IFormatProvider formatProvider, string message, ulong argument)
		{
			LogManager.GetLogger(Target).Trace(formatProvider, message, argument);
		}

		public void Trace(string message, uint argument)
		{
			LogManager.GetLogger(Target).Trace(message, argument);
		}

		public void Trace(IFormatProvider formatProvider, string message, uint argument)
		{
			LogManager.GetLogger(Target).Trace(formatProvider, message, argument);
		}

		public void Trace(string message, sbyte argument)
		{
			LogManager.GetLogger(Target).Trace(message, argument);
		}

		public void Trace(IFormatProvider formatProvider, string message, sbyte argument)
		{
			LogManager.GetLogger(Target).Trace(formatProvider, message, argument);
		}

		public void Trace(string message, object argument)
		{
			LogManager.GetLogger(Target).Trace(message, argument);
		}

		public void Trace(IFormatProvider formatProvider, string message, object argument)
		{
			LogManager.GetLogger(Target).Trace(formatProvider, message, argument);
		}

		public void Trace(string message, decimal argument)
		{
			LogManager.GetLogger(Target).Trace(message, argument);
		}

		public void Trace(IFormatProvider formatProvider, string message, decimal argument)
		{
			LogManager.GetLogger(Target).Trace(formatProvider, message, argument);
		}

		public void Trace(string message, double argument)
		{
			LogManager.GetLogger(Target).Trace(message, argument);
		}

		public void Trace(IFormatProvider formatProvider, string message, double argument)
		{
			LogManager.GetLogger(Target).Trace(formatProvider, message, argument);
		}

		public void Trace(string message, float argument)
		{
			LogManager.GetLogger(Target).Trace(message, argument);
		}

		public void Trace(IFormatProvider formatProvider, string message, float argument)
		{
			LogManager.GetLogger(Target).Trace(formatProvider, message, argument);
		}

		public void Trace(string message, long argument)
		{
			LogManager.GetLogger(Target).Trace(message, argument);
		}

		public void Trace(IFormatProvider formatProvider, string message, long argument)
		{
			LogManager.GetLogger(Target).Trace(formatProvider, message, argument);
		}

		public void Trace(string message, int argument)
		{
			LogManager.GetLogger(Target).Trace(message, argument);
		}

		public void Trace(IFormatProvider formatProvider, string message, int argument)
		{
			LogManager.GetLogger(Target).Trace(formatProvider, message, argument);
		}

		public void Trace(string message, string argument)
		{
			LogManager.GetLogger(Target).Trace(message, argument);
		}

		public void Trace(IFormatProvider formatProvider, string message, string argument)
		{
			LogManager.GetLogger(Target).Trace(formatProvider, message, argument);
		}

		public void Trace(string message, byte argument)
		{
			LogManager.GetLogger(Target).Trace(message, argument);
		}

		public void Trace(IFormatProvider formatProvider, string message, byte argument)
		{
			LogManager.GetLogger(Target).Trace(formatProvider, message, argument);
		}

		public void Trace(string message, char argument)
		{
			LogManager.GetLogger(Target).Trace(message, argument);
		}

		public void Trace(IFormatProvider formatProvider, string message, char argument)
		{
			LogManager.GetLogger(Target).Trace(formatProvider, message, argument);
		}

		public void Trace(string message, bool argument)
		{
			LogManager.GetLogger(Target).Trace(message, argument);
		}

		public void Trace(IFormatProvider formatProvider, string message, bool argument)
		{
			LogManager.GetLogger(Target).Trace(formatProvider, message, argument);
		}

		public void Trace(string message, object arg1, object arg2, object arg3)
		{
			LogManager.GetLogger(Target).Trace(message, arg1, arg2, arg3);
		}

		public void Trace(string message, object arg1, object arg2)
		{
			LogManager.GetLogger(Target).Trace(message, arg1, arg2);
		}

		public void Trace(IFormatProvider formatProvider, object value)
		{
			LogManager.GetLogger(Target).Trace(formatProvider, value);
		}

		public void Trace(object value)
		{
			LogManager.GetLogger(Target).Trace(value);
		}

		public void Trace<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			LogManager.GetLogger(Target).Trace<TArgument1, TArgument2, TArgument3>(message, argument1, argument2, argument3);
		}

		public void Trace<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			LogManager.GetLogger(Target).Trace<TArgument1, TArgument2, TArgument3>(formatProvider, message, argument1, argument2, argument3);
		}

		public void Trace<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
		{
			LogManager.GetLogger(Target).Trace<TArgument1, TArgument2>(message, argument1, argument2);
		}

		public void Trace<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2)
		{
			LogManager.GetLogger(Target).Trace<TArgument1, TArgument2>(formatProvider, message, argument1, argument2);
		}

		public void Trace<TArgument>(string message, TArgument argument)
		{
			LogManager.GetLogger(Target).Trace<TArgument>(message, argument);
		}

		public void Trace<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
		{
			LogManager.GetLogger(Target).Trace<TArgument>(formatProvider, message, argument);
		}

		public void Trace(string message, Exception exception)
		{
			LogManager.GetLogger(Target).Trace(message, exception);
		}

		public void Trace(string message, params object[] args)
		{
			LogManager.GetLogger(Target).Trace(message, args);
		}

		public void Trace(string message)
		{
			LogManager.GetLogger(Target).Trace(message);
		}

		public void Trace(IFormatProvider formatProvider, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Trace(formatProvider, message, args);
		}

		public void Trace(Exception exception, IFormatProvider formatProvider, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Trace(exception, formatProvider, message, args);
		}

		public void Trace(Exception exception, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Trace(exception, message, args);
		}

		public void Trace(LogMessageGenerator messageFunc)
		{
			LogManager.GetLogger(Target).Trace(messageFunc);
		}

		public void Trace<T>(IFormatProvider formatProvider, T value)
		{
			LogManager.GetLogger(Target).Trace<T>(formatProvider, value);
		}

		public void Trace<T>(T value)
		{
			LogManager.GetLogger(Target).Trace<T>(value);
		}

		[Obsolete("Use Trace(Exception exception, string message, params object[] args) method instead.")]
		public void TraceException(string message, Exception exception)
		{
			LogManager.GetLogger(Target).TraceException(message, exception);
		}

		public void Warn(string message, ulong argument)
		{
			LogManager.GetLogger(Target).Warn(message, argument);
		}

		public void Warn(IFormatProvider formatProvider, string message, ulong argument)
		{
			LogManager.GetLogger(Target).Warn(formatProvider, message, argument);
		}

		public void Warn(string message, uint argument)
		{
			LogManager.GetLogger(Target).Warn(message, argument);
		}

		public void Warn(IFormatProvider formatProvider, string message, uint argument)
		{
			LogManager.GetLogger(Target).Warn(formatProvider, message, argument);
		}

		public void Warn(string message, sbyte argument)
		{
			LogManager.GetLogger(Target).Warn(message, argument);
		}

		public void Warn(IFormatProvider formatProvider, string message, sbyte argument)
		{
			LogManager.GetLogger(Target).Warn(formatProvider, message, argument);
		}

		public void Warn(string message, object argument)
		{
			LogManager.GetLogger(Target).Warn(message, argument);
		}

		public void Warn(IFormatProvider formatProvider, string message, object argument)
		{
			LogManager.GetLogger(Target).Warn(formatProvider, message, argument);
		}

		public void Warn(string message, decimal argument)
		{
			LogManager.GetLogger(Target).Warn(message, argument);
		}

		public void Warn(IFormatProvider formatProvider, string message, decimal argument)
		{
			LogManager.GetLogger(Target).Warn(formatProvider, message, argument);
		}

		public void Warn(string message, double argument)
		{
			LogManager.GetLogger(Target).Warn(message, argument);
		}

		public void Warn(IFormatProvider formatProvider, string message, double argument)
		{
			LogManager.GetLogger(Target).Warn(formatProvider, message, argument);
		}

		public void Warn(string message, float argument)
		{
			LogManager.GetLogger(Target).Warn(message, argument);
		}

		public void Warn(IFormatProvider formatProvider, string message, float argument)
		{
			LogManager.GetLogger(Target).Warn(formatProvider, message, argument);
		}

		public void Warn(string message, long argument)
		{
			LogManager.GetLogger(Target).Warn(message, argument);
		}

		public void Warn(IFormatProvider formatProvider, string message, long argument)
		{
			LogManager.GetLogger(Target).Warn(formatProvider, message, argument);
		}

		public void Warn(string message, int argument)
		{
			LogManager.GetLogger(Target).Warn(message, argument);
		}

		public void Warn(IFormatProvider formatProvider, string message, int argument)
		{
			LogManager.GetLogger(Target).Warn(formatProvider, message, argument);
		}

		public void Warn(string message, string argument)
		{
			LogManager.GetLogger(Target).Warn(message, argument);
		}

		public void Warn(IFormatProvider formatProvider, string message, string argument)
		{
			LogManager.GetLogger(Target).Warn(formatProvider, message, argument);

		}

		public void Warn(string message, byte argument)
		{
			LogManager.GetLogger(Target).Warn(message, argument);

		}

		public void Warn(IFormatProvider formatProvider, string message, byte argument)
		{
			LogManager.GetLogger(Target).Warn(formatProvider, message, argument);

		}

		public void Warn(string message, char argument)
		{
			LogManager.GetLogger(Target).Warn(message, argument);

		}

		public void Warn(IFormatProvider formatProvider, string message, char argument)
		{
			LogManager.GetLogger(Target).Warn(formatProvider, message, argument);

		}

		public void Warn(string message, bool argument)
		{
			LogManager.GetLogger(Target).Warn(message, argument);

		}

		public void Warn(IFormatProvider formatProvider, string message, bool argument)
		{
			LogManager.GetLogger(Target).Warn(formatProvider, message, argument);

		}

		public void Warn(string message, object arg1, object arg2, object arg3)
		{
			LogManager.GetLogger(Target).Warn(message, arg1, arg2, arg3);

		}

		public void Warn(string message, object arg1, object arg2)
		{
			LogManager.GetLogger(Target).Warn(message, arg1, arg2);
		}

		public void Warn(IFormatProvider formatProvider, object value)
		{
			LogManager.GetLogger(Target).Warn(formatProvider, value);
		}

		public void Warn(object value)
		{
			LogManager.GetLogger(Target).Warn(value);
		}

		public void Warn<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			LogManager.GetLogger(Target).Warn<TArgument1, TArgument2, TArgument3>(message, argument1, argument2, argument3);
		}

		public void Warn<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			LogManager.GetLogger(Target).Warn<TArgument1, TArgument2, TArgument3>(formatProvider, message, argument1, argument2, argument3);
		}

		public void Warn<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
		{
			LogManager.GetLogger(Target).Warn<TArgument1, TArgument2>(message, argument1, argument2);
		}

		public void Warn<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2)
		{
			LogManager.GetLogger(Target).Warn<TArgument1, TArgument2>(formatProvider, message, argument1, argument2);
		}

		public void Warn<TArgument>(string message, TArgument argument)
		{
			LogManager.GetLogger(Target).Warn<TArgument>(message, argument);
		}

		public void Warn<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
		{
			LogManager.GetLogger(Target).Warn<TArgument>(formatProvider, message, argument);
		}

		public void Warn(string message, Exception exception)
		{
			LogManager.GetLogger(Target).Warn(message, exception);
		}

		public void Warn(string message, params object[] args)
		{
			LogManager.GetLogger(Target).Warn(message, args);
		}

		public void Warn(string message)
		{
			LogManager.GetLogger(Target).Warn(message);
		}

		public void Warn(IFormatProvider formatProvider, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Warn(formatProvider, message, args);
		}

		public void Warn(Exception exception, IFormatProvider formatProvider, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Warn(exception, formatProvider, message, args);
		}

		public void Warn(Exception exception, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Warn(exception, message, args);
		}

		public void Warn(LogMessageGenerator messageFunc)
		{
			LogManager.GetLogger(Target).Warn(messageFunc);
		}

		public void Warn<T>(IFormatProvider formatProvider, T value)
		{
			LogManager.GetLogger(Target).Warn<T>(formatProvider, value);
		}

		public void Warn<T>(T value)
		{
			LogManager.GetLogger(Target).Warn<T>(value);
		}

		[Obsolete("Use Warn(Exception exception, string message, params object[] args) method instead.")]
		public void WarnException(string message, Exception exception)
		{
			LogManager.GetLogger(Target).WarnException(message, exception);
		}

		public LogFactory Factory
		{
			get { return LogManager.GetLogger(Target).Factory; }
		}

		public bool IsEnabled(LogLevel level)
		{
			return LogManager.GetLogger(Target).IsEnabled(level);
		}

		public void Log(LogLevel level, string message, ulong argument)
		{
			LogManager.GetLogger(Target).Log(level, message, argument);
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, ulong argument)
		{
			LogManager.GetLogger(Target).Log(level, formatProvider, message, argument);
		}

		public void Log(LogLevel level, string message, uint argument)
		{
			LogManager.GetLogger(Target).Log(level, message, argument);
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, uint argument)
		{
			LogManager.GetLogger(Target).Log(level, formatProvider, message, argument);
		}

		public void Log(LogLevel level, string message, sbyte argument)
		{
			LogManager.GetLogger(Target).Log(level, message, argument);
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, sbyte argument)
		{
			LogManager.GetLogger(Target).Log(level, formatProvider, message, argument);
		}

		public void Log(LogLevel level, string message, object argument)
		{
			LogManager.GetLogger(Target).Log(level, message, argument);
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, object argument)
		{
			LogManager.GetLogger(Target).Log(level, formatProvider, message, argument);
		}

		public void Log(LogLevel level, string message, decimal argument)
		{
			LogManager.GetLogger(Target).Log(level, message, argument);
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, decimal argument)
		{
			LogManager.GetLogger(Target).Log(level, formatProvider, message, argument);
		}

		public void Log(LogLevel level, string message, double argument)
		{
			LogManager.GetLogger(Target).Log(level, message, argument);
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, double argument)
		{
			LogManager.GetLogger(Target).Log(level, formatProvider, message, argument);
		}

		public void Log(LogLevel level, string message, float argument)
		{
			LogManager.GetLogger(Target).Log(level, message, argument);
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, float argument)
		{
			LogManager.GetLogger(Target).Log(level, formatProvider, message, argument);
		}

		public void Log(LogLevel level, string message, long argument)
		{
			LogManager.GetLogger(Target).Log(level, message, argument);
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, long argument)
		{
			LogManager.GetLogger(Target).Log(level, formatProvider, message, argument);
		}

		public void Log(LogLevel level, string message, int argument)
		{
			LogManager.GetLogger(Target).Log(level, message, argument);
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, int argument)
		{
			LogManager.GetLogger(Target).Log(level, formatProvider, message, argument);
		}

		public void Log(LogLevel level, string message, string argument)
		{
			LogManager.GetLogger(Target).Log(level, message, argument);
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, string argument)
		{
			LogManager.GetLogger(Target).Log(level, formatProvider, message, argument);
		}

		public void Log(LogLevel level, string message, byte argument)
		{
			LogManager.GetLogger(Target).Log(level, message, argument);
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, byte argument)
		{
			LogManager.GetLogger(Target).Log(level, formatProvider, message, argument);
		}

		public void Log(LogLevel level, string message, char argument)
		{
			LogManager.GetLogger(Target).Log(level, message, argument);
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, char argument)
		{
			LogManager.GetLogger(Target).Log(level, formatProvider, message, argument);
		}

		public void Log(LogLevel level, string message, bool argument)
		{
			LogManager.GetLogger(Target).Log(level, message, argument);
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, bool argument)
		{
			LogManager.GetLogger(Target).Log(level, formatProvider, message, argument);
		}

		public void Log(LogLevel level, string message, object arg1, object arg2, object arg3)
		{
			LogManager.GetLogger(Target).Log(level, message, arg1, arg2, arg3);
		}

		public void Log(LogLevel level, string message, object arg1, object arg2)
		{
			LogManager.GetLogger(Target).Log(level, message, arg1, arg2);
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, object value)
		{
			LogManager.GetLogger(Target).Log(level, formatProvider, value);
		}

		public void Log(LogLevel level, object value)
		{
			LogManager.GetLogger(Target).Log(level, value);
		}

		public void Log<TArgument1, TArgument2, TArgument3>(LogLevel level, string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			LogManager.GetLogger(Target).Log<TArgument1, TArgument2, TArgument3>(level, message, argument1, argument2, argument3);
		}

		public void Log<TArgument1, TArgument2, TArgument3>(LogLevel level, IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			LogManager.GetLogger(Target).Log<TArgument1, TArgument2, TArgument3>(level, formatProvider, message, argument1, argument2, argument3);
		}

		public void Log<TArgument1, TArgument2>(LogLevel level, string message, TArgument1 argument1, TArgument2 argument2)
		{
			LogManager.GetLogger(Target).Log<TArgument1, TArgument2>(level, message, argument1, argument2);
		}

		public void Log<TArgument1, TArgument2>(LogLevel level, IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2)
		{
			LogManager.GetLogger(Target).Log<TArgument1, TArgument2>(level, formatProvider, message, argument1, argument2);
		}

		public void Log<TArgument>(LogLevel level, string message, TArgument argument)
		{
			LogManager.GetLogger(Target).Log<TArgument>(level, message, argument);
		}

		public void Log<TArgument>(LogLevel level, IFormatProvider formatProvider, string message, TArgument argument)
		{
			LogManager.GetLogger(Target).Log<TArgument>(level, formatProvider, message, argument);
		}

		public void Log(LogLevel level, string message, Exception exception)
		{
			LogManager.GetLogger(Target).Log(level, message, exception);
		}

		public void Log(LogLevel level, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Log(level, message, args);
		}

		public void Log(LogLevel level, string message)
		{
			LogManager.GetLogger(Target).Log(level, message);
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Log(level, formatProvider, message, args);
		}

		public void Log(LogLevel level, Exception exception, IFormatProvider formatProvider, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Log(level, exception, formatProvider, message, args);
		}

		public void Log(LogLevel level, Exception exception, string message, params object[] args)
		{
			LogManager.GetLogger(Target).Log(level, exception, message, args);
		}

		public void Log(LogLevel level, LogMessageGenerator messageFunc)
		{
			LogManager.GetLogger(Target).Log(level, messageFunc);
		}

		public void Log<T>(LogLevel level, IFormatProvider formatProvider, T value)
		{
			LogManager.GetLogger(Target).Log<T>(level, formatProvider, value);
		}

		public void Log<T>(LogLevel level, T value)
		{
			LogManager.GetLogger(Target).Log<T>(level, value);
		}

		public void Log(Type wrapperType, LogEventInfo logEvent)
		{
			LogManager.GetLogger(Target).Log(wrapperType, logEvent);
		}

		public void Log(LogEventInfo logEvent)
		{
			LogManager.GetLogger(Target).Log(logEvent);
		}

		[Obsolete("Use Log(LogLevel, String, Exception) method instead.")]
		public void LogException(LogLevel level, string message, Exception exception)
		{
			LogManager.GetLogger(Target).LogException(level, message, exception);
		}

		public event EventHandler<EventArgs> LoggerReconfigured;

		public string Name
		{
			get { return LogManager.GetLogger(Target).Name; }
		}

		public void Swallow(Task task)
		{
			LogManager.GetLogger(Target).Swallow(task);
		}

		public T Swallow<T>(Func<T> func, T fallback)
		{
			return LogManager.GetLogger(Target).Swallow<T>(func, fallback);
		}

		public T Swallow<T>(Func<T> func)
		{
			return LogManager.GetLogger(Target).Swallow<T>(func);
		}

		public void Swallow(Action action)
		{
			LogManager.GetLogger(Target).Swallow(action);
		}

		public Task<TResult> SwallowAsync<TResult>(Func<Task<TResult>> asyncFunc, TResult fallback)
		{
			return LogManager.GetLogger(Target).SwallowAsync<TResult>(asyncFunc, fallback);
		}

		public Task<TResult> SwallowAsync<TResult>(Func<Task<TResult>> asyncFunc)
		{
			return LogManager.GetLogger(Target).SwallowAsync<TResult>(asyncFunc);
		}

		public Task SwallowAsync(Func<Task> asyncAction)
		{
			return LogManager.GetLogger(Target).SwallowAsync(asyncAction);
		}

		public Task SwallowAsync(Task task)
		{
			return LogManager.GetLogger(Target).SwallowAsync(task);
		}
	}
}
