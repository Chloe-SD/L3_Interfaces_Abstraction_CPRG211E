using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
                int selection = CreationMenu(); // display creation menu
                //int selection = GetInt(0, 2); // get int between 0-2
                if (selection == 0) // end program
                {
                    break;
                }
                else if (selection == 1) // get info and create new animal
                {
                    this.GetAnimalInfo();
                }
                else if (selection == 2) // display animals in list
                {
                    this.DisplayAllAnimals();
                }
            }
        }
        public int CreationMenu()
        {
            string menu = $"To create and animal, press '1'\n" +
                    "to see info for all animals, press '2'\n" +
                    "to exit the program, press '0'\n";
            return GetInt(menu, 0, 2);
        }
        public void GetAnimalInfo()
        {
            // Animal Name
            Console.WriteLine("What is the animal's name?:");
            string name = Console.ReadLine(); // get name from user
            // Animal height
            string heightPrompt = $"What is {name}'s height in inches?: ";
            int height = GetInt(heightPrompt, 0, 99); // get height from user
            // Animal colour
            Console.WriteLine($"What colour is {name}?:");
            string colour = Console.ReadLine(); // get colour from user
            // Animal age
            string namePrompt = $"How old is {name}?:";
            int age = GetInt(namePrompt, 0, 99); // get age from user

            CreateAnimal(name, height, colour, age); // create animal
        }
        public void CreateAnimal(string name, int height, string colour, int age)
        {
            //determine if cat or dog
            string animalType = $"If {name} a dog press '1'\nIf {name} is a cat press '2'";
            int type = GetInt(animalType, 1, 2); // get selection from user
            if (type == 1) // if input 1, make new dog
            {
                IAnimal dog = new Dog(name, height, colour, age);
                animals.Add(dog); // add to list
                NewAnimalDisplay(dog); // display new animal info
                return; 
            }
            else // if input 2, make new cat
            {
                IAnimal cat = new Cat(name, height, colour, age);
                animals.Add(cat);
                NewAnimalDisplay(cat);
                return; // exit CreateAnimal method
            }
        }
        public void NewAnimalDisplay(IAnimal animal) 
        {
            Console.WriteLine(animal);
            animal.Eat();
            animal.Cry();
        }
        public void DisplayAllAnimals()
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
        public int GetInt(string prompt, int min, int max)
        {
            while (true) // loop for getting and chacking int from user
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine(); // get int from user
                if (int.TryParse(input, out int number)) // check if whole number
                {
                    if ((number >= min)&&(number <= max)) //check if within boundary
                    {
                        return number;
                    }
                }
                // input was not an int, or not in boundary, Error, ask again.
                Console.WriteLine($"Invalid input, please enter a whole number between {min} and {max}:");       
            }
        }
    }
}
