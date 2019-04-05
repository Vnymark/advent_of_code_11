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
        public int Size { get; set; }

        public void CalculatePowerLevel(Dictionary<string, FuelCell> FuelCellList, int i)
        {
            int x = this.TopLeftCordinates.ElementAt(0);
            this.FuelCells = new List<FuelCell>();
            while (x < this.TopLeftCordinates.ElementAt(0) + i)
            {
                int y = this.TopLeftCordinates.ElementAt(1);
                while (y <= this.TopLeftCordinates.ElementAt(1) + i-1)
                {
                    string fuelCellId = x + "," + y;

                    this.PowerLevel += FuelCellList[fuelCellId].PowerLevel;
                    if (y < (this.TopLeftCordinates.ElementAt(1) + i-1))
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

        public string GetCordinatesString()
        {
            return this.TopLeftCordinates.ElementAt(0) + "," + this.TopLeftCordinates.ElementAt(1);
        }
    }
}
