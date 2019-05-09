using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmgame
{
    class Wallet
    {
        private ulong money;

        public Wallet(ulong money)
        {
            this.money = money;
        }
        public ulong Money
        {
            get { return money; }
            set { if (money >= 0) money = value; else money = 0; }
        }
        public string Checkwallet()
        {
            return "You have " + money + "kr";
        }
    }
}
