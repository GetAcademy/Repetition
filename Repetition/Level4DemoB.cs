namespace Repetition
{
    internal class Level4DemoB
    {
        public static void Run(int size)
        {
            size /= 2;
            for (int i = 0; i < size; i++)
            {
                WriteRowStartWithCyan(size);
                WriteRowStartWithMagenta(size);
            }
        }

        private static void WriteRowStartWithMagenta(int size)
        {
            for (var i = 0; i < 3; i++)
            {
                WriteSingleRowStartWithMagenta(size);
            }
        }
        private static void WriteRowStartWithCyan(int size)
        {
            for (var i = 0; i < 3; i++)
            {
                WriteSingleRowStartWithCyan(size);
            }
        }
        private static void WriteSingleRowStartWithCyan(int size)
        {
            WriteSingleRow(size, ConsoleColor.DarkCyan, ConsoleColor.DarkMagenta);
        }

        private static void WriteSingleRowStartWithMagenta(int size)
        {
            WriteSingleRow(size, ConsoleColor.DarkMagenta, ConsoleColor.DarkCyan);
        }

        private static void WriteSingleRow(int size, ConsoleColor color1, ConsoleColor color2)
        {
            for (var i = 0; i < size; i++)
            {
                WritePattern(color1);
                WritePattern(color2);
            }
            Console.WriteLine();
        }

        static void WriteCyanPattern()
        {
            WritePattern(ConsoleColor.DarkCyan);
        }

        static void WriteMagentaPattern()
        {
            WritePattern(ConsoleColor.DarkMagenta);
        }

        static void WritePattern(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write("XXXX");
        }
    }
}
