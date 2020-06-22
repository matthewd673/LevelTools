using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LevelTools
{
    public static class LevelData
    {

        public static bool established = false;

        public static int w = 1;
        public static int h = 1;
        public static int tileW = 1;
        public static int tileH = 1;

        public static int[,] map;

        static Random rng;

        public static void InitializeMap(int mapW, int mapH, int tW, int tH)
        {
            w = mapW;
            h = mapH;
            tileW = tW;
            tileH = tH;

            map = new int[w, h];

            rng = new Random();

            established = true;
        }

        public static void RefineNoise(int refineSteps)
        {
            if (!established)
                return;

            
        }

        public static bool PointIsSafe(int x, int y)
        {
            return (x >= 0 && x < w && y >= 0 && y < h);
        }

    }
}
