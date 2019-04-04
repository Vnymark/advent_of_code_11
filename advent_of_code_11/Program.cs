using System;
using System.Collections.Generic;
using System.Linq;

namespace advent_of_code_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Grid serial number is the puzzle input.
            int gridSerialNumber = 1955;
            List<FuelCell> FuelCellList = new List<FuelCell>();
            List<Square> SquareList = new List<Square>();

            AddFuelCells();
            foreach (FuelCell fc in FuelCellList)
            {
                fc.CalculatePowerLevel(gridSerialNumber);
            }

            AddSquares();
            Console.WriteLine(CalculateLargestSquarePower());
            Console.ReadLine();

            void AddSquares()
            {
                int x = 1;
                while (x <= 298)
                {
                    int y = 1;
                    while (y <= 298)
                    {
                        Square square = new Square
                        {
                            TopLeftCordinates = new List<int>
                        {
                            x,
                            y
                        }
                        };
                        SquareList.Add(square);
                        y++;
                    }
                    x++;
                }
            }
           
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
                            Id = x + "," + y,
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

            string CalculateLargestSquarePower() {
                int highestSquarePowerLevel = 0;
                string highestSquareCordinates = null;
                foreach (Square square in SquareList)
                {
                    Console.WriteLine("Square with Top-Left Cordinates: {0},{1}", square.TopLeftCordinates.ElementAt(0), square.TopLeftCordinates.ElementAt(1));
                    square.CalculatePowerLevel(FuelCellList);
                    
                    if (highestSquarePowerLevel == 0 || highestSquarePowerLevel < square.PowerLevel)
                    {
                        highestSquarePowerLevel = square.PowerLevel;
                        highestSquareCordinates = square.getCordinatesString();
                    }
                }
                return highestSquareCordinates;
            }
        }
    }
}
