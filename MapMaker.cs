using System;

namespace Problem_D
{
    public class MapMaker
    {
        public City[,] makeMap(Country[] countries)
        {
            City[,] grid = makeGrid(ref countries);
            fillByNull(ref grid);
            buildCityies(ref grid, ref countries);
            return grid;
        }

        private City[,] makeGrid(ref Country[] countries)
        {
            int min_X = countries[0].getX_L();
            int maxValue = 0;
            for (int i = 0; i < countries.GetLength(0); i++)
            {
                min_X = Math.Min(min_X, countries[i].getX_L());
                maxValue = Math.Max(maxValue, countries[i].getX_L());
                maxValue = Math.Max(maxValue, countries[i].getX_H());
                maxValue = Math.Max(maxValue, countries[i].getY_L());
                maxValue = Math.Max(maxValue, countries[i].getY_H());
                
            }
            for (int i = 0; i < countries.GetLength(0); i++)
            {
                int newX_L = countries[i].getX_L() - min_X;
                countries[i].setX_L(newX_L);
                int newX_H = countries[i].getX_H() - min_X;
                countries[i].setX_H(newX_H);
                int newY_L = countries[i].getY_L() - min_X;
                countries[i].setY_L(newY_L);
                int newY_H = countries[i].getY_H() - min_X;
                countries[i].setY_H(newY_H);
            }
            
            return new City[maxValue, maxValue];
        }

        private void buildCityies(ref City[,] grid, ref Country[] countries)
        {
            for (int i = 0; i < countries.GetLength(0); i++)
            {
                for (int j = countries[i].getX_L(); j <= countries[i].getX_H(); j++)
                {
                    for (int k = countries[i].getY_L(); k <= countries[i].getY_H(); k++)
                    {
                        int numOfMotif = countries.Length;
                        int x_positon = j;
                        int y_position = k;
                        int countryIndx = i;
                        grid[j, k] = new City(x_positon, y_position, countryIndx, numOfMotif);
                    }
                }
            }
        }

        private void fillByNull(ref City[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = null;
                }
            }
        }
    }
}