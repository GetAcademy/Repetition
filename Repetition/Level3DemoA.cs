namespace Repetition
{
    internal class Level3DemoA
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
            WriteSingleRow(ConsoleColor.DarkCyan, ConsoleColor.DarkMagenta);
        }

        private static void WriteSingleRowStartWithMagenta()
        {
            WriteSingleRow(ConsoleColor.DarkMagenta, ConsoleColor.DarkCyan);
        }

        private static void WriteSingleRow(ConsoleColor color1, ConsoleColor color2)
        {
            WritePattern(color1);
            WritePattern(color2);
            WritePattern(color1);
            WritePattern(color2);
            WritePattern(color1);
            WritePattern(color2);
            WritePattern(color1);
            WritePattern(color2);
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
