namespace Repetition
{
    internal class Level4DemoA
    {
        public static void Run()
        {
            WriteLine("Terje", Alignment.Left);
            WriteLine("Terje", Alignment.Center);
            WriteLine("Terje", Alignment.Right);
        }

        private static void WriteLine(string name, Alignment alignment)
        {
            var x = Console.WindowWidth - name.Length;
            if (alignment == Alignment.Center)
            {
                Console.CursorLeft = x / 2;
            }
            else if (alignment == Alignment.Right)
            {
                Console.CursorLeft = x;
            }
            //Console.CursorLeft =
            //    alignment == Alignment.Center ? x / 2 :
            //    alignment == Alignment.Right ? x : 0;
            Console.WriteLine(name);
        }

        //private static void WriteLineLeft(string name)
        //{
        //    Console.WriteLine(name);
        //}

        //private static void WriteLineCenter(string name)
        //{
        //    var x = Console.WindowWidth - name.Length;
        //    Console.CursorLeft = x / 2;
        //    Console.WriteLine(name);
        //}

        //private static void WriteLineRight(string name)
        //{
        //    var x = Console.WindowWidth - name.Length;
        //    Console.CursorLeft = x;
        //    Console.WriteLine(name);
        //}


    }
}
