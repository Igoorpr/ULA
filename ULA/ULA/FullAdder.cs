using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULA {
    class FullAdder
    {        

        public bool Ativar(bool A, bool B, bool Vem1, out bool Vai1) {
            bool soma, XOR1, XOR2, AND1, AND2, AND3, OR;                       

            XOR1 = PortasLogicasDerivadas.XOR(A, B);
            XOR2 = PortasLogicasDerivadas.XOR(XOR1, Vem1); // result soma
            soma = XOR2;

            AND1 = PortasLogicas.AND(B, Vem1);
            AND2 = PortasLogicas.AND(A, Vem1);
            AND3 = PortasLogicas.AND(A, B);

            bool[] vetorOR = new bool[] { AND1, AND2, AND3 }; // vetor pois possui mais de 2 entradas

            OR = PortasLogicas.OR(vetorOR);
            Vai1 = OR; //Vai1 (carry out)

            return soma;
        }

        
    }
}
