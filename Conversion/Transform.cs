using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Transform
    {
        internal string DecToBin(long value) // 将十进制转换为二进制
        {
            return Convert.ToString(value, 2);
        }
        internal string DecToOct(long value) // 将十进制转换为八进制
        {
            return Convert.ToString(value, 8);
        }
        internal string DecToHex(long value) // 将十进制转换为十六进制
        {
            return Convert.ToString(value, 16);
        }
        internal string BinToOct(long value) // 将二进制转化为八进制
        {
            return Convert.ToString(Convert.ToInt64(value.ToString(),2), 8);
        }
        internal string BinToDec(long value) // 将二进制转化为十进制
        {
            return Convert.ToInt64(value.ToString(), 2).ToString();
        }
        internal string BinToHex(long value) // 将二进制转化为十六进制
        {
            return Convert.ToString(Convert.ToInt64(value.ToString(),2), 16);
        }
        internal string OctToBin(long value) // 将八进制转化为二进制
        {
            return Convert.ToString(
                Convert.ToInt64(value.ToString(), 8),2);
        }
        internal string OctToDec(long value) // 将八进制转换为十进制
        {
            return Convert.ToInt64(value.ToString(), 8).ToString();
        }
        internal string OctToHex(long value) // 将八进制转化为十六进制
        {
            return Convert.ToString(Convert.ToInt64(value.ToString(), 8), 16);
        }
        internal string HexToBin(string value) // 将十六进制进制转换为二进制
        {
            return Convert.ToString(Convert.ToInt64(value.ToString(), 16), 2);
        }
        internal string HexToOct(string value) // 将十六进制进制转换为八进制
        {
            return Convert.ToString(Convert.ToInt64(value.ToString(), 16), 8);
        }
        internal string HexToDec(string value) // 将十六进制进制转换为十进制
        {
            return Convert.ToInt64(value.ToString(), 16).ToString();
        }
    }
}
