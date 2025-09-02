using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== UNIVERSAL DATATYPE CONVERTER ====\n");

            // ---------- INTEGER INPUT ----------
            Console.Write("Enter a whole number: ");
            string inputInt = Console.ReadLine();

            // Conversions from string to number
            int intVal = Convert.ToInt32(inputInt);
            Console.WriteLine($"Convert.ToInt32: \"{inputInt}\" -> int {intVal}");

            short shortVal = Convert.ToInt16(inputInt);
            Console.WriteLine($"Convert.ToInt16: \"{inputInt}\" -> short {shortVal}");

            long longVal = Convert.ToInt64(inputInt);
            Console.WriteLine($"Convert.ToInt64: \"{inputInt}\" -> long {longVal}");

            byte byteVal = Convert.ToByte(inputInt);
            Console.WriteLine($"Convert.ToByte: \"{inputInt}\" -> byte {byteVal}");

            sbyte sbyteVal = Convert.ToSByte(inputInt);
            Console.WriteLine($"Convert.ToSByte: \"{inputInt}\" -> sbyte {sbyteVal}");

            ushort ushortVal = Convert.ToUInt16(inputInt);
            Console.WriteLine($"Convert.ToUInt16: \"{inputInt}\" -> ushort {ushortVal}");

            uint uintVal = Convert.ToUInt32(inputInt);
            Console.WriteLine($"Convert.ToUInt32: \"{inputInt}\" -> uint {uintVal}");

            ulong ulongVal = Convert.ToUInt64(inputInt);
            Console.WriteLine($"Convert.ToUInt64: \"{inputInt}\" -> ulong {ulongVal}");

            // ---------- DECIMAL INPUT ----------
            Console.Write("\nEnter a decimal number: ");
            string inputDecimal = Console.ReadLine();

            double doubleVal = Convert.ToDouble(inputDecimal);
            Console.WriteLine($"Convert.ToDouble: \"{inputDecimal}\" -> double {doubleVal}");

            float floatVal = Convert.ToSingle(inputDecimal);
            Console.WriteLine($"Convert.ToSingle: \"{inputDecimal}\" -> float {floatVal}");

            decimal decimalVal = Convert.ToDecimal(inputDecimal);
            Console.WriteLine($"Convert.ToDecimal: \"{inputDecimal}\" -> decimal {decimalVal}");

            // ---------- BOOLEAN INPUT ----------
            Console.Write("\nEnter true or false (or 1/0): ");
            string inputBool = Console.ReadLine();

            bool boolVal = Convert.ToBoolean(inputBool);
            Console.WriteLine($"Convert.ToBoolean: \"{inputBool}\" -> bool {boolVal}");

            // ---------- CHAR INPUT ----------
            Console.Write("\nEnter a single character: ");
            string inputChar = Console.ReadLine();

            char charVal = Convert.ToChar(inputChar);
            Console.WriteLine($"Convert.ToChar: \"{inputChar}\" -> char '{charVal}'");

            int charToInt = Convert.ToInt32(charVal);
            Console.WriteLine($"Convert.ToInt32: char '{charVal}' -> int {charToInt} (Unicode code)");

            // ---------- DATE INPUT ----------
            Console.Write("\nEnter a date (YYYY-MM-DD): ");
            string inputDate = Console.ReadLine();

            DateTime dateVal = Convert.ToDateTime(inputDate);
            Console.WriteLine($"Convert.ToDateTime: \"{inputDate}\" -> DateTime {dateVal}");

            string dateToStr = Convert.ToString(dateVal);
            Console.WriteLine($"Convert.ToString: DateTime {dateVal} -> string \"{dateToStr}\"");

            // ---------- STRING CONVERSIONS ----------
            Console.WriteLine("\n-- String Conversions --");
            Console.WriteLine($"Convert.ToString (int): {Convert.ToString(intVal)}");
            Console.WriteLine($"Convert.ToString (double): {Convert.ToString(doubleVal)}");
            Console.WriteLine($"Convert.ToString (bool): {Convert.ToString(boolVal)}");
            Console.WriteLine($"Convert.ToString (char): {Convert.ToString(charVal)}");

            // ---------- BASE64 CONVERSIONS ----------
            Console.WriteLine("\n-- Base64 Conversions --");
            byte[] byteArray = { 1, 2, 3, 4, 5 };
            string base64 = Convert.ToBase64String(byteArray);
            Console.WriteLine($"Convert.ToBase64String: byte[] -> \"{base64}\"");

            byte[] fromBase64 = Convert.FromBase64String(base64);
            Console.WriteLine($"Convert.FromBase64String: \"{base64}\" -> byte[] length {fromBase64.Length}");

            Console.WriteLine("\n==== END OF CONVERSIONS ====");
        }
    }
}
