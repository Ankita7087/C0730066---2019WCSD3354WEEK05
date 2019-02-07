using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5
{
   
    
        class Program
        {
            static void Main(string[] args)
            {
                var a = new TestQuestion2();
            var b = new BirthdayParty();
        
            b.setupPartyList();
            Console.WriteLine(b.printPartyList());
            Console.WriteLine(b.printPartyList());
            Console.ReadLine();
               
            }
        }
        class TestQuestion2
        {
            public int myFavouiteVariable = 0;
            public void PlayingWithForLoops()
            {

                for (; MyMethod();)
                {
                    if (myFavouiteVariable > 10)
                    {
                        break;
                    }
                    Console.WriteLine("i am in the for loop");
                }
            }
            public bool MyMethod()
            {
                myFavouiteVariable++;
                return true;
            }
        }


    class Dog
    {
        public Dog(string name, string breed)
        {
            dogName = name;
            dogBreed = breed;
        }

        public string dogName;
        public string dogBreed;
        public Dog nextDog;
        public Dog previousDog;
    }
    class BirthdayParty
    {
        public Dog Peanut;
        public Dog Fifi;
        public Dog Clarence;
        public Dog Giselle;
        public Dog Lulu;
        public Dog Roy;

        public Dog head;
        public Dog tail;
        public Dog temporary;

        public void setupPartyList()
        {
            Peanut = new Dog("Peanut", "Bichon");
            Fifi = new Dog("Fifi", "Poodle");
            Clarence = new Dog("Clarence", "German Sheppard");
            Giselle = new Dog("Giselle", "Border Collie");
            Lulu = new Dog("Lulu", "Shitzu");
            Roy = new Dog("Roy", "Beagle");

            Peanut.previousDog = null;
            Peanut.nextDog = Fifi;

            Fifi.previousDog = Peanut;
            Fifi.nextDog = Clarence;

            Clarence.previousDog = Fifi;
            Clarence.nextDog = Giselle;

            Giselle.previousDog = Clarence;
            Giselle.nextDog = Lulu;

            Lulu.previousDog = Giselle;
            Lulu.nextDog = Roy;

            Roy.previousDog = Lulu;
            Roy.nextDog = null;

            head = Peanut;
            tail = Roy;
        }
    
        public string printPartyList()
        {
            string inviteList = "*--";
            temporary = head;

            while (temporary.nextDog != null)
            {
                inviteList += temporary.dogName + " * --- * ";
                temporary = temporary.nextDog;
            }
            inviteList += temporary.dogName + " * --- * ";
            return inviteList;
        }

       
        public string printPartyList_reverse()
        {
            string inviteList = "*--";
            temporary = tail;

            while (temporary.previousDog != null)
            {
                inviteList += temporary.dogName + " * --- * ";
                temporary = temporary.previousDog;
            }
            inviteList += temporary.dogName + " * --- * ";
            return inviteList;
        }
    }
}


