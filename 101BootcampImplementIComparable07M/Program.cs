using System;

namespace _101BootcampImplementIComparable07M
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // TESTING 
            House h1 = new House(15500, "6743 Daveport Drive, Smallville, Ohio 58390");
    
            House h2 = new House(1200, "1101 Willocreek Lane, Columbia, MO 65203");

            House h3 = new House(4500, "1123 Willocreek Lane, Columbia, MO 65203");

            House h4 = new House(15500, "14566 Daveport Drive, Smallville, Ohio 58390");

            House h5 = new House(4534, "345 Daveport Drive, Smallville, Ohio 58390");

            House[] houses = new House[5];
            houses[0] = h1;
            houses[1] = h2;     
            houses[2] = h3;
            houses[3] = h4;
            houses[4] = h5;


            // using the Icomparable interface
            Array.Sort(houses);

            //// printing out result of the sort
            //Array.ForEach(houses, h => Console.WriteLine($"House description and footage: {h.Description}, {h.SquareFootage}"));


            Console.WriteLine();
            

            // printing out result of the sort
            for (int i = 0; i < houses.Length; i++)
            {
                Console.WriteLine($"House description and footage: {houses[i].Description}, {houses[i].SquareFootage}");
            }

            foreach (var item in houses) // this works because houses is a array and IEnumerable is implemented for arrays
            {

            }

        }
    }
}
