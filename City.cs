namespace Problem_D
{
    public class City
    {
        private int x_position;
        private int y_position;
        private int numbersOfCountries;
        private int[] motifCoins;

        public City(int x_position, int y_position, int countryIndx, int numbersOfCountries)
        {
            this.x_position = x_position;
            this.y_position = y_position;
            motifCoins = new int[numbersOfCountries];
            motifCoins[countryIndx] = 1_000_000;
        }

        public City(int x_position, int y_position, int numbersOfCountries)
        {
            this.x_position = x_position;
            this.y_position = y_position;
            motifCoins = new int[numbersOfCountries];
        }

        public bool done()
        {
            for (int i = 0; i < numbersOfCountries; i++)
            {
                if (motifCoins[i] == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}