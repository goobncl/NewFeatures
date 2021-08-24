using System;
using System.Runtime.CompilerServices;

namespace ModuleInitializers
{
    class Program
    {
        /// <summary>
        /// This function get called when assembly is loaded.
        /// </summary>
        [ModuleInitializer]
        internal static void Initialize()
        {
            Console.WriteLine("Module Initialization");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
