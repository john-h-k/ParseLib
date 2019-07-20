using System;

namespace ParseLib
{
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

}