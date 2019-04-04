using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace advent_of_code_11
{
    class Square
    {
        public List<int> TopLeftCordinates { get; set; }
        public List<FuelCell> FuelCells { get; set; }
        public int PowerLevel { get; set; }

        public void CalculatePowerLevel(List<FuelCell> FuelCellList)
        {
            int x = this.TopLeftCordinates.ElementAt(0);
            this.FuelCells = new List<FuelCell>();
            while (x < this.TopLeftCordinates.ElementAt(0) + 3)
            {
                int y = this.TopLeftCordinates.ElementAt(1);
                while (y <= this.TopLeftCordinates.ElementAt(1) + 2)
                {
                    string fuelCellId = x + "," + y;
                    this.FuelCells.Add(FuelCellList.Find(fc => fc.Id == fuelCellId));
                    this.PowerLevel += this.FuelCells.Last().PowerLevel;
                    if (y < (this.TopLeftCordinates.ElementAt(1) + 2))
                    {
                        y++;
                    } else
                    {
                        break;
                    }
                }
                x++;
            }
        }

        public string getCordinatesString()
        {
            return this.TopLeftCordinates.ElementAt(0) + "," + this.TopLeftCordinates.ElementAt(1);
        }
    }
}
