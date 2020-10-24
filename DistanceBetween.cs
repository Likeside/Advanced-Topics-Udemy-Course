using System;
using System.Drawing;

namespace Project_2
{
    public class DistanceBetween
    {
        public int XDistance { get; set; }
        
        public int YDistance { get; set; }

        public DistanceBetween(int xDistance, int yDistance)
        {
            XDistance = xDistance;
            YDistance = yDistance;
        }
    }

}