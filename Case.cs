namespace Problem_D
{
    public class Case
    {
        private Country[] countries;
        private int day;
        private City[,] grid;

        public Case(Country[] countries)
        {
            this.countries = countries;
        }

        public void runCase()
        {
            if (countries.Length != 1)
            {
                day = 0;
                MapMaker maker = new MapMaker();
                grid = maker.makeMap(countries);
                MoneyExchangeSimulator simulator = new MoneyExchangeSimulator();
                simulator.simulate(ref grid);
            }
            else
            {
                day = 1;
            }
        }
    }
}