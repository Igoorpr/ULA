using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULA {
    class PortasLogicasDerivadas
    {

        //Portas Lógicas derivadas com 2 entradas
        public static bool NOR(bool A, bool B)
        {
            return !PortasLogicas.OR(A, B);
        }

        public static bool NAND(bool A, bool B)
        {
            return !PortasLogicas.AND(A, B);
        }

        public static bool XOR(bool A, bool B)
        {

            bool AND1, AND2;

            AND1 = PortasLogicas.AND(PortasLogicas.NOT(A), B);
            AND2 = PortasLogicas.AND(A, PortasLogicas.NOT(B));

            return (PortasLogicas.OR(AND1, AND2));
        }

        public static bool XNOR(bool A, bool B)
        {
            return !XOR(A, B);
        }

        //Portas Lógicas derivadas com vetor para receber varias entradas (polimorfismo).

        public static bool NOR(bool[] V)
        {
            return !PortasLogicas.OR(V);
        }

        public static bool NAND(bool[] V)
        {
            return !PortasLogicas.AND(V);
        }

        public static bool XOR(bool[] V)
        {
            bool aux, saida = false;

            aux = V[0];

            for (int i = 0; i < V.Length; i++) {
                if (V[i] != aux) {
                    saida = true;
                }
            }
            return saida;
        }

        public static bool XNOR(bool[] V)
        {
            return !XOR(V);
        }
    }
}
