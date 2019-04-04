using System;
using System.Collections.Generic;

namespace advent_of_code_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Grid serial number is the puzzle input.
            int gridSerialNumber = 1955;
            List<FuelCell> FuelCellList = new List<FuelCell>();

            AddFuelCells();
            Console.WriteLine();

            void AddFuelCells()
            {
                int x = 1;
                while (x <= 300)
                {
                    int y = 1;
                    while (y <= 300)
                    {
                        FuelCell fuelCell = new FuelCell
                        {
                            Cordinates = new List<int>
                        {
                            x,
                            y
                        }
                        };
                        FuelCellList.Add(fuelCell);
                        y++;
                    }
                    x++;
                }
            }
        }
    }
}
