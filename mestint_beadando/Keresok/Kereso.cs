﻿using mestint_beadando.AllapotTer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mestint_beadando.Keresok
{
    abstract class Kereso
    {
        private List<Operator> operatorok = new List<Operator>();
        private List<Allapot> utvonal = new List<Allapot>();

        internal List<Allapot> Utvonal { get => utvonal; set => utvonal = value; }
        internal List<Operator> Operatorok { get => operatorok; set => operatorok = value; }

        public Kereso()
        {
            operatorBetoltes();
        }

        private void operatorBetoltes()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    operatorok.Add(new Operator("Z2", i, j));
                    operatorok.Add(new Operator("P2", i, j));
                    operatorok.Add(new Operator("Z1", i, j));
                    operatorok.Add(new Operator("P1", i, j));
                    operatorok.Add(new Operator("Z3", i, j));
                    operatorok.Add(new Operator("P3", i, j));
                }
            }
        }

        public abstract void Kereses();

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < Utvonal.Count; i++)
            {
                builder.Append(Utvonal[i]);
                builder.Append("\n");
            }
            builder.Append(Utvonal.Count);
            return builder.ToString();
        }
    }
}
