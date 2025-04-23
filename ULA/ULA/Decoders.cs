using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULA {

    class Decoder2p4 {
        public void Ativar(bool A, bool B, out bool D0, out bool D1, out bool D2, out bool D3) {
            D0 = PortasLogicas.AND(PortasLogicas.NOT(A), PortasLogicas.NOT(B)); //00
            D1 = PortasLogicas.AND(PortasLogicas.NOT(A), B); //01
            D2 = PortasLogicas.AND(A, PortasLogicas.NOT(B)); //10
            D3 = PortasLogicas.AND(A, B); //11
        }
    }   
    
    class Decoder4p16{
        public void Ativar(bool A, bool B, bool C, bool D, out bool D0, out bool D1, out bool D2, out bool D3, out bool D4, out bool D5, out bool D6, out bool D7, out bool D8, out bool D9, out bool D10, out bool D11, out bool D12, out bool D13, out bool D14, out bool D15) {
            D0 = PortasLogicas.AND(PortasLogicas.NOT(A), PortasLogicas.NOT(B), PortasLogicas.NOT(C), PortasLogicas.NOT(D)); //0000
            D1 = PortasLogicas.AND(PortasLogicas.NOT(A), PortasLogicas.NOT(B), PortasLogicas.NOT(C), D); //0001            
            D2 = PortasLogicas.AND(PortasLogicas.NOT(A), PortasLogicas.NOT(B), C, PortasLogicas.NOT(D)); //0010
            D3 = PortasLogicas.AND(PortasLogicas.NOT(A), PortasLogicas.NOT(B), C, D); //0011
            D4 = PortasLogicas.AND(PortasLogicas.NOT(A), B, PortasLogicas.NOT(C), PortasLogicas.NOT(D)); //0100
            D5 = PortasLogicas.AND(PortasLogicas.NOT(A), B, PortasLogicas.NOT(C), D); //0101
            D6 = PortasLogicas.AND(PortasLogicas.NOT(A), B, C, PortasLogicas.NOT(D)); //0110
            D7 = PortasLogicas.AND(PortasLogicas.NOT(A), B, C, D); //0111
            D8 = PortasLogicas.AND(A, PortasLogicas.NOT(B), PortasLogicas.NOT(C), PortasLogicas.NOT(D)); //1000
            D9 = PortasLogicas.AND(A, PortasLogicas.NOT(B), PortasLogicas.NOT(C), D); //1001
            D10 = PortasLogicas.AND(A, PortasLogicas.NOT(B), C, PortasLogicas.NOT(D)); //1010
            D11 = PortasLogicas.AND(A, PortasLogicas.NOT(B), C, D); //1011
            D12 = PortasLogicas.AND(A, B, PortasLogicas.NOT(C), PortasLogicas.NOT(D)); //1100
            D13 = PortasLogicas.AND(A, B, PortasLogicas.NOT(C), D); //1101
            D14 = PortasLogicas.AND(A, B, C, PortasLogicas.NOT(D)); //1110
            D15 = PortasLogicas.AND(A, B, C, D); //1111
        }

    }
}
