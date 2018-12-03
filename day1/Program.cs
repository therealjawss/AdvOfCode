using System;
using System.Collections.Generic;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = readSequence("input.txt");

            int sum = 0;
            int i = 0;
            bool frequencyRepeated = false;
            List<int> frequencies = new List<int>();

            while (!frequencyRepeated) {
                sum += Int32.Parse(lines[i]);
                if (frequencies.Contains(sum))
                {
                    frequencyRepeated = true;
                }
                else {
                    frequencies.Add(sum);
                }
                if (++i == lines.Length) {
                    i = 0;
                }
            }
            
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        public static string[] readSequence(string filename) {
            string[] lines = System.IO.File.ReadAllLines(@".\"+filename);
            return lines;
        }
    }
}
