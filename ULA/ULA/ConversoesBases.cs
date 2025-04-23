using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULA {
    class ConversoesBases {

        public static void ConverterDecimalBinario(bool[] vResposta, long num) {
            long x = num;

            for (int i = 0; i < vResposta.Length; i++) {
                if ((x % 2) == 1) {
                    vResposta[(vResposta.Length - 1) - i] = true;
                } else {
                    vResposta[(vResposta.Length - 1) - i] = false;
                }
                x = x / 2;
            }
        }        

        public static void Converter_Bool_Binario_byte(byte[] vetor, bool[] vetorB, out long y, int tam) {
            byte i;
            long x;
            for (i = 0; i < tam; i++) {

                if (vetorB[i]) {
                    vetor[i] = 1;

                } else {
                    vetor[i] = 0;
                }
            }                                               
            x = 0; 
            for (i = 0; i < tam; i++) {
                x = x + vetor[i] * (long)Math.Pow(2, (tam-1) - (i));
            }      
            y = x;
        }

        public static void Converter_Bool_Binario_byte_1bit(byte[] vetor, bool[] vetorB, out long y) {
            long x;            
            if (vetorB[0]) {
                vetor[0] = 1;

            } else {
               vetor[0] = 0;
            }            
            x = 0;                        
            x = x + vetor[0] * 1;            
            y = x;
        }

        public static int ConverterBinarioDecimal(bool[] valor, int bitsULA) {            
            byte[] vByte = new byte[bitsULA];
            int tam = valor.Length;
            int x = 0;

            for (int i = 0; i < tam; i++) {

                if (valor[i]) {
                    vByte[i] = 1;

                } else {
                    vByte[i] = 0;
                }
            }           
            
            x = x - vByte[0] * (int)Math.Pow(2, (bitsULA - 1));
            for (int i = 1; i < tam; i++) {
                x = x + vByte[i] * (int)Math.Pow(2, (bitsULA - 1) - i);
            }
            return x;
        }

        public static int ConverterBinarioDecimal_1bit(bool[] valor) {
            byte[] vByte = new byte[1];
            int tam = valor.Length;
            int x = 0;            

            if (valor[0]) {
                vByte[0] = 1;

            } else {
                vByte[0] = 0;
            }               
            
            x = x + vByte[0] * 1;
            
            return x;
        }
        
    }
}
