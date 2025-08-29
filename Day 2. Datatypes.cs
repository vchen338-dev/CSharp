using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ========= VALUE TYPES =========
            // (stored directly in memory)

            // 1. byte - 8-bit unsigned integer (0 to 255)
            byte smallNumber = 200;
            Console.WriteLine("Byte example: " + smallNumber);

            // 2. sbyte - 8-bit signed integer (-128 to 127)
            sbyte signedByte = -100;
            Console.WriteLine("SByte example: " + signedByte);

            // 3. short - 16-bit signed integer (-32,768 to 32,767)
            short year = 2025;
            Console.WriteLine("Short example: " + year);

            // 4. ushort - 16-bit unsigned integer (0 to 65,535)
            ushort ushortValue = 65000;
            Console.WriteLine("UShort example: " + ushortValue);

            // 5. int - 32-bit signed integer (-2,147,483,648 to 2,147,483,647)
            int population = 110000000;
            Console.WriteLine("Int example: " + population);

            // 6. uint - 32-bit unsigned integer (0 to 4,294,967,295)
            uint uPopulation = 4000000000;
            Console.WriteLine("UInt example: " + uPopulation);

            // 7. long - 64-bit signed integer
            long worldPopulation = 7800000000L;
            Console.WriteLine("Long example: " + worldPopulation);

            // 8. ulong - 64-bit unsigned integer
            ulong starsInGalaxy = 10000000000000000000UL;
            Console.WriteLine("ULong example: " + starsInGalaxy);

            // 9. float - 32-bit floating point (~7 digits precision)
            float pi = 3.14f;
            Console.WriteLine("Float example: " + pi);

            // 10. double - 64-bit floating point (~15 digits precision)
            double goldenRatio = 1.6180339887;
            Console.WriteLine("Double example: " + goldenRatio);

            // 11. decimal - 128-bit decimal, high precision (good for money)
            decimal price = 199.99m; // m suffix required
            Console.WriteLine("Decimal example: " + price);

            // 12. char - 16-bit Unicode character
            char grade = 'A';
            Console.WriteLine("Char example: " + grade);

            // 13. bool - true or false
            bool isCSharpFun = true;
            bool isFishFlying = false;
            Console.WriteLine("Bool example (isCSharpFun): " + isCSharpFun);
            Console.WriteLine("Bool example (isFishFlying): " + isFishFlying);


            // ========= REFERENCE TYPES =========
            // (stored as references/pointers in memory)

            // String - sequence of characters
            string name = "Master Boss";
            Console.WriteLine("String example: " + name);

            // Object - base type of all types in C#
            object obj = "I can hold anything!";
            Console.WriteLine("Object example: " + obj);

            // Arrays - collection of same data type
            int[] numbers = { 10, 20, 30, 40 };
            Console.WriteLine("Array example (numbers[2]): " + numbers[2]);

            // Nullable types - allow value types to store null
            int? nullableInt = null;
            Console.WriteLine("Nullable int example: " + nullableInt);

            // Dynamic - type checked at runtime
            dynamic dyn = "I am dynamic!";
            Console.WriteLine("Dynamic example: " + dyn);

            // var - type inference (decided at compile time)
            var autoType = 123; // compiler infers int
            Console.WriteLine("Var example: " + autoType);
        }
    }
}
