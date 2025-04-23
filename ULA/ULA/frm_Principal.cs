using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ULA {
    public partial class frm_Principal : Form {
        public frm_Principal() {
            InitializeComponent();
        }

        private void btn_Converter_Click(object sender, EventArgs e) {

            try {
                int quantBITS = 0;
                int opcaoULA = cbxOP_ULA.SelectedIndex;

                if (long.Parse(txtNumA.Text) < 0 || long.Parse(txtNumB.Text) < 0) {
                    MessageBox.Show("Não são permitidos números negativos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    switch (opcaoULA) {
                        case 0: // ULA 1 bit
                            if (long.Parse(txtNumA.Text) > 1 || long.Parse(txtNumB.Text) > 1) {
                                MessageBox.Show("A ULA de 1 bit representa até o numero 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                Converter_1Bit(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text));
                            }
                            break;
                        case 1: //ULA 8 bits
                            if (long.Parse(txtNumA.Text) > 255 || long.Parse(txtNumB.Text) > 255) {
                                MessageBox.Show("A ULA de 8 bits representa até o numero 255.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                quantBITS = 8;
                                Converter(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text), quantBITS);
                            }                            
                            break;
                        case 2: //ULA 16 bits
                            if (long.Parse(txtNumA.Text) > 65535 || long.Parse(txtNumB.Text) > 65535) {
                                MessageBox.Show("A ULA de 16 bits representa até o numero 65535.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                quantBITS = 16;
                                Converter(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text), quantBITS);
                            }                            
                            break;
                        case 3: //ULA 32 bits
                            if (long.Parse(txtNumA.Text) > 4294967295 || long.Parse(txtNumB.Text) > 4294967295) {
                                MessageBox.Show("A ULA de 32 bits representa até o numero 4.294.967.295.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                quantBITS = 32;
                                Converter(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text), quantBITS);
                            }                            
                            break;
                        default:
                            MessageBox.Show("Selecione uma ULA (1, 8, 16 ou 32 bits)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            } catch (FormatException Ex) {
                MessageBox.Show("Digite os numeros corretamente!\n" + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception Ex) {
                MessageBox.Show("Um erro inesperado ocorreu!\n" + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Converter_1Bit(long numeroA, long numeroB) {
            long num = 0;
            bool[] convertidoA = new bool[1];
            bool[] convertidoB = new bool[1];

            byte[] vetorByteA = new byte[1];
            byte[] vetorByteB = new byte[1];

            string A = "", B = "";

            ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
            ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

            ConversoesBases.Converter_Bool_Binario_byte(vetorByteA, convertidoA, out num, 1);
            ConversoesBases.Converter_Bool_Binario_byte(vetorByteB, convertidoB, out num, 1);

            A += vetorByteA[0];
            B += vetorByteB[0];

            txt_Binario_A.Text = A;
            txt_Binario_B.Text = B;
            txt_Decimal_A.Text = numeroA.ToString();
            txt_Decimal_B.Text = numeroB.ToString();
            txt_Octal_A.Text = Convert.ToString(numeroA, 8);
            txt_Octal_B.Text = Convert.ToString(numeroB, 8);
            txt_Hexa_A.Text = (Convert.ToString(numeroA, 16).ToUpper());
            txt_Hexa_B.Text = (Convert.ToString(numeroB, 16).ToUpper());
        }

        public void Converter(long numeroA, long numeroB, int bitsULA) {
            long num = 0;
            bool[] convertidoA = new bool[bitsULA];
            bool[] convertidoB = new bool[bitsULA];
            byte[] vetorByteA = new byte[bitsULA];
            byte[] vetorByteB = new byte[bitsULA];

            string A = "", B = "";

            ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
            ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

            ConversoesBases.Converter_Bool_Binario_byte(vetorByteA, convertidoA, out num, bitsULA);
            ConversoesBases.Converter_Bool_Binario_byte(vetorByteB, convertidoB, out num, bitsULA);

            for (int i = 0; i < bitsULA; i++) {
                A += vetorByteA[i];
                B += vetorByteB[i];
            }

            txt_Binario_A.Text = A;
            txt_Binario_B.Text = B;
            txt_Decimal_A.Text = numeroA.ToString();
            txt_Decimal_B.Text = numeroB.ToString();
            txt_Octal_A.Text = Convert.ToString(numeroA, 8);
            txt_Octal_B.Text = Convert.ToString(numeroB, 8);
            txt_Hexa_A.Text = (Convert.ToString(numeroA, 16).ToUpper());
            txt_Hexa_B.Text = (Convert.ToString(numeroB, 16).ToUpper());
        }

        private void btnSoma_Click(object sender, EventArgs e) {

            try {
                long numeroA = long.Parse(txtNumA.Text);
                long numeroB = long.Parse(txtNumB.Text);
                string resposta = "";
                bool S;
                long s = 0;

                if (numeroA < 0 || numeroB < 0) {
                    MessageBox.Show("Não são permitidos números negativos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    bool[] F = new bool[4];
                    F[3] = false; F[2] = true; F[1] = false; F[0] = true; //Porta da soma Decoder - 0101  

                    int quantBITS = 0;
                    int opcaoULA = cbxOP_ULA.SelectedIndex;

                    if (opcaoULA == 0) quantBITS = 1;
                    else if (opcaoULA == 1) quantBITS = 8;
                    else if (opcaoULA == 2) quantBITS = 16;
                    else if (opcaoULA == 3) quantBITS = 32;
                    else quantBITS = 0;


                    bool[] convertidoA = new bool[quantBITS];
                    bool[] convertidoB = new bool[quantBITS];
                    bool[] vRespBool = new bool[quantBITS];
                    byte[] vBitResp = new byte[quantBITS];

                    switch (opcaoULA) {
                        case 0:
                            if (long.Parse(txtNumA.Text) > 1 || long.Parse(txtNumB.Text) > 1) {
                                MessageBox.Show("A ULA de 1 bit é capaz de representar numeros até 1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                Converter_1Bit(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text));

                                ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
                                ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

                                ULA1bit_Total ULA_1Bit = new ULA1bit_Total();

                                S = ULA_1Bit.Ativar(convertidoA, convertidoB, F, vRespBool);

                                if (S == true) {
                                    MessageBox.Show("A ULA de 1 bit é capaz de representar numeros até 1.", "Erro de Overflow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                } else {
                                    ConversoesBases.Converter_Bool_Binario_byte_1bit(vBitResp, vRespBool, out s);

                                    resposta += vBitResp[0];
                                }
                            }
                            break;

                        case 1:
                            if (long.Parse(txtNumA.Text) > 255 || long.Parse(txtNumB.Text) > 255) {
                                MessageBox.Show("A ULA de 8 bits é capaz de representar numeros até 255!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                Converter(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text), quantBITS);

                                ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
                                ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

                                ULA8bit_Total ULA_8Bit = new ULA8bit_Total();

                                S = ULA_8Bit.Ativar(convertidoA, convertidoB, F, vRespBool);

                                if (S == true) {
                                    MessageBox.Show("A ULA de 8 bits é capaz de representar numeros até 255.", "Erro de Overflow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                } else {
                                    ConversoesBases.Converter_Bool_Binario_byte(vBitResp, vRespBool, out s, quantBITS);

                                    for (int i = 0; i < quantBITS; i++) {
                                        resposta += vBitResp[i];
                                    }
                                }
                            }
                            break;

                        case 2:
                            if (long.Parse(txtNumA.Text) > 65535 || long.Parse(txtNumB.Text) > 65535) {
                                MessageBox.Show("A ULA de 16 bits é capaz de representar numeros até 65535!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                Converter(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text), quantBITS);

                                ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
                                ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

                                ULA16bit_Total ULA_16Bit = new ULA16bit_Total();

                                S = ULA_16Bit.Ativar(convertidoA, convertidoB, F, vRespBool);
                                if (S == true) {
                                    MessageBox.Show("A ULA de 16 bits é capaz de representar numeros até 65535.", "Erro de Overflow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                } else {
                                    ConversoesBases.Converter_Bool_Binario_byte(vBitResp, vRespBool, out s, quantBITS);

                                    for (int i = 0; i < quantBITS; i++) {
                                        resposta += vBitResp[i];
                                    }
                                }
                            }
                            break;

                        case 3:
                            if (long.Parse(txtNumA.Text) > 4294967295 || long.Parse(txtNumB.Text) > 4294967295) {
                                MessageBox.Show("A ULA de 32 bits é capaz de representar numeros até 4.294.967.295!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                Converter(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text), quantBITS);

                                ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
                                ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

                                ULA32bit_Total ULA_32Bit = new ULA32bit_Total();

                                S = ULA_32Bit.Ativar(convertidoA, convertidoB, F, vRespBool);
                                if (S == true) {
                                    MessageBox.Show("A ULA de 32 bits é capaz de representar numeros até 4.294.967.295.", "Erro de Overflow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                } else {
                                    ConversoesBases.Converter_Bool_Binario_byte(vBitResp, vRespBool, out s, quantBITS);

                                    for (int i = 0; i < quantBITS; i++) {
                                        resposta += vBitResp[i];
                                    }
                                }
                            }
                            break;
                    }

                }
                txt_Resp_Binario.Text = resposta;
                txt_Resp_Decimal.Text = s.ToString();
                txt_Resp_Octal.Text = (Convert.ToString(s, 8));
                txt_Resp_Hexa.Text = (Convert.ToString(s, 16).ToUpper());

            } catch (FormatException Ex) {
                MessageBox.Show("Digite os numeros corretamente!\n" + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception Ex) {
                MessageBox.Show("Um erro inesperado ocorreu!\n" + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSub_Click(object sender, EventArgs e) {

            try {
                long numeroA = long.Parse(txtNumA.Text);
                long numeroB = long.Parse(txtNumB.Text);
                string resposta = "";
                bool S;
                long s = 0;

                if (numeroA < 0 || numeroB < 0) {
                    MessageBox.Show("Não são permitidos números negativos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    bool[] F = new bool[4];
                    F[3] = false; F[2] = true; F[1] = true; F[0] = false; //Porta da subtração Decoder - 0110  

                    int quantBITS = 0;
                    int opcaoULA = cbxOP_ULA.SelectedIndex;

                    if (opcaoULA == 0) quantBITS = 1;
                    else if (opcaoULA == 1) quantBITS = 8;
                    else if (opcaoULA == 2) quantBITS = 16;
                    else if (opcaoULA == 3) quantBITS = 32;
                    else quantBITS = 0;


                    bool[] convertidoA = new bool[quantBITS];
                    bool[] convertidoB = new bool[quantBITS];
                    bool[] vRespBool = new bool[quantBITS];
                    byte[] vBitResp = new byte[quantBITS];

                    switch (opcaoULA) {
                        case 0:
                            if (long.Parse(txtNumA.Text) > 1 || long.Parse(txtNumB.Text) > 1) {
                                MessageBox.Show("A ULA de 1 bit é capaz de representar numeros até 1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                Converter_1Bit(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text));

                                ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
                                ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

                                ULA1bit_Total ULA_1Bit = new ULA1bit_Total();

                                S = ULA_1Bit.Ativar(convertidoA, convertidoB, F, vRespBool);
                                ConversoesBases.Converter_Bool_Binario_byte_1bit(vBitResp, vRespBool, out s);

                                resposta += vBitResp[0];
                            }
                            break;

                        case 1:
                            if (long.Parse(txtNumA.Text) > 255 || long.Parse(txtNumB.Text) > 255 | long.Parse(txtNumA.Text) - long.Parse(txtNumB.Text) < 0) {
                                MessageBox.Show("A ULA de 8 bits é capaz de representar numeros até 255!\n\nPortanto nenhum numero acima de 255 ou que a subtração resulte em algo menor do que 0 será suportado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                Converter(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text), quantBITS);

                                ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
                                ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

                                ULA8bit_Total ULA_8Bit = new ULA8bit_Total();

                                S = ULA_8Bit.Ativar(convertidoA, convertidoB, F, vRespBool);

                                ConversoesBases.Converter_Bool_Binario_byte(vBitResp, vRespBool, out s, quantBITS);

                                for (int i = 0; i < quantBITS; i++) {
                                    resposta += vBitResp[i];
                                }
                            }
                            break;

                        case 2:
                            if (long.Parse(txtNumA.Text) > 65535 || long.Parse(txtNumB.Text) > 65535 || long.Parse(txtNumA.Text) - long.Parse(txtNumB.Text) < 0) {
                                MessageBox.Show("A ULA de 16 bits é capaz de representar numeros até 65535!\n\nPortanto nenhum numero acima de 65535 ou que a subtração resulte em algo menor do que 0 será suportado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                Converter(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text), quantBITS);

                                ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
                                ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

                                ULA16bit_Total ULA_16Bit = new ULA16bit_Total();

                                S = ULA_16Bit.Ativar(convertidoA, convertidoB, F, vRespBool);
                                ConversoesBases.Converter_Bool_Binario_byte(vBitResp, vRespBool, out s, quantBITS);

                                for (int i = 0; i < quantBITS; i++) {
                                    resposta += vBitResp[i];
                                }
                            }
                            break;

                        case 3:
                            if (long.Parse(txtNumA.Text) > 4294967295 || long.Parse(txtNumB.Text) > 4294967295 || long.Parse(txtNumA.Text) - long.Parse(txtNumB.Text) < 0) {
                                MessageBox.Show("A ULA de 32 bits é capaz de representar numeros até 4294967295!\n\nPortanto nenhum numero acima de 4294967295 ou que a subtração resulte em algo menor do que 0 será suportado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                Converter(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text), quantBITS);

                                ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
                                ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

                                ULA32bit_Total ULA_32Bit = new ULA32bit_Total();

                                S = ULA_32Bit.Ativar(convertidoA, convertidoB, F, vRespBool);
                                ConversoesBases.Converter_Bool_Binario_byte(vBitResp, vRespBool, out s, quantBITS);

                                for (int i = 0; i < quantBITS; i++) {
                                    resposta += vBitResp[i];
                                }
                            }
                            break;
                    }
                }

                txt_Resp_Binario.Text = resposta;
                txt_Resp_Decimal.Text = s.ToString();
                txt_Resp_Octal.Text = (Convert.ToString(s, 8));
                txt_Resp_Hexa.Text = (Convert.ToString(s, 16).ToUpper());

            } catch (FormatException Ex) {
                MessageBox.Show("Digite os numeros corretamente!\n" + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception Ex) {
                MessageBox.Show("Um erro inesperado ocorreu!\n" + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e) {

            try {
                long numeroA = long.Parse(txtNumA.Text);
                long numeroB = long.Parse(txtNumB.Text);
                string resposta = "";
                bool S;
                long s = 0;

                if (numeroA < 0 || numeroB < 0) {
                    MessageBox.Show("Não são permitidos números negativos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    bool[] F = new bool[4];
                    F[3] = true; F[2] = false; F[1] = false; F[0] = false; //Porta da multiplicação Decoder - 1000  

                    int quantBITS = 0;
                    int opcaoULA = cbxOP_ULA.SelectedIndex;

                    if (opcaoULA == 0) quantBITS = 1;
                    else if (opcaoULA == 1) quantBITS = 8;
                    else if (opcaoULA == 2) quantBITS = 16;
                    else if (opcaoULA == 3) quantBITS = 32;
                    else quantBITS = 0;


                    bool[] convertidoA = new bool[quantBITS];
                    bool[] convertidoB = new bool[quantBITS];
                    bool[] vRespBool = new bool[quantBITS];
                    byte[] vBitResp = new byte[quantBITS];

                    switch (opcaoULA) {
                        case 0:
                            if (long.Parse(txtNumA.Text) > 1 || long.Parse(txtNumB.Text) > 1) {
                                MessageBox.Show("A ULA de 1 bit é capaz de representar numeros até 1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                Converter_1Bit(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text));

                                ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
                                ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

                                ULA1bit_Total ULA_1Bit = new ULA1bit_Total();

                                S = ULA_1Bit.Ativar(convertidoA, convertidoB, F, vRespBool);
                                ConversoesBases.Converter_Bool_Binario_byte_1bit(vBitResp, vRespBool, out s);

                                resposta += vBitResp[0];
                            }
                            break;

                        case 1:
                            if (long.Parse(txtNumA.Text) > 255 || long.Parse(txtNumB.Text) > 255) {
                                MessageBox.Show("A ULA de 8 bits é capaz de representar numeros até 255!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                Converter(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text), quantBITS);

                                ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
                                ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

                                ULA8bit_Total ULA_8Bit = new ULA8bit_Total();

                                S = ULA_8Bit.Ativar(convertidoA, convertidoB, F, vRespBool);

                                if (S == true || long.Parse(txtNumA.Text) * long.Parse(txtNumB.Text) > 255) {
                                    MessageBox.Show("A ULA de 8 bits é capaz de representar numeros até 255.", "Erro de Overflow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                } else {
                                    ConversoesBases.Converter_Bool_Binario_byte(vBitResp, vRespBool, out s, quantBITS);

                                    for (int i = 0; i < quantBITS; i++) {
                                        resposta += vBitResp[i];
                                    }
                                }
                            }
                            break;

                        case 2:
                            if (long.Parse(txtNumA.Text) > 65535 || long.Parse(txtNumB.Text) > 65535) {
                                MessageBox.Show("A ULA de 16 bits é capaz de representar numeros até 65535!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                Converter(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text), quantBITS);

                                ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
                                ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

                                ULA16bit_Total ULA_16Bit = new ULA16bit_Total();

                                S = ULA_16Bit.Ativar(convertidoA, convertidoB, F, vRespBool);
                                if (S == true) {
                                    MessageBox.Show("A ULA de 16 bits é capaz de representar numeros até 65535.", "Erro de Overflow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                } else {
                                    ConversoesBases.Converter_Bool_Binario_byte(vBitResp, vRespBool, out s, quantBITS);

                                    for (int i = 0; i < quantBITS; i++) {
                                        resposta += vBitResp[i];
                                    }
                                }
                            }
                            break;

                        case 3:
                            if (long.Parse(txtNumA.Text) > 4294967295 || long.Parse(txtNumB.Text) > 4294967295) {
                                MessageBox.Show("A ULA de 32 bits é capaz de representar numeros até 4.294.967.295!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                Converter(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text), quantBITS);

                                ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
                                ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

                                ULA32bit_Total ULA_32Bit = new ULA32bit_Total();

                                S = ULA_32Bit.Ativar(convertidoA, convertidoB, F, vRespBool);
                                if (S == true || long.Parse(txtNumA.Text) * long.Parse(txtNumB.Text) > 4294967295) {
                                    MessageBox.Show("A ULA de 32 bits é capaz de representar numeros até 4.294.967.295.", "Erro de Overflow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                } else {
                                    ConversoesBases.Converter_Bool_Binario_byte(vBitResp, vRespBool, out s, quantBITS);

                                    for (int i = 0; i < quantBITS; i++) {
                                        resposta += vBitResp[i];
                                    }
                                }
                            }
                            break;
                    }
                }

                txt_Resp_Binario.Text = resposta;
                txt_Resp_Decimal.Text = s.ToString();
                txt_Resp_Octal.Text = (Convert.ToString(s, 8));
                txt_Resp_Hexa.Text = (Convert.ToString(s, 16).ToUpper());

            } catch (FormatException Ex) {
                MessageBox.Show("Digite os numeros corretamente!\n" + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception Ex) {
                MessageBox.Show("Um erro inesperado ocorreu!\n" + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e) {
            try {
                long numeroA = long.Parse(txtNumA.Text);
                long numeroB = long.Parse(txtNumB.Text);
                string resposta = "";
                bool S;
                long s = 0;

                if (numeroA < 0 || numeroB < 0) {
                    MessageBox.Show("Não são permitidos números negativos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    bool[] F = new bool[4];
                    F[3] = true; F[2] = false; F[1] = false; F[0] = true; //Porta da divisão Decoder - 1001

                    int quantBITS = 0;
                    int opcaoULA = cbxOP_ULA.SelectedIndex;

                    if (opcaoULA == 0) quantBITS = 1;
                    else if (opcaoULA == 1) quantBITS = 8;
                    else if (opcaoULA == 2) quantBITS = 16;
                    else if (opcaoULA == 3) quantBITS = 32;
                    else quantBITS = 0;


                    bool[] convertidoA = new bool[quantBITS];
                    bool[] convertidoB = new bool[quantBITS];
                    bool[] vRespBool = new bool[quantBITS];
                    byte[] vBitResp = new byte[quantBITS];

                    switch (opcaoULA) {
                        case 0:
                            if (long.Parse(txtNumA.Text) > 1 || long.Parse(txtNumB.Text) > 1) {
                                MessageBox.Show("A ULA de 1 bit é capaz de representar numeros até 1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                Converter_1Bit(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text));

                                ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
                                ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

                                ULA1bit_Total ULA_1Bit = new ULA1bit_Total();

                                S = ULA_1Bit.Ativar(convertidoA, convertidoB, F, vRespBool);
                                ConversoesBases.Converter_Bool_Binario_byte_1bit(vBitResp, vRespBool, out s);

                                resposta += vBitResp[0];
                            }
                            break;

                        case 1:
                            if (long.Parse(txtNumA.Text) > 255 || long.Parse(txtNumB.Text) > 255 || long.Parse(txtNumA.Text) - long.Parse(txtNumB.Text) < 0) {
                                MessageBox.Show("A ULA de 8 bits é capaz de representar numeros até 255!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                Converter(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text), quantBITS);

                                ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
                                ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

                                ULA8bit_Total ULA_8Bit = new ULA8bit_Total();

                                S = ULA_8Bit.Ativar(convertidoA, convertidoB, F, vRespBool);

                                ConversoesBases.Converter_Bool_Binario_byte(vBitResp, vRespBool, out s, quantBITS);

                                for (int i = 0; i < quantBITS; i++) {
                                    resposta += vBitResp[i];
                                }
                            }
                            break;

                        case 2:
                            if (long.Parse(txtNumA.Text) > 65535 || long.Parse(txtNumB.Text) > 65535 || long.Parse(txtNumA.Text) - long.Parse(txtNumB.Text) < 0) {
                                MessageBox.Show("A ULA de 16 bits é capaz de representar numeros até 65535!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                Converter(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text), quantBITS);

                                ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
                                ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

                                ULA16bit_Total ULA_16Bit = new ULA16bit_Total();

                                S = ULA_16Bit.Ativar(convertidoA, convertidoB, F, vRespBool);
                                ConversoesBases.Converter_Bool_Binario_byte(vBitResp, vRespBool, out s, quantBITS);

                                for (int i = 0; i < quantBITS; i++) {
                                    resposta += vBitResp[i];
                                }
                            }
                            break;

                        case 3:
                            if (long.Parse(txtNumA.Text) > 4294967295 || long.Parse(txtNumB.Text) > 4294967295 || long.Parse(txtNumA.Text) - long.Parse(txtNumB.Text) < 0) {
                                MessageBox.Show("A ULA de 32 bits é capaz de representar numeros até 4294967295!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else {
                                Converter(long.Parse(txtNumA.Text), long.Parse(txtNumB.Text), quantBITS);

                                ConversoesBases.ConverterDecimalBinario(convertidoA, numeroA);
                                ConversoesBases.ConverterDecimalBinario(convertidoB, numeroB);

                                ULA32bit_Total ULA_32Bit = new ULA32bit_Total();

                                S = ULA_32Bit.Ativar(convertidoA, convertidoB, F, vRespBool);
                                ConversoesBases.Converter_Bool_Binario_byte(vBitResp, vRespBool, out s, quantBITS);

                                for (int i = 0; i < quantBITS; i++) {
                                    resposta += vBitResp[i];
                                }
                            }
                            break;
                    }
                }

                txt_Resp_Binario.Text = resposta;
                txt_Resp_Decimal.Text = s.ToString();
                txt_Resp_Octal.Text = (Convert.ToString(s, 8));
                txt_Resp_Hexa.Text = (Convert.ToString(s, 16).ToUpper());

            } catch (FormatException Ex) {
                MessageBox.Show("Digite os numeros corretamente!\n" + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception Ex) {
                MessageBox.Show("Um erro inesperado ocorreu!\n" + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_Principal_Load(object sender, EventArgs e) {

        }

        private void btn_Sair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
