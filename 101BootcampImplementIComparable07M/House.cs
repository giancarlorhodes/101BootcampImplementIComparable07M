using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101BootcampImplementIComparable07M
{
    internal class House : IComparable<House>
    {
        public int SquareFootage { get; set; }
        public string Description { get; set; }

        public House(int sq) { this.SquareFootage = sq; }

        public House(int sq, string d) { this.SquareFootage = sq; this.Description = d; }

        public int CompareTo(House h)
        {

            if (h.SquareFootage > this.SquareFootage)
                return -1; // this instance precedes / comes before object passed in
            else if (h.SquareFootage < this.SquareFootage)
                return 1;
            else
                return 0;

        }

    }



}
