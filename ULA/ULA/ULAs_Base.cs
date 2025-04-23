using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULA {
    class ULA_1Bit_Base {

        FullAdder Adder = new FullAdder();
        Decoder4p16 decoder = new Decoder4p16();


        public bool Ativar(bool A, bool B, bool[] F, bool Vem1, out bool Vai1) {

            bool AND1, OR1, XOR1, NOT1, NOT2, soma, AND2, AND3, AND4, AND5, AND6, AND7, AND8, S;
            bool D0, D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15;

            AND1 = PortasLogicas.AND(A, B); //M0
            OR1 = PortasLogicas.OR(A, B); //M1
            XOR1 = PortasLogicasDerivadas.XOR(A, B); //M1a
            NOT1 = PortasLogicas.NOT(A); //M2a
            NOT2 = PortasLogicas.NOT(B); //M2

            soma = Adder.Ativar(A, B, Vem1, out Vai1);
            decoder.Ativar(F[3], F[2], F[1], F[0], out D0, out D1, out D2, out D3, out D4, out D5, out D6, out D7, out D8, out D9, out D10, out D11, out D12, out D13, out D14, out D15);

            AND2 = PortasLogicas.AND(AND1, D0);
            AND3 = PortasLogicas.AND(OR1, D1);
            AND4 = PortasLogicas.AND(XOR1, D2);
            AND5 = PortasLogicas.AND(NOT1, D3);
            AND6 = PortasLogicas.AND(NOT2, D4);
            AND7 = PortasLogicas.AND(soma, D5);
            AND8 = PortasLogicas.AND(PortasLogicas.NOT(XOR1), D7);

            S = PortasLogicas.OR(AND2, AND3, AND4, AND5, AND6, AND7, false, AND8, false, false); // Porta D6 "0110" usada na subtração
                                                                                                 // Porta D8 "1000" usada na multiplicação
                                                                                                 // Porta D9 "1001" usada na divisao
            return S;
        }
    }

    class ULA_1Bit {

        ULA_1Bit_Base ULA0 = new ULA_1Bit_Base();

        public bool Ativar(bool[] A, bool[] B, bool[] F, bool[] vResp) {

            bool Vai1, Vem1, V1 = false;
         
            vResp[0] = ULA0.Ativar(A[0], B[0], F, V1, out Vai1);
            Vem1 = Vai1;

            return Vai1;
        }
    }


    class ULA_8Bit {

        ULA_1Bit_Base ULA0 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA1 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA2 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA3 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA4 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA5 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA6 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA7 = new ULA_1Bit_Base();

        public bool Ativar(bool[] A, bool[] B, bool[] F, bool[] vResp) {

            bool Vai1, Vem1, V1 = false;

            vResp[7] = ULA7.Ativar(A[7], B[7], F, V1, out Vai1); //O primeiro CarryIn (Vem1), é sempre false
            Vem1 = Vai1;
            vResp[6] = ULA6.Ativar(A[6], B[6], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[5] = ULA5.Ativar(A[5], B[5], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[4] = ULA4.Ativar(A[4], B[4], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[3] = ULA3.Ativar(A[3], B[3], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[2] = ULA2.Ativar(A[2], B[2], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[1] = ULA1.Ativar(A[1], B[1], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[0] = ULA0.Ativar(A[0], B[0], F, Vem1, out Vai1);
            Vem1 = Vai1;

            return Vai1;

        }
    }

    class ULA_16Bit {

        ULA_1Bit_Base ULA0 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA1 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA2 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA3 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA4 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA5 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA6 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA7 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA8 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA9 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA10 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA11 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA12 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA13 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA14 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA15 = new ULA_1Bit_Base();

        public bool Ativar(bool[] A, bool[] B, bool[] F, bool[] vResp) {

            bool Vai1, Vem1, V1 = false;

            vResp[15] = ULA15.Ativar(A[15], B[15], F, V1, out Vai1); //O primeiro CarryIn (Vem1), é sempre false
            Vem1 = Vai1;
            vResp[14] = ULA14.Ativar(A[14], B[14], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[13] = ULA13.Ativar(A[13], B[13], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[12] = ULA12.Ativar(A[12], B[12], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[11] = ULA11.Ativar(A[11], B[11], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[10] = ULA10.Ativar(A[10], B[10], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[9] = ULA9.Ativar(A[9], B[9], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[8] = ULA8.Ativar(A[8], B[8], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[7] = ULA7.Ativar(A[7], B[7], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[6] = ULA6.Ativar(A[6], B[6], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[5] = ULA5.Ativar(A[5], B[5], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[4] = ULA4.Ativar(A[4], B[4], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[3] = ULA3.Ativar(A[3], B[3], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[2] = ULA2.Ativar(A[2], B[2], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[1] = ULA1.Ativar(A[1], B[1], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[0] = ULA0.Ativar(A[0], B[0], F, Vem1, out Vai1);
            Vem1 = Vai1;

            return Vai1;

        }
    }

    class ULA_32Bit {

        ULA_1Bit_Base ULA0 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA1 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA2 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA3 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA4 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA5 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA6 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA7 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA8 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA9 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA10 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA11 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA12 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA13 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA14 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA15 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA16 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA17 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA18 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA19 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA20 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA21 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA22 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA23 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA24 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA25 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA26 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA27 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA28 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA29 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA30 = new ULA_1Bit_Base();
        ULA_1Bit_Base ULA31 = new ULA_1Bit_Base();

        public bool Ativar(bool[] A, bool[] B, bool[] F, bool[] vResp) {

            bool Vai1, Vem1, V1 = false;

            vResp[31] = ULA31.Ativar(A[31], B[31], F, V1, out Vai1); //O primeiro CarryIn (Vem1), é sempre false
            Vem1 = Vai1;
            vResp[30] = ULA30.Ativar(A[30], B[30], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[29] = ULA29.Ativar(A[29], B[29], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[28] = ULA28.Ativar(A[28], B[28], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[27] = ULA27.Ativar(A[27], B[27], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[26] = ULA26.Ativar(A[26], B[26], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[25] = ULA25.Ativar(A[25], B[25], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[24] = ULA24.Ativar(A[24], B[24], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[23] = ULA23.Ativar(A[23], B[23], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[22] = ULA22.Ativar(A[22], B[22], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[21] = ULA21.Ativar(A[21], B[21], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[20] = ULA20.Ativar(A[20], B[20], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[19] = ULA19.Ativar(A[19], B[19], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[18] = ULA18.Ativar(A[18], B[18], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[17] = ULA17.Ativar(A[17], B[17], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[16] = ULA16.Ativar(A[16], B[16], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[15] = ULA15.Ativar(A[15], B[15], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[14] = ULA14.Ativar(A[14], B[14], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[13] = ULA13.Ativar(A[13], B[13], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[12] = ULA12.Ativar(A[12], B[12], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[11] = ULA11.Ativar(A[11], B[11], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[10] = ULA10.Ativar(A[10], B[10], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[9] = ULA9.Ativar(A[9], B[9], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[8] = ULA8.Ativar(A[8], B[8], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[7] = ULA7.Ativar(A[7], B[7], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[6] = ULA6.Ativar(A[6], B[6], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[5] = ULA5.Ativar(A[5], B[5], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[4] = ULA4.Ativar(A[4], B[4], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[3] = ULA3.Ativar(A[3], B[3], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[2] = ULA2.Ativar(A[2], B[2], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[1] = ULA1.Ativar(A[1], B[1], F, Vem1, out Vai1);
            Vem1 = Vai1;
            vResp[0] = ULA0.Ativar(A[0], B[0], F, Vem1, out Vai1);
            Vem1 = Vai1;

            return Vai1;

        }
    }

}
