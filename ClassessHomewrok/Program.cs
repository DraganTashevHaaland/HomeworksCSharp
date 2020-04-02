using System;

namespace ClassesHomework
{
    public class Dog
    {
          //public Dog(string name, string race, string color)
          //{
          //  Name = name;
          //  Race = race;
          //  Color = color;
          //}
          public string Name { get; set; }
          public string Race { get; set; }
          public string Color { get; set; } 
        
        public void Eating()
        {
            Console.WriteLine("The dog with name " + Name + " ,is now eating");
        }

        public void Playing()
        {
            Console.WriteLine("The dog with breed " + Race + " is now playing");
        }

        public void ChaseTail()
        {
            Console.WriteLine("The dog with name " + Name + " , also with breed " + Race + " and color " + Color + " , is now chasing his tail.");
        }
    }
    class Porgram
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.Name = "Cesar";
            dog.Race = "labradour";
            dog.Color = "white";

            dog.Eating();
            dog.Playing();
            dog.ChaseTail();
        }
    }

   
    
}

