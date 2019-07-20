using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ParseLib
{
    public interface IParser<T>
    {
        T Parse(string s);
        T Parse(string s, IFormatProvider provider);
        bool TryParse(string s, out T result);
        
        // TODO
        //bool TryParse(string s, IFormatProvider provider, out T result);
    }

    
    public static partial class Parsers
    {
        public static IParser<byte> Byte { get; } = new ByteParser();
        public static IParser<short> Int16 { get; } = new Int16Parser();
        public static IParser<int> Int32 { get; } = new Int32Parser();
        public static IParser<long> Int64 { get; } = new Int64Parser();
        public static IParser<sbyte> SByte { get; } = new SByteParser();
        public static IParser<ushort> UInt16 { get; } = new UInt16Parser();
        public static IParser<uint> UInt32 { get; } = new UInt32Parser();
        public static IParser<ulong> UInt64 { get; } = new UInt64Parser();
        public static IParser<float> Single { get; } = new SingleParser();
        public static IParser<double> Double { get; } = new DoubleParser();
        public static IParser<decimal> Decimal { get; } = new DecimalParser();
        public static IParser<bool> Bool { get; } = new BoolParser();
        public static IParser<char> Char { get; } = new CharParser();

        public static IParser<DateTime> DateTime { get; } = new DateTimeParser();
        public static IParser<TimeSpan> TimeSpan { get; } = new TimeSpanParser();
        public static IParser<Version> Version { get; } = new VersionParser();

        private static readonly Dictionary<Type, object> TypeParsers = new Dictionary<Type, object>
        {
            [typeof(byte)] = Byte,
            [typeof(short)] = Int16,
            [typeof(int)] = Int32,
            [typeof(long)] = Int64,
            [typeof(sbyte)] = SByte,
            [typeof(ushort)] = UInt16,
            [typeof(uint)] = UInt32,
            [typeof(ulong)] = UInt64,
            [typeof(float)] = Single,
            [typeof(double)] = Double,
            [typeof(decimal)] = Decimal,
            [typeof(bool)] = Bool,
            [typeof(char)] = Char,
            [typeof(DateTime)] = DateTime,
            [typeof(TimeSpan)] = TimeSpan,
            [typeof(Version)] = Version
        };

        public static T Parse<T>(string s) => GetParser<T>().Parse(s);

        public static ParseResult TryParse<T>(string s, out T result)
        {
            if (TryGetParser(out IParser<T> parser))
            {
                return parser.TryParse(s, out result) ? ParseFailureReason.Success : ParseFailureReason.ParserFail;
            }

            result = default;
            return ParseFailureReason.NoParser;
        }

        public static void SetParser<T>(IParser<T> parser)
        {
            if (TypeParsers.ContainsKey(typeof(T)))
                throw new ArgumentException("Type is already registered with a parser");

            TypeParsers[typeof(T)] = parser;
        }

        public static void UnsetParser<T>()
        {
            if (!TypeParsers.ContainsKey(typeof(T)))
                throw new InvalidOperationException("Type does not have a registered parser");

            TypeParsers.Remove(typeof(T));
        }

        public static bool TryUnsetParser<T>()
        {
            if (!TypeParsers.ContainsKey(typeof(T)))
                return false;

            TypeParsers.Remove(typeof(T));
            return true;
        }

        public static bool TrySetParser<T>(IParser<T> parser)
        {
            if (TypeParsers.ContainsKey(typeof(T)))
                return false;

            TypeParsers[typeof(T)] = parser;
            return true;
        }

        public static IParser<T> GetParser<T>()
        {
            if (!TypeParsers.ContainsKey(typeof(T)))
            {
                throw new InvalidOperationException("Type is not registered for a parser");
            }

            return Unsafe.As<IParser<T>>(TypeParsers[typeof(T)]);
        }

        public static bool TryGetParser<T>(out IParser<T> result)
        {
            if (!TypeParsers.ContainsKey(typeof(T)))
            {
                result = null;
                return false;
            }

            result = Unsafe.As<IParser<T>>(TypeParsers[typeof(T)]);
            return true;
        }
    }

    public enum ParseFailureReason
    {
        Success,
        NoParser,
        ParserFail
    }

    public readonly struct ParseResult
    {
        public ParseResult(ParseFailureReason failureReason)
        {
            FailureReason = failureReason;
        }

        public ParseFailureReason FailureReason { get; }

        public static explicit operator bool(ParseResult reason)
        {
            return reason.FailureReason == ParseFailureReason.Success;
        }

        public static bool operator true(ParseResult reason)
        {
            return reason.FailureReason == ParseFailureReason.Success;
        }

        public static bool operator false(ParseResult reason)
        {
            return reason.FailureReason != ParseFailureReason.Success;
        }

        public override string ToString()
        {
            return "ParseFailureReason." + FailureReason;
        }

        public static implicit operator ParseResult(ParseFailureReason reason)
        {
            return new ParseResult(reason);
        }

        public bool Success => (bool)this;
    }
}