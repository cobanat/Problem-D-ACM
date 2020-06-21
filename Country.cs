using System;

namespace Problem_D
{
    public class Country
    {
        private string countryName;
        private int xl;
        private int yl;
        private int xh;
        private int yh;
        private int[,] countryMap;
        private int complete;
        public Country(string countryName, int xl, int yl, int xh, int yh)
        {
            this.countryName = countryName;
            this.xl = xl;
            this.yl = yl;
            this.xh = xh;
            this.yh = yh;
            countryMap = new int[xh - xl + 1, yh - yl + 1]; //done
            complete = 1000000000;
            setCountryMap();
        }
        private void setCountryMap()
        {
            for (int i = 0; i < countryMap.GetLength(0); i++)
            {
                for (int j = 0; j < countryMap.GetLength(1); j++)
                {
                    countryMap[i, j] = -1;
                }
            }
        }

        public int getX_L()
        {
            return xl;
        }
        public int getX_H()
        {
            return xh;
        }
        public int getY_L()
        {
            return yl;
        }
        public int getY_H()
        {
            return yh;
        }
        public void setX_L(int xl)
        {
            this.xl = xl;
        }
        public void setX_H(int xh)
        {
            this.xh = xh;;
        }
        public void setY_L(int yl)
        {
            this.yl = yl;
        }
        public void setY_H(int yh)
        {
            this.yh = yh;
        }
    }
}