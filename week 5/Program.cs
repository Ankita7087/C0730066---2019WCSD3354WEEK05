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
                a.PlayingWithForLoops();
                Console.ReadLine();
            }
        }
        class TestQuestion2
        {
            public int myFavouiteVariable = 0;
            public void PlayingWithForLoops()
            {
                // write a for loop to add 10 numbers
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

    class dog
    {
        public string dog_name;
        public string dog_breed;
        public dog next_dog;
        public dog prev_dog;
    }
    class birthday_party
    {
        public dog fifi;
        public dog clearnace;
        public dog head;
        public dog tail;
        public dog bruno;
    }
    }
