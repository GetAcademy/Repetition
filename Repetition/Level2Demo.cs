namespace Repetition
{
    internal class Level2Demo
    {
        public static void Run()
        {
            /*
             *
             * Operatorer:
             *  - aritmetiske operatorer: +, -, *, /
             *  - tilordningsoperator: =, +=, -=, *=, /=, ++, --
             *  - sammenligningsoperatorer: <, >, ==, !=, <=, >=
             *  - logiske operatorer: !, &&, ||
             */

            var perPaid = 300;
            var pålPaid = 3000;
            var espenPaid = 0;
            var totalPaid = perPaid + pålPaid + espenPaid;
            var costPerPerson = totalPaid / 3;
            var perBalance = perPaid - costPerPerson;
            var pålBalance = pålPaid - costPerPerson;
            var espenBalance = espenPaid - costPerPerson;
        }
    }
}
