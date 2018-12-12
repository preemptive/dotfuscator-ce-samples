// Copyright (c) 2017 PreEmptive Solutions; All Right Reserved, http://www.preemptive.com/
//
// This source is subject to the Microsoft Public License (MS-PL).
// Please see the License.txt file for more information.
// All other rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.

using System;

namespace DotfuscatorCommunitySample
{
    public class Hello
    {
        static void Main(string[] args)
        {
            Converse("Alice", "Bob");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static bool OptIn()
        {
            return true;
        }

        private static void Converse(string name1, string name2)
        {
            Friendly friend1 = new Friendly(name1);
            Friendly friend2 = new Friendly(name2);

            friend1.SayHello();
            friend2.SayHello();

            friend1.SayGoodbye(friend2.Name);
            friend2.SayGoodbye(friend1.Name);
        }
    }

    internal class Friendly
    {
        private string myName;

        public Friendly(string name)
        {
            myName = name;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello, my name is {0}", myName);
        }

        public void SayGoodbye(string othername)
        {
            Console.WriteLine("Goodbye {0}", othername);
        }

        public string Name
        {
            get { return myName; }
            set { myName = value; }
        }
    }
}