using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition
{
    internal class Level1Demo
    {
        public static void Run()
        {
            WriteRowStartWithCyan();
            WriteRowStartWithMagenta();
            WriteRowStartWithCyan();
            WriteRowStartWithMagenta();
            WriteRowStartWithCyan();
            WriteRowStartWithMagenta();
            WriteRowStartWithCyan();
            WriteRowStartWithMagenta();
        }

        private static void WriteRowStartWithMagenta()
        {
            WriteSingleRowStartWithMagenta();
            WriteSingleRowStartWithMagenta();
            WriteSingleRowStartWithMagenta();
        }
        private static void WriteRowStartWithCyan()
        {
            WriteSingleRowStartWithCyan();
            WriteSingleRowStartWithCyan();
            WriteSingleRowStartWithCyan();
        }
        private static void WriteSingleRowStartWithCyan()
        {
            WriteCyanPattern();
            WriteMagentaPattern();
            WriteCyanPattern();
            WriteMagentaPattern();
            WriteCyanPattern();
            WriteMagentaPattern();
            WriteCyanPattern();
            WriteMagentaPattern();
            Console.WriteLine();
        }

        private static void WriteSingleRowStartWithMagenta()
        {
            WriteMagentaPattern();
            WriteCyanPattern();
            WriteMagentaPattern();
            WriteCyanPattern();
            WriteMagentaPattern();
            WriteCyanPattern();
            WriteMagentaPattern();
            WriteCyanPattern();
            Console.WriteLine();
        }

        static void WriteCyanPattern()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("####");
        }

        static void WriteMagentaPattern()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("####");
        }
    }
}
