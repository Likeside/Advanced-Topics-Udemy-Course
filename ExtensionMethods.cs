using System.Collections.Generic;
using System.Drawing;
using System.Linq;
namespace Project_2
{
    public static class ExtensionMethods
    {
           public static List<Animal> SortByName(this List<Animal> animals, string name) {
                var sortedAnimals = animals.Where(n => (n.Name == name)).ToList();
                return sortedAnimals;
            }

           public static DistanceBetween Distance(this Point pointOne, Point pointTwo)
           {
               int xDistance = pointTwo.X - pointOne.X;
               int yDistance = pointTwo.Y - pointOne.Y;
               
               return new DistanceBetween(xDistance, yDistance);
           }
    }
}