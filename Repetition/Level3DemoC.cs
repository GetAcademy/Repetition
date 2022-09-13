namespace Repetition
{
    internal class Level3DemoC
    {
        public static void Run()
        {
            // Pause til 11:07

            Console.WriteLine(FormatCity("Stavern"));
            Console.WriteLine(FormatCity("Oslo"));
            Console.WriteLine(FormatCity("Larvik"));

            //WriteCity("Oslo");
            //WriteCity("Stavern");
            //WriteCity("Larvik");

            //Console.Write("*** ");
            //Console.Write("Stavern");
            //Console.WriteLine(" ***");

            //Console.Write("*** ");
            //Console.Write("Larvik");
            //Console.WriteLine(" ***");
        }

        private static void WriteCity(string city)
        {
            Console.Write("*** ");
            Console.Write(city);
            Console.WriteLine(" ***");
        }

        private static string FormatCity(string city)
        {
            return $"*** {city} ***";
        }
    }
}
