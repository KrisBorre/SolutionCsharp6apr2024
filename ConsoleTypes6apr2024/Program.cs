using static System.Console;

namespace ConsoleTypes6apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 2 Exercise 2.2 page 72");
            WriteLine();

            WriteLine("--------------------------------------------------------------------------");
            WriteLine("Type    Byte(s) of memory               Min                            Max");
            WriteLine("--------------------------------------------------------------------------");
            WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
            WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
            WriteLine($"short   {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
            WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
            WriteLine($"int     {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
            WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
            WriteLine($"long    {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
            WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
            WriteLine($"float   {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
            WriteLine($"double  {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
            WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
            WriteLine("--------------------------------------------------------------------------");

            Read();

            /*
            --------------------------------------------------------------------------
            Type    Byte(s) of memory               Min                            Max
            --------------------------------------------------------------------------
            sbyte   1                              -128                            127
            byte    1                                 0                            255
            short   2                            -32768                          32767
            ushort  2                                 0                          65535
            int     4                       -2147483648                     2147483647
            uint    4                                 0                     4294967295
            long    8              -9223372036854775808            9223372036854775807
            ulong   8                                 0           18446744073709551615
            float   4                    -3,4028235E+38                  3,4028235E+38
            double  8          -1,7976931348623157E+308        1,7976931348623157E+308
            decimal 16   -79228162514264337593543950335  79228162514264337593543950335
            --------------------------------------------------------------------------
            */
        }
    }
}
