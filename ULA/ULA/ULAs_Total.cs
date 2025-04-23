using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULA {

    class ULA1bit_Total {
        bool saida, andS;
        bool[] aux = new bool[1];
        bool[] um = { true };

        int numB_em_decimal = 0;

        ULA_1Bit ULA_1 = new ULA_1Bit();

        public bool Ativar(bool[] A, bool[] B, bool[] F, bool[] S) {

            if (!F[3] & F[2] & F[1] & !F[0]) { // SUBTRACAO de 1 bit

                // A-B = A - NOT(B) + 1					
                F[3] = false; F[2] = true; F[1] = false; F[0] = false; // F2F1F0 =  100 	NOT(B)
                saida = ULA_1.Ativar(A, B, F, S);
                F[3] = false; F[2] = true; F[1] = false; F[0] = true; // F2F1F0 =  101 	A + NOT(B)						
                saida = ULA_1.Ativar(A, S, F, S);
                F[3] = false; F[2] = true; F[1] = false; F[0] = true; // F2F1F0 =  101 	A + NOT(B) + 1						
                saida = ULA_1.Ativar(S, um, F, S);
                return saida;

            } else if (F[3] & !F[2] & !F[1] & !F[0]) { //Porta 1000 -> Multiplicação de 8 bits.                                                

                numB_em_decimal = ConversoesBases.ConverterBinarioDecimal_1bit(B);

                F[3] = false; F[2] = true; F[1] = false; F[0] = true; //Porta 0101 da SOMA

                for (int i = 0; i < numB_em_decimal; i++) {
                    saida = ULA_1.Ativar(A, S, F, S); // S = S + A
                }

                return saida;

            } else if (F[3] & !F[2] & !F[1] & F[0]) { //Porta 1001 -> Divisão de 1 bit.                                                
                int numA_em_decimal = ConversoesBases.ConverterBinarioDecimal_1bit(A);
                numB_em_decimal = ConversoesBases.ConverterBinarioDecimal_1bit(B);

                int r = numA_em_decimal / numB_em_decimal;

                ConversoesBases.ConverterDecimalBinario(S, r);
                return saida;
            } else {
                saida = ULA_1.Ativar(A, B, F, S);
                return saida;
            }
        }
    }

    class ULA8bit_Total {
        bool saida, andS;
        bool[] aux = new bool[8];
        bool[] um = { false, false, false, false, false, false, false, true };
        bool[] zero = { false, false, false, false, false, false, false, false };

        long numB_em_decimal = 0;     

        ULA_8Bit ULA_8 = new ULA_8Bit();        

        public bool Ativar(bool[] A, bool[] B, bool[] F, bool[] S) {

            if (F[3] & F[2] & F[1] & F[0]) { // COMPARACAO de 8 bits					
                saida = ULA_8.Ativar(A, B, F, S);
                andS = S[7] & S[6] & S[5] & S[4] & S[3] & S[2] & S[1] & S[0];
                andS = PortasLogicas.AND(S[7], S[6], S[5], S[4], S[3], S[2], S[1], S[0]);
                return andS;
            } else if (!F[3] & F[2] & F[1] & !F[0]) { // SUBTRACAO de 8 bits

                // A-B = A - NOT(B) + 1					
                F[3] = false; F[2] = true; F[1] = false; F[0] = false; // F2F1F0 =  100 	NOT(B)
                saida = ULA_8.Ativar(A, B, F, S);
                F[3] = false; F[2] = true; F[1] = false; F[0] = true; // F2F1F0 =  101 	A + NOT(B)						
                saida = ULA_8.Ativar(A, S, F, S);
                F[3] = false; F[2] = true; F[1] = false; F[0] = true; // F2F1F0 =  101 	A + NOT(B) + 1						
                saida = ULA_8.Ativar(S, um, F, S);
                return saida;

            }else if(F[3] & !F[2] & !F[1] & !F[0]) { //Porta 1000 -> Multiplicação de 8 bits.                                                

                numB_em_decimal = ConversoesBases.ConverterBinarioDecimal(B, 8);

                F[3] = false; F[2] = true; F[1] = false; F[0] = true; //Porta 0101 da SOMA

                for (int i = 0; i < numB_em_decimal; i++) {
                    saida = ULA_8.Ativar(A, S, F, S); // S = S + A
                }                

                return saida;

            } else if (F[3] & !F[2] & !F[1] & F[0]) { //Porta 1001 -> Divisão de 8 bits.                                                
                long numA_em_decimal = ConversoesBases.ConverterBinarioDecimal(A, 8);                
                numB_em_decimal = ConversoesBases.ConverterBinarioDecimal(B, 8);

                long r = numA_em_decimal / numB_em_decimal;

                ConversoesBases.ConverterDecimalBinario(S, r);
                return saida;
            } else {
                saida = ULA_8.Ativar(A, B, F, S);
                return saida;
            }
        }
    }

    class ULA16bit_Total {
        bool saida, andS;
        bool[] aux = new bool[16];
        bool[] um = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true };

        long numB_em_decimal = 0;

        ULA_16Bit ULA_16 = new ULA_16Bit();

        public bool Ativar(bool[] A, bool[] B, bool[] F, bool[] S) {

            if (F[3] & F[2] & F[1] & F[0]) { // COMPARACAO de 16 bits					
                saida = ULA_16.Ativar(A, B, F, S);
                andS = S[15] & S[14] & S[13] & S[12] & S[11] & S[10] & S[9] & S[8] & S[7] & S[6] & S[5] & S[4] & S[3] & S[2] & S[1] & S[0];
                andS = PortasLogicas.AND(S[15], S[14], S[13], S[12], S[11], S[10], S[9], S[8], S[7], S[6], S[5], S[4], S[3], S[2], S[1], S[0]);
                return andS;
            } else if (!F[3] & F[2] & F[1] & !F[0]) { // SUBTRACAO de 8 bits

                // A-B = A - NOT(B) + 1					
                F[3] = false; F[2] = true; F[1] = false; F[0] = false; // F2F1F0 =  100 	NOT(B)
                saida = ULA_16.Ativar(A, B, F, S);
                F[3] = false; F[2] = true; F[1] = false; F[0] = true; // F2F1F0 =  101 	A + NOT(B)						
                saida = ULA_16.Ativar(A, S, F, S);
                F[3] = false; F[2] = true; F[1] = false; F[0] = true; // F2F1F0 =  101 	A + NOT(B) + 1						
                saida = ULA_16.Ativar(S, um, F, S);
                return saida;

            } else if (F[3] & !F[2] & !F[1] & !F[0]) { //Porta 1000 -> Multiplicação de 8 bits.                                                

                numB_em_decimal = ConversoesBases.ConverterBinarioDecimal(B, 16);

                F[3] = false; F[2] = true; F[1] = false; F[0] = true; //Porta 0101 da SOMA

                for (int i = 0; i < numB_em_decimal; i++) {
                    saida = ULA_16.Ativar(A, S, F, S); // S = S + A
                }

                return saida;

            } else if (F[3] & !F[2] & !F[1] & F[0]) { //Porta 1001 -> Divisão de 16 bits.                                                
                long numA_em_decimal = ConversoesBases.ConverterBinarioDecimal(A, 16);
                numB_em_decimal = ConversoesBases.ConverterBinarioDecimal(B, 16);

                long r = numA_em_decimal / numB_em_decimal;

                ConversoesBases.ConverterDecimalBinario(S, r);
                return saida;
            } else {
                saida = ULA_16.Ativar(A, B, F, S);
                return saida;
            }
        }
    }

    class ULA32bit_Total {
        bool saida, andS;
        bool[] aux = new bool[32];
        bool[] um = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true };

        long numB_em_decimal = 0;

        ULA_32Bit ULA_32 = new ULA_32Bit();

        public bool Ativar(bool[] A, bool[] B, bool[] F, bool[] S) {

            if (F[3] & F[2] & F[1] & F[0]) { // COMPARACAO de 16 bits					
                saida = ULA_32.Ativar(A, B, F, S);
                andS = S[31] & S[30] & S[29] & S[28] & S[27] & S[26] & S[25] & S[24] & S[23] & S[22] & S[21] & S[20] & S[19] & S[18] & S[17] & S[16] & S[15] & S[14] & S[13] & S[12] & S[11] & S[10] & S[9] & S[8] & S[7] & S[6] & S[5] & S[4] & S[3] & S[2] & S[1] & S[0];
                andS = PortasLogicas.AND(S[31], S[30], S[29], S[28], S[27], S[26], S[25], S[24], S[23], S[22], S[21], S[20], S[19], S[18], S[17], S[16], S[15], S[14], S[13], S[12], S[11], S[10], S[9], S[8], S[7], S[6], S[5], S[4], S[3], S[2], S[1], S[0]);
                return andS;
            } else if (!F[3] & F[2] & F[1] & !F[0]) { // SUBTRACAO de 8 bits

                // A-B = A - NOT(B) + 1					
                F[3] = false; F[2] = true; F[1] = false; F[0] = false; // F2F1F0 =  100 	NOT(B)
                saida = ULA_32.Ativar(A, B, F, S);
                F[3] = false; F[2] = true; F[1] = false; F[0] = true; // F2F1F0 =  101 	A + NOT(B)						
                saida = ULA_32.Ativar(A, S, F, S);
                F[3] = false; F[2] = true; F[1] = false; F[0] = true; // F2F1F0 =  101 	A + NOT(B) + 1						
                saida = ULA_32.Ativar(S, um, F, S);
                return saida;

            } else if (F[3] & !F[2] & !F[1] & !F[0]) { //Porta 1000 -> Multiplicação de 8 bits.                                                

                numB_em_decimal = ConversoesBases.ConverterBinarioDecimal(B, 32);

                F[3] = false; F[2] = true; F[1] = false; F[0] = true; //Porta 0101 da SOMA

                for (int i = 0; i < numB_em_decimal; i++) {
                    saida = ULA_32.Ativar(A, S, F, S); // S = S + A
                }

                return saida;

            } else if (F[3] & !F[2] & !F[1] & F[0]) { //Porta 1001 -> Divisão de 32 bits.                                                
                long numA_em_decimal = ConversoesBases.ConverterBinarioDecimal(A, 32);
                numB_em_decimal = ConversoesBases.ConverterBinarioDecimal(B, 32);

                long r = numA_em_decimal / numB_em_decimal;

                ConversoesBases.ConverterDecimalBinario(S, r);
                return saida;
            } else {
                saida = ULA_32.Ativar(A, B, F, S);
                return saida;
            }
        }
    }
}
