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
        //bool TryParse(string s, IFormatProvider provider, out T result);
    }

    public static partial class Parsers
    {
        private class ByteParser : IParser<byte>
        {
            public byte Parse(string str) => byte.Parse(str);

            public byte Parse(string str, IFormatProvider provider) => byte.Parse(str, provider);

            public bool TryParse(string s, out byte result) => byte.TryParse(s, out result);

            // TODO
            //public bool TryParse(string s, IFormatProvider provider, out byte result) => byte.TryParse(s, provider, out result);
        }
        private class Int16Parser : IParser<short>
        {
            public short Parse(string str) => short.Parse(str);

            public short Parse(string str, IFormatProvider provider) => short.Parse(str, provider);

            public bool TryParse(string s, out short result) => short.TryParse(s, out result);

            // TODO
            //public bool TryParse(string s, IFormatProvider provider, out short result) => short.TryParse(s, provider, out result);
        }
        private class Int32Parser : IParser<int>
        {
            public int Parse(string str) => int.Parse(str);

            public int Parse(string str, IFormatProvider provider) => int.Parse(str, provider);

            public bool TryParse(string s, out int result) => int.TryParse(s, out result);

            // TODO
            //public bool TryParse(string s, IFormatProvider provider, out int result) => int.TryParse(s, provider, out result);
        }
        private class Int64Parser : IParser<long>
        {
            public long Parse(string str) => long.Parse(str);

            public long Parse(string str, IFormatProvider provider) => long.Parse(str, provider);

            public bool TryParse(string s, out long result) => long.TryParse(s, out result);

            // TODO
            //public bool TryParse(string s, IFormatProvider provider, out long result) => long.TryParse(s, provider, out result);
        }
        private class SByteParser : IParser<sbyte>
        {
            public sbyte Parse(string str) => sbyte.Parse(str);

            public sbyte Parse(string str, IFormatProvider provider) => sbyte.Parse(str, provider);

            public bool TryParse(string s, out sbyte result) => sbyte.TryParse(s, out result);

            // TODO
            //public bool TryParse(string s, IFormatProvider provider, out sbyte result) => sbyte.TryParse(s, provider, out result);
        }
        private class UInt16Parser : IParser<ushort>
        {
            public ushort Parse(string str) => ushort.Parse(str);

            public ushort Parse(string str, IFormatProvider provider) => ushort.Parse(str, provider);

            public bool TryParse(string s, out ushort result) => ushort.TryParse(s, out result);

            // TODO
            //public bool TryParse(string s, IFormatProvider provider, out ushort result) => ushort.TryParse(s, provider, out result);
        }
        private class UInt32Parser : IParser<uint>
        {
            public uint Parse(string str) => uint.Parse(str);

            public uint Parse(string str, IFormatProvider provider) => uint.Parse(str, provider);

            public bool TryParse(string s, out uint result) => uint.TryParse(s, out result);

            // TODO
            //public bool TryParse(string s, IFormatProvider provider, out uint result) => uint.TryParse(s, provider, out result);
        }
        private class UInt64Parser : IParser<ulong>
        {
            public ulong Parse(string str) => ulong.Parse(str);

            public ulong Parse(string str, IFormatProvider provider) => ulong.Parse(str, provider);

            public bool TryParse(string s, out ulong result) => ulong.TryParse(s, out result);

            // TODO
            //public bool TryParse(string s, IFormatProvider provider, out ulong result) => ulong.TryParse(s, provider, out result);
        }
        private class SingleParser : IParser<float>
        {
            public float Parse(string str) => float.Parse(str);

            public float Parse(string str, IFormatProvider provider) => float.Parse(str, provider);

            public bool TryParse(string s, out float result) => float.TryParse(s, out result);

            // TODO
            //public bool TryParse(string s, IFormatProvider provider, out float result) => float.TryParse(s, provider, out result);
        }
        private class DoubleParser : IParser<double>
        {
            public double Parse(string str) => double.Parse(str);

            public double Parse(string str, IFormatProvider provider) => double.Parse(str, provider);

            public bool TryParse(string s, out double result) => double.TryParse(s, out result);

            // TODO
            //public bool TryParse(string s, IFormatProvider provider, out double result) => double.TryParse(s, provider, out result);
        }
        private class DecimalParser : IParser<decimal>
        {
            public decimal Parse(string str) => decimal.Parse(str);

            public decimal Parse(string str, IFormatProvider provider) => decimal.Parse(str, provider);

            public bool TryParse(string s, out decimal result) => decimal.TryParse(s, out result);

            // TODO
            //public bool TryParse(string s, IFormatProvider provider, out decimal result) => decimal.TryParse(s, provider, out result);
        }
        private class BoolParser : IParser<bool>
        {
            public bool Parse(string str) => bool.Parse(str);

            public bool Parse(string str, IFormatProvider provider) => bool.Parse(str);

            public bool TryParse(string s, out bool result) => bool.TryParse(s, out result);

            // TODO
            //public bool TryParse(string s, IFormatProvider provider, out bool result) => bool.TryParse(s, provider, out result);
        }
        private class CharParser : IParser<char>
        {
            public char Parse(string str) => char.Parse(str);

            public char Parse(string str, IFormatProvider provider) => char.Parse(str);

            public bool TryParse(string s, out char result) => char.TryParse(s, out result);

            // TODO
            //public bool TryParse(string s, IFormatProvider provider, out char result) => char.TryParse(s, provider, out result);
        }
        private class DateTimeParser : IParser<DateTime>
        {
            public DateTime Parse(string str) => DateTime.Parse(str);

            public DateTime Parse(string str, IFormatProvider provider) => DateTime.Parse(str, provider);

            public bool TryParse(string s, out DateTime result) => DateTime.TryParse(s, out result);

            // TODO
            //public bool TryParse(string s, IFormatProvider provider, out DateTime result) => DateTime.TryParse(s, provider, out result);
        }
        private class TimeSpanParser : IParser<TimeSpan>
        {
            public TimeSpan Parse(string str) => TimeSpan.Parse(str);

            public TimeSpan Parse(string str, IFormatProvider provider) => TimeSpan.Parse(str, provider);

            public bool TryParse(string s, out TimeSpan result) => TimeSpan.TryParse(s, out result);

            // TODO
            //public bool TryParse(string s, IFormatProvider provider, out TimeSpan result) => TimeSpan.TryParse(s, provider, out result);
        }
        private class VersionParser : IParser<Version>
        {
            public Version Parse(string str) => Version.Parse(str);

            public Version Parse(string str, IFormatProvider provider) => Version.Parse(str);

            public bool TryParse(string s, out Version result) => Version.TryParse(s, out result);

            // TODO
            //public bool TryParse(string s, IFormatProvider provider, out Version result) => Version.TryParse(s, provider, out result);
        }
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
            [typeof(DateTime)] = DateTime,
            [typeof(TimeSpan)] = TimeSpan,
            [typeof(Version)] = Version
        };

        public static T Parse<T>(string s) => GetParser<T>().Parse(s);

        public static ParseResult TryParse<T>(string s, out T result)
        {
            if (TryGetParser(out IParser<T> parser))
            {
                if (parser is null)
                {
                    result = default;
                    return ParseFailureReason.NullParser;
                }

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
                throw new InvalidOperationException("T does not have a registered parser");

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
        NullParser,
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