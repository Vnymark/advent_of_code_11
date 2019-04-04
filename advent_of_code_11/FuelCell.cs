using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace advent_of_code_11
{
    class FuelCell
    {
        public string Id { get; set; }
        public List<int> Cordinates { get; set; }
        public int RackId { get; set; }
        public int PowerLevel { get; set; }

        public void CalculatePowerLevel(int gridSerialNumber)
        {
            List<int> PowerLevelNumbers = new List<int>();
            this.RackId = this.Cordinates.ElementAt(0) + 10;
            int pLCount = (this.RackId * this.Cordinates.ElementAt(1) + gridSerialNumber) * RackId;
            foreach (int n in Array.ConvertAll(pLCount.ToString().ToArray(), x => (int)x - 48))
            {
                PowerLevelNumbers.Add(n);
            }
            if (PowerLevelNumbers.Count >= 3)
            {
                PowerLevelNumbers.Reverse();
                this.PowerLevel = PowerLevelNumbers.ElementAt(2);
                this.PowerLevel += -5;
            }
            else
            {
                this.PowerLevel = 0;
            }
        }
    }
}
