using System;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth1;
        int mapHeigth1;
        char sym;

        Random random = new Random();


        public FoodCreator(int mapWidth, int mapHeigth, char sym)
        {
            this.mapWidth1 = mapWidth;
            this.mapHeigth1 = mapHeigth;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth1 - 4);
            int y = random.Next(2, mapHeigth1 - 4);
            return new Point(x, y, sym);
        }
    }
}