using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticeUi
{
    public class Animal
    {
        private string ownerName;
        private string Animalname;
        private int animalAge;

        //why we use Setters and Getters 
        public string _OwnerName { get { return ownerName; } set { ownerName = value; } }
        public string _AnimalName { get { return Animalname; } set { Animalname = value; } }
        public int _AnimalAge { get { return animalAge; } set { animalAge=value; } }
    }
}
