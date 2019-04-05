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
            var FuelCellList = new Dictionary<string, FuelCell>();
            List<Square> SquareList = new List<Square>();

            AddFuelCells();
            CalculateFuelCells();

            AddSquares();
            Console.WriteLine(CalculateLargestSquarePower());
            Console.ReadLine();

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
                        FuelCellList[x + "," + y] = fuelCell;
                        y++;
                    }
                    x++;
                }
            }

            void AddSquares()
            {
                int i = 1;
                while (i <= 300)
                {
                    int position = 300 - i + 1;

                    int x = 1;
                    while (x <= position)
                    {
                        int y = 1;
                        while (y <= position)
                        {

                            Square square = new Square
                            {
                                TopLeftCordinates = new List<int>
                                {
                                    x,
                                    y
                                },
                                Size = i
                            };
                            SquareList.Add(square);
                            y++;
                        }
                        x++;
                    }
                    i++;
                }
            }
            
            void CalculateFuelCells()
            {
                foreach (FuelCell fc in FuelCellList.Values)
                {
                    fc.CalculatePowerLevel(gridSerialNumber);
                }
            }

            string CalculateLargestSquarePower() {
                int highestSquarePowerLevel = 0;
                string highestSquareCordinates = null;
                int highestSquareSize = 0;
                foreach (Square square in SquareList)
                {
                    square.CalculatePowerLevel(FuelCellList, square.Size);
                    
                    if (highestSquarePowerLevel == 0 || highestSquarePowerLevel < square.PowerLevel)
                    {
                        highestSquarePowerLevel = square.PowerLevel;
                        highestSquareSize = square.Size;
                        highestSquareCordinates = square.GetCordinatesString();
                    }
                }
                 return highestSquareCordinates;
            }
        }
    }
}
