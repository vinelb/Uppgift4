using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift4
{ //Detta är en klass som vi kallar Animal
    public class Animall
    {   //Sätter ett startnamn och ett startår för djuret
        private string Name = "jan";
        private int Age = 0;
        //Gör så att man kan sätta namn
        public string getName()
        {
            return this.Name;
        }
        //Gör sp att man kan ändra namn
        public void setName(string Name)
        {
            this.Name = Name;
        }
        //Gör så att man kan ge djuret ett år 
        public int getAge()
        {
            return this.Age;
        }
        //Gör så att man kan ändra åldern
        public void setAge(int Age)
        {
            this.Age = Age;
        }
        //Ger oss en klass i en klass som vi döper till dog
        public class Dog : Animal
        {
            private int TailLength = 0;
            //Ger hunden en svans
            public int getTailLength()
            {
                return this.TailLength;
            }
            public void setTailLength(int TailLength)
            {
                this.TailLength = TailLength;
            }
        }
    }
}



    
