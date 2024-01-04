/*
    Skapa ett program som använder ArrayList klass för att spara listan av personer. Skapa en klass
    Person med namn och ålder och ToString() metoden för att skriva ut resultat.
    Definiera ArrayList och få användaren att ange namn och ålder av tre personer. Spara i listan.
    Skriva ut data.
 */
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace exerciseArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> personList = new List<Person>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ange en persons namn:");
                string namn = Console.ReadLine();
                Console.WriteLine("Ange personens ålder:");
                int ålder = int.Parse(Console.ReadLine());
                Person person = new Person(namn, ålder);
                personList.Add(person);
            }
            Console.WriteLine("Personlista:");
            foreach (Person person in personList)
            {
                Console.WriteLine(person.ToString());
            }
        }
        internal class Person 
        { 

            public string Name { get; set; }
            public int Age { get; set; }

            public Person (string name, int age)
            {
                Name = name;
                Age = age;
            }

            public override string ToString()
            {
                return $"Namn: {Name}, ålder: {Age}.";
            }
        }
    }
}
