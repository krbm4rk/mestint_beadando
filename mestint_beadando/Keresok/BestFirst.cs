﻿using mestint_beadando.AllapotTer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mestint_beadando.Keresok
{
    class BestFirst : Kereso
    {
        public BestFirst()
        {
            Kereses();
        }

        public override void Kereses()
        {
            Stack<Csomopont> nyiltCsucsok = new Stack<Csomopont>();
            List<Csomopont> zartCsucsok = new List<Csomopont>();

            nyiltCsucsok.Push(new Csomopont(new Allapot(), null));

            #region Meddig
            while (nyiltCsucsok.Count > 0 && !nyiltCsucsok.Peek().Allapot.celfeltetel())
            {
                Csomopont aktualisCsomopont = nyiltCsucsok.Pop();

                List<Csomopont> aktualisGyerekek = new List<Csomopont>();
                foreach (Operator op in Operatorok)
                {
                    if (op.Elofeltetel(aktualisCsomopont.Allapot))
                    {
                        Allapot ujAllpot = op.Atrakas(aktualisCsomopont.Allapot);
                        Csomopont ujCsomopont = new Csomopont(ujAllpot, aktualisCsomopont);

                        if (!nyiltCsucsok.Contains(ujCsomopont) && !zartCsucsok.Contains(ujCsomopont))
                        {
                            aktualisGyerekek.Add(ujCsomopont);

                        }
                    }
                } 
                #endregion

            #region Heurisztika alapján történő kiértékelés
                aktualisGyerekek.Sort(
            delegate (Csomopont cs1, Csomopont cs2)
            {
                if (cs1.Heurisztika > cs2.Heurisztika)
                {
                    return 1;
                }
                else if (cs1.Heurisztika < cs2.Heurisztika)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }); 
                #endregion

            #region Aktuális gyerekek eltárolása a nyílt csúcsokban
                foreach(Csomopont cs in aktualisGyerekek)
                {
                    nyiltCsucsok.Push(cs);
                }

                zartCsucsok.Add(aktualisCsomopont);
            } 
            #endregion

            #region Útvonal eltárolása
            if (nyiltCsucsok.Count > 0)
            {
                Csomopont celCsomopont = nyiltCsucsok.Peek();
                while (celCsomopont != null)
                {
                    this.Utvonal.Add(celCsomopont.Allapot);
                    celCsomopont = celCsomopont.Szulo;
                }
                this.Utvonal.Reverse();

            } 
            #endregion
        }
    }
}
