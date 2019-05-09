namespace Farmgame
{
    class Cow : Animal
    {
        public Cow()
        {
            interval = 1;
            Earnings = 30;
            Expenses = 10;
            size = 10;
            prize = 1200;

        }
        public int Dailyincome()
        {
            return Earnings - Expenses;
        }
        public override string WriteAnimal()
        {
            return "A cow that earns you " + Dailyincome() + ":- each day. \n";
        }
    }
}
