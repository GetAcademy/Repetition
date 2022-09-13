namespace Repetition
{
    internal class Level3DemoB
    {
        public static void Run()
        {
            var perPaid = 300;
            var pålPaid = 3000;
            var espenPaid = 0;
            var costPerPerson = CalculateCostPerPerson(perPaid, pålPaid, espenPaid);
            var perBalance = perPaid - costPerPerson;
            var pålBalance = pålPaid - costPerPerson;
            var espenBalance = espenPaid - costPerPerson;
        }

        private static int CalculateCostPerPerson(int p1paid, int p2paid, int p3paid)
        {
            var totalPaid = p1paid + p2paid + p3paid;
            var costPerPerson = totalPaid / 3;
            return costPerPerson;
        }
    }
}
