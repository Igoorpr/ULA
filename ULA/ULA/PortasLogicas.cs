using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULA {
    class PortasLogicas
    {

        //Portas Lógicas com 2 entradas apenas (mais comum)
        public static bool OR(bool A, bool B) {
            return (A || B);
        }

        public static bool AND(bool A, bool B)
        {
            return (A & B);
        }

        public static bool NOT(bool A)
        {
            return (!A);
        }

        //Portas Lógicas com vetor para receber varias entradas (polimorfismo).
        public static bool OR(bool[] V)
        {
            bool saida = false;
            for (int i = 0; i < V.Length; i++) {
                if (V[i] == true) {
                    saida = true;
                }
            }
            return saida;
        }

        public static bool OR(bool A, bool B, bool C, bool D, bool E, bool F, bool G, bool H, bool I, bool J) {
            if (A == true || B == true || C == true || D == true || E == true || F == true || G == true || H == true || I == true || J == true) {
                return true;
            } else {
                return false;
            }
        }

        public static bool AND(bool A, bool B, bool C, bool D) {
            return (A & B & C & D);
        }

        public static bool AND(bool A, bool B, bool C, bool D, bool E, bool F, bool G, bool H) {
            return (A & B & C & D & E & F & G & H);
        }

        public static bool AND(bool A, bool B, bool C, bool D, bool E, bool F, bool G, bool H, bool I, bool J, bool K, bool L, bool M, bool N, bool O, bool P) {
            return (A & B & C & D & E & F & G & H & I & J & K & L & M & N & O & P);
        }

        public static bool AND(bool A, bool B, bool C, bool D, bool E, bool F, bool G, bool H, bool I, bool J, bool K, bool L, bool M, bool N, bool O, bool P, bool Q, bool R, bool S, bool T, bool U, bool V, bool W, bool X, bool Y, bool Z, bool AA, bool AB, bool AC, bool AD, bool AE, bool AF) {
            return (A & B & C & D & E & F & G & H & I & J & K & L & M & N & O & P & Q & R & S & T & U & V & W & X & Y & Z & AA & AB & AC & AD & AE & AF);
        }

        public static bool AND(bool[] V)
        {
            bool saida = true;
            for (int i = 0; i < V.Length; i++)
            {
                if (V[i] == false)
                {
                    saida = false;
                }
            }
            return saida;
        }

        public static bool AND(bool A, bool B, bool C) {
            if (A == true && B == true && C == true) {
                return true;
            } else {
                return false;
            }
        }
    }
}
