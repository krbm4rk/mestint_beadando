using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mestint_beadando.AllapotTer
{
    class Operator
    {
        private string szin;

        public string Szin
        {
            get { return szin; }
            set { szin = value; }
        }
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Operator(string nev, int x, int y)
        {
            Szin = nev;
            X = x;
            Y = y;
        }

        public Allapot Atrakas(Allapot allapot)
        {

            Allapot ujAllapot = new Allapot();

            int xSeged = 0;
            int ySeged = 0;
            for (int i = 0; i < allapot.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < allapot.matrix.GetLength(1); j++)
                {
                    if (szin == allapot.matrix[i, j])
                    {
                        xSeged = i;
                        ySeged = j;
                        ujAllapot.matrix[i, j] = allapot.matrix[x, y];

                    }
                }
            }
            for (int i = 0; i < allapot.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < allapot.matrix.GetLength(1); j++)
                {

                    if (xSeged == i && ySeged == j)
                    {

                    }
                    else if (x == i && y == j)
                    {

                        ujAllapot.matrix[i, j] = szin;
                    }
                    else
                    {
                        ujAllapot.matrix[i, j] = allapot.matrix[i, j];
                    }

                }
            }





            return ujAllapot;
        }

        public bool Elofeltetel(Allapot allapot)
        {

            #region Üres
            if (allapot.matrix[x, y] == "U")
            {
                return false;
            } 
            #endregion

            #region Foglalt
            if (allapot.matrix[x, y] == "Z2" || allapot.matrix[x, y] == "Z1" || allapot.matrix[x, y] == "Z3" ||
        allapot.matrix[x, y] == "P1" || allapot.matrix[x, y] == "P2" || allapot.matrix[x, y] == "P3")
            {
                return false;
            }

            int segedx = 0;
            int segedy = 0;
            #endregion

            #region Adott pozíció koordinátái
            for (int i = 0; i < allapot.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < allapot.matrix.GetLength(1); j++)
                {

                    if (szin == allapot.matrix[i, j])
                    {
                        segedx = i;
                        segedy = j;
                    }
                }
            } 
            #endregion

            if (segedx == 4 && segedy == 0 && szin == "Z1" ||segedx == 4 && segedy == 2 && szin == "Z3" || segedx == 4 && segedy == 0 && szin == "Z1" || segedx == 4 && segedy == 2 && szin == "Z2" || segedx == 4 && segedy == 0 && szin == "Z2" || segedx == 4 && segedy == 2 && szin == "Z3" || segedx == 4 && segedy == 0 && szin == "Z2" ||segedx == 4 && segedy == 2 && szin == "Z1" || segedx == 4 && segedy == 0 && szin == "Z3" ||segedx == 4 && segedy == 2 && szin == "Z1" || segedx == 4 && segedy == 0 && szin == "Z3" || segedx == 4 && segedy == 2 && szin == "Z2")
            {
                return false;
            }
            if (segedx == 0 && segedy == 0 && szin == "P1" ||segedx == 0 && segedy == 2 && szin == "P3" || segedx == 0 && segedy == 0 && szin == "P1" ||segedx == 0 && segedy == 2 && szin == "P2" || segedx == 0 && segedy == 0 && szin == "P2" || segedx == 0 && segedy == 2 && szin == "P3" || segedx == 0 && segedy == 0 && szin == "P2" || segedx == 0 && segedy == 2 && szin == "P1" || segedx == 0 && segedy == 0 && szin == "P3" || segedx == 0 && segedy == 2 && szin == "P1" || segedx == 0 && segedy == 0 && szin == "P3" || segedx == 0 && segedy == 2 && szin == "P2")
            {
                return false;
            }


            #region Egyet léphet
            if (segedx + 1 < x)
            {
                return false;
            }
            if (segedx - 1 > x)
            {
                return false;
            }
            if (segedy + 1 < y)
            {
                return false;
            }
            if (segedy - 1 > y)
            {
                return false;
            } 
            #endregion

            #region Átlós lépés
            if (segedx - 1 == x && segedy - 1 == y ||
        segedx - 1 == x && segedy + 1 == y ||
        segedx + 1 == x && segedy - 1 == y ||
        segedx + 1 == x && segedy + 1 == y)
            {
                return false;
            }
            return true; 
            #endregion
        }
    }
}
