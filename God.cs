using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace L3_Interfaces_Abstraction_CPRG211E
{
    public class God
    {
        public List<IAnimal> animals = new List<IAnimal>();
        public God()
        {
            //class for creating Animals
        }
        public void GodMode()
        {
            while (true)
            {
                Console.WriteLine("To create and animal, press '1'\n" +
                    "to see info for all animals, press '2'\n" +
                    "to exit the program, press '0'\n");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int selection))
                {
                    if (selection == 0)
                    {
                        break;
                    }
                    else if (selection == 1)
                    {
                        this.CreateAnimal();
                    }
                    else if(selection == 2)
                    {
                        this.AnimalInfo();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }
        }
        public void CreateAnimal()
        {
            Console.WriteLine("What is the animal's name?:");
            string name = Console.ReadLine(); // get name from user
            Console.WriteLine($"What is {name}'s height?: ");
            int height = GetInt();
            Console.WriteLine($"What colour is {name}?:");
            string colour = Console.ReadLine(); // get colour from user
            Console.WriteLine($"How old is {name}?:");
            int age = GetInt();
            while (true) // ask if dog or cat & verify input
            {
                Console.WriteLine($"If {name} a dog press '1'\nIf {name} is a cat press '2'");
                string choice = Console.ReadLine();
                if (int.TryParse(choice, out int type))
                {
                    if (type == 1) // if input 1, make new dog
                    {
                        IAnimal dog = new Dog(name, height, colour, age);
                        animals.Add(dog); // add to list
                        Console.WriteLine(dog); // ToString
                        dog.Eat();
                        dog.Cry();
                        return;
                    }
                    else if (type == 2) // if input 2, make new cat
                    {
                        IAnimal cat = new Cat(name, height, colour, age);
                        animals.Add(cat);
                        Console.WriteLine(cat);
                        cat.Eat();
                        cat.Cry();
                        return; // exit CreateAnimal method
                    }
                }
                // if input was not 1 or 2, print error and try again.
                Console.WriteLine("Invalid input.");
            }
            
        }
        public void AnimalInfo()
        {
            if (animals.Count == 0)
            {
                Console.WriteLine("Error: no animals in list.");
                return;
            }
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal+"\n");
            }
        }
        public int GetInt()
        {
            while (true) // loop for getting and chacking int from user
            {
                Console.WriteLine("Please enter a whole number:");
                string input = Console.ReadLine(); // get age from user
                if (int.TryParse(input, out int number)) // check if whole number
                {
                    return number;
                }
                else // input was not an int, Error, ask again.
                {
                    Console.WriteLine("Invalid input, please enter a whole number");
                }
            }
        }
        

    }
}
