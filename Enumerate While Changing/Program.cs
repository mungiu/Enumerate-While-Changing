using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumerate_While_Changing
{
    class Program
    {
        static void Main(string[] args)
        {
            AllDaysOfWeek allDays = new AllDaysOfWeek();
            foreach (string day in allDays)
            {
                Console.WriteLine(day);
            }
        }

        public class AllDaysOfWeek : IEnumerable<string>
        {
            public IEnumerator<string> GetEnumerator()
            {
                Console.WriteLine("Calling generic GetEnumerator");
                //"yield return" is not "return"
                //C# figures you want the compiler to write an enumerator for you
                //so the compiler does all the work for you
                yield return "Monday";
                yield return "Tuesday";
                yield return "Wednesday";
            }

            //this second method is generally obsolete
            //inherits from old non-generic IEnumerable interface
            //which exposes the same method which is not generic (not strongly typed)
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
