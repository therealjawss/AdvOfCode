using System;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = readSequence("input.txt");
            int hastwo = 0;
            int hasthree = 0;

            foreach(var line in lines)
            {
                if (has(line, 3))
                {
                    hasthree++;
                }
                if (has(line, 2))
                {
                    hastwo++;
                }
                
            }
            Console.WriteLine(hastwo * hasthree);
            Console.ReadKey();
 
        }
        public static string[] readSequence(string filename)
        {
            string[] lines = System.IO.File.ReadAllLines(@".\" + filename);
            return lines;
        }

        public static bool has(string sequence, int limit) {
            int counter = 1;

            for (int i = 0; i< sequence.Length; i++) {
                for (int j = 0; j < sequence.Length; j++) {
                    if (i == j) continue;
                    if (sequence[i] == sequence[j]) {
                        counter++;
                    }
                
                }

                if (counter == limit) {
                    return true;
                }
                else
                    counter = 1;
                
            }
            return false;
        }
      
    }
}
