using System.Collections.Generic;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontLine line_Top = new HorizontLine(0, mapWidth - 2, 0, '/');
            wallList.Add(line_Top);
            HorizontLine line_Bottom = new HorizontLine(0, mapWidth - 2, mapHeight - 1, '/');
            wallList.Add(line_Bottom);
            VerticalLine line_Left = new VerticalLine(0, mapHeight - 1, 0, '/');
            wallList.Add(line_Left);
            VerticalLine line_Reight = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '/');
            wallList.Add(line_Reight);

        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }

    }
}