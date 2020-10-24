using System;

namespace Project_2
{
    public class Person: IComparable<Person>
    {
        public int Age { get; set; }
        
        public  string Name { get; set; }

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
        
        public int CompareTo(Person other)
        {

            return AgeCompare(other);
            // else if (parameter =="Name")
            // {
            //     return NameCompare(other);
            // }
            // else
            // {
            //     return 1;
            // }
        }

        private int AgeCompare(Person other)
        {
            if (this.Age < other.Age)
            {
                return -1;
            }
            else if (this.Age == other.Age)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private int NameCompare(Person other)
        {
            var compareResult = String.CompareOrdinal(this.Name, other.Name);

            if (compareResult < 0)
            {
                return -1;
            }
            else if (compareResult == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}