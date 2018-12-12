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

            VerifyTampering();
            VerifyDebugging();

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }

        public static void VerifyTampering()
        {
            // Dotfuscator will add Tamper detection and notification code here
            // - configured in Dotfuscator CE in Injection > Checks
        }

        private static void OnTamperVerified(bool wasTampered)
        {
            if (wasTampered)
            {
                Console.WriteLine("App HAS been tampered with");
            }
            else
            {
                Console.WriteLine("App has NOT been tampered with");
            }
        }

        public static void VerifyDebugging()
        {
            // Dotfuscator will add code here to detect if the application is being debugged
            // - configured in Dotfuscator CE in Injection > Checks
        }

        private static void OnDebuggingVerified(bool isDebuggerRunning)
        {
            if (isDebuggerRunning)
            {
                Console.WriteLine("App IS running under a debugger");
            }
            else
            {
                Console.WriteLine("App is NOT running under a debugger");
            }
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