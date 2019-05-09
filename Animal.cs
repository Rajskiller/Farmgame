using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmgame
{
    
    abstract class Animal
    {
        protected int interval;
        protected int earnings;
        protected int expenses;
        protected int size;
        protected ushort prize;
        
        public virtual string WriteAnimal()
        {
            return "You shall not see this";
        }
        public int Interval { get => interval; set => interval = value; }
        public int Earnings { get => earnings; set => earnings = value; }
        public int Expenses { get => expenses; set => expenses = value; }
        public int Size{ get => size; set => size = value; }
        public ushort Prize { get => prize; set => prize = value; }
    }        
}
