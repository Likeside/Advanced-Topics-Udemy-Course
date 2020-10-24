using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;



namespace Project_2
{
    
    class Program
    {
               
        static void Main(string[] args)
        {

         #region Linq and Lambda
        List<int> numbers = new List<int>{1, 2, 5, 7, 8, 10, 111, 22, 34}; 
        //Linq-метод
        var oddNumbers = from n in numbers
                        where n%2==1
                        select n;
        //Лямбда-выражение
        var evenNumbers = numbers.Where(n => (n%2==0));

        Console.WriteLine(string.Join(",", oddNumbers));
        Console.WriteLine(string.Join(",", evenNumbers));


        List<Animal> animals = new List<Animal>()
        {
            new Animal("Elephant", "John"),
            new Animal("Elephant", "Mary"),
            new Animal("Bear", "Bob"),
            new Animal("Dog", "John"),
            new Animal("Bear", "Mary")
        };

        //Лямбда-выражение с использованием Linq
        var elephants = animals.Where(n => (n.Type=="Elephant")).Select(n => (n.Name));
        Console.WriteLine(string.Join(",", elephants));
        #endregion
      
        #region Extension methods and extending classes
        var sortedByNameAnimalsTypes = animals.SortByName("John").Select(n => (n.Type));
        Console.WriteLine(string.Join(",", sortedByNameAnimalsTypes));
        Console.ReadLine(); 
        
        
        Point pointOne = new Point(5, 15);
        Point pointTwo = new Point(10, 35);

        
        
        Console.WriteLine(pointOne.Distance(pointTwo).XDistance);
        Console.WriteLine(pointOne.Distance(pointTwo).YDistance);

        Console.ReadLine();
        #endregion
        
        #region IComparable implementation
        
            Person FirstPerson = new Person(15, "Bobby");
            Person SecondPerson = new Person(25, "Billy");

            bool arePersonsEqual = AreEqual(FirstPerson, SecondPerson);
            Console.WriteLine(arePersonsEqual.ToString());
            #endregion
        }

        private static bool AreEqual<T>(T firstObject, T secondObject) where T: IComparable<T>
        {
            return (firstObject.CompareTo(secondObject) == 0);
        }
    }
}
