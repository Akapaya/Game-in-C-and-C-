using System;

namespace batalhanaval32313
{
    public class Ferramentas
    {
        Random rand = new Random();

        int[] Xdirection = new int[] { 0, 1, 0, -1 };
        int[] Ydirection = new int[] { 1, 0, -1, 0 };

        public int[] Check2Position(int x, int y, string[,] navios)
        {
            int i;
            int[] pos = new int[2];
            i = rand.Next(0, 4);
            if (navios[x, y] == null && navios[x + Xdirection[i], y + Ydirection[i]] == null)
            {
                    pos[0] = x + Xdirection[i];
                    pos[1] = y + Ydirection[i];
                    return new int[] { pos[0], pos[1] };
            }
            return new int[]{0,0};
        }

        int[] X2direction = new int[] { 1, -1 };
        int[] Y2direction = new int[] { 1, -1, };

        public int[,] CheckCruzadoPosition(int x, int y, string[,] navios)
        {
            int randNumber1;
            int randNumber2;
            int[,] pos = new int[2,2];
            randNumber1 = rand.Next(0, 4);
            randNumber2 = rand.Next(0, 4);
            try
            {
                if (navios[x, y] == null 
                    && navios[x + X2direction[randNumber1], y ] == null
                    && navios[(x + X2direction[randNumber1]) , (y + Y2direction[randNumber2])] == null)
                {
                    pos[0, 0] = x + X2direction[randNumber1];
                    pos[0, 1] = y ;
                    pos[1, 0] = (x + X2direction[randNumber1]);
                    pos[1, 1] = (y + Y2direction[randNumber2]);
                    return new int[,] { { pos[0, 0] }, { pos[0, 1] }, { pos[1, 0] }, { pos[1, 1] } };
                }
            }
            catch
            {
                return new int[,] { { 0 }, { 0 }, { 0 }, { 0 } };
            }
            return new int[,] { { 0 }, { 0 }, { 0 }, { 0 } };
        }

        public int[,] CheckEncouPosition(int x, int y, string[,] navios)
        {
            int randNumber1;
            int randNumber2;
            int[,] pos = new int[3, 2];
            randNumber1 = rand.Next(0, 4);
            randNumber2 = rand.Next(0, 4);
            try
            {
                if (navios[x, y] == null 
                    && navios[x + X2direction[randNumber1], y] == null 
                    && navios[(x + X2direction[randNumber1]), (y + Y2direction[randNumber2])] == null
                    && navios[(x - X2direction[randNumber1]), (y + Y2direction[randNumber2])] == null)
                {
                    pos[0, 0] = x + X2direction[randNumber1];
                    pos[0, 1] = y;
                    pos[1, 0] = (x + X2direction[randNumber1]);
                    pos[1, 1] = (y + Y2direction[randNumber2]);
                    pos[2, 0] = x;
                    pos[2, 1] = (y + Y2direction[randNumber2]);
                    return new int[,] { { pos[0, 0] }, { pos[0, 1] }, { pos[1, 0] }, { pos[1, 1] }, { pos[2, 0] }, { pos[2, 1] } };
                }
            }
            catch
            {
                return new int[,] { { 0 }, { 0 }, { 0 }, { 0 }, { 0 }, { 0 } };
            }
            return new int[,] { { 0 }, { 0 }, { 0 }, { 0 }, { 0 }, { 0 } };
        }

        public int[,] CheckPortaAviaoPosition(int x, int y, string[,] navios)
        {
            int i;
            int[,] pos = new int[3,2];
            i = rand.Next(0, 4);
            try
            { 
                if (navios[x, y] == null
                    && navios[x + Xdirection[i], y + Ydirection[i]] == null
                    && navios[x + (Xdirection[i]*2), y + (Ydirection[i]*2)] == null
                    && navios[x + (Xdirection[i] * 3), y + (Ydirection[i] * 3)] == null)
                {
                    pos[0,0] = x + Xdirection[i];
                    pos[0,1] = y + Ydirection[i];
                    pos[1,0] = x + (Xdirection[i] * 2);
                    pos[1,1] = y + (Ydirection[i] * 2);
                    pos[2,0] = x + (Xdirection[i] * 3);
                    pos[2,1] = y + (Ydirection[i] * 3);
                    return new int[,] { { pos[0, 0] }, { pos[0, 1] }, { pos[1, 0] }, { pos[1, 1] }, { pos[2, 0] }, { pos[2, 1] } };
                }
            }
            catch
            {
                return new int[,] { { 0 }, { 0 }, { 0 }, { 0 }, { 0 }, { 0 } };
            }
            return new int[,] { { 0 }, { 0 }, { 0 }, { 0 }, { 0 }, { 0 } };
        }

    }
}
