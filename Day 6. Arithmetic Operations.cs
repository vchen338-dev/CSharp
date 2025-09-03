using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                // Declare some numbers
                int a = 20;
                int b = 6;

                Console.WriteLine("Arithmetic Operators in C#");
                Console.WriteLine("---------------------------");

                // Addition (+)
                int sum = a + b;
                Console.WriteLine($"Addition: {a} + {b} = {sum}");

                // Subtraction (-)
                int difference = a - b;
                Console.WriteLine($"Subtraction: {a} - {b} = {difference}");

                // Multiplication (*)
                int product = a * b;
                Console.WriteLine($"Multiplication: {a} * {b} = {product}");

                // Division (/)
                int quotient = a / b; // integer division
                double division = (double)a / b; // exact division
                Console.WriteLine($"Division (int): {a} / {b} = {quotient}");
                Console.WriteLine($"Division (double): {a} / {b} = {division}");

                // Modulus (%)
                int remainder = a % b;
                Console.WriteLine($"Modulus: {a} % {b} = {remainder}");

                // Unary Plus (+a) and Minus (-a)
                int unaryPlus = +a;
                int unaryMinus = -a;
                Console.WriteLine($"Unary Plus: +{a} = {unaryPlus}");
                Console.WriteLine($"Unary Minus: -{a} = {unaryMinus}");

                // Increment (++)
                int preInc = ++a; // increases first, then uses
                Console.WriteLine($"Pre-Increment (++a): {preInc}");
                int postInc = b++; // uses first, then increases
                Console.WriteLine($"Post-Increment (b++): {postInc}, now b = {b}");

                // Decrement (--)
                int preDec = --a; // decreases first, then uses
                Console.WriteLine($"Pre-Decrement (--a): {preDec}");
                int postDec = b--; // uses first, then decreases
                Console.WriteLine($"Post-Decrement (b--): {postDec}, now b = {b}");
            }
        }

    }


