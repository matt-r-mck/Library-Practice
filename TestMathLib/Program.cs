using System;
using MathLib;

namespace TestMathLib {
    class Program {
        static void Main(string[] args) {

            var math = new MathLib.Math();
            var answer = math.Add(1, 2);
            Console.WriteLine($"{answer}");

            answer = math.Subtract(11, 7);
            Console.WriteLine($"{answer}");

            Console.WriteLine(math);
        }
    }
}
