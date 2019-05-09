using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmgame
{
    class Barn
    {
        private Animal[] barna;
        private int capacity;
        private int quantity_animal;

        public Barn()
        {
            barna = new Animal[12];
            capacity = 40;
            quantity_animal = 0;
        }
        public Animal[] Barna
        {
            get { return barna; }
            set { barna = value; }
        }
        public string Newanimal(Animal new_)
        {
            int spaceleft = capacity;
            for (int i = 0; i < quantity_animal; i++)
            {
                spaceleft = capacity - barna[i].Size;
            }
            if (spaceleft - new_.Size < 0)
                return "sorry, theres is no more space in the barn";
            else
            {
                barna[quantity_animal] = new_;
                quantity_animal++;
                return "You have" + quantity_animal + "animals in the barn \n there is " + (spaceleft-new_.Size) + "amount of space left in the barn";
            }
        }
        public string WriteBarn()
        {
            string infoout = " ";
            for (int i = 0; i < quantity_animal; i++)

                infoout = barna[i].WriteAnimal();
                return infoout;
            
        }
    }
}
