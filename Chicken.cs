using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmgame
{
    class Chicken :Animal
    {
        public Chicken()
        {
            interval = 1;
            Earnings = 2;
            Expenses = 1;
            size = 5;
            prize = 100;
        }
        public int Dailyincome()
        {
            return Earnings - Expenses;
        }
        public override string WriteAnimal()
        {
            return "A chicken that earns you " + Dailyincome() + ":_ per day \n";
        }

    }
}
