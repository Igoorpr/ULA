namespace ULA {
    partial class frm_Principal {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxOP_ULA = new System.Windows.Forms.ComboBox();
            this.txtNumA = new System.Windows.Forms.TextBox();
            this.txtNumB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Converter = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Resp_Decimal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Resp_Binario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Resp_Octal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Resp_Hexa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_Hexa_A = new System.Windows.Forms.TextBox();
            this.txt_Octal_A = new System.Windows.Forms.TextBox();
            this.txt_Binario_A = new System.Windows.Forms.TextBox();
            this.txt_Decimal_A = new System.Windows.Forms.TextBox();
            this.txt_Hexa_B = new System.Windows.Forms.TextBox();
            this.txt_Octal_B = new System.Windows.Forms.TextBox();
            this.txt_Binario_B = new System.Windows.Forms.TextBox();
            this.txt_Decimal_B = new System.Windows.Forms.TextBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione a ULA que deseja usar:";
            // 
            // cbxOP_ULA
            // 
            this.cbxOP_ULA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOP_ULA.FormattingEnabled = true;
            this.cbxOP_ULA.Items.AddRange(new object[] {
            "ULA de 1 bit",
            "ULA de 8 bits",
            "ULA de 16 bits",
            "ULA de 32 bits"});
            this.cbxOP_ULA.Location = new System.Drawing.Point(374, 89);
            this.cbxOP_ULA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxOP_ULA.Name = "cbxOP_ULA";
            this.cbxOP_ULA.Size = new System.Drawing.Size(163, 28);
            this.cbxOP_ULA.TabIndex = 5;
            // 
            // txtNumA
            // 
            this.txtNumA.Location = new System.Drawing.Point(123, 183);
            this.txtNumA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumA.Name = "txtNumA";
            this.txtNumA.Size = new System.Drawing.Size(148, 26);
            this.txtNumA.TabIndex = 6;
            // 
            // txtNumB
            // 
            this.txtNumB.Location = new System.Drawing.Point(688, 183);
            this.txtNumB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumB.Name = "txtNumB";
            this.txtNumB.Size = new System.Drawing.Size(148, 26);
            this.txtNumB.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Num A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Num B:";
            // 
            // btn_Converter
            // 
            this.btn_Converter.Location = new System.Drawing.Point(374, 183);
            this.btn_Converter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Converter.Name = "btn_Converter";
            this.btn_Converter.Size = new System.Drawing.Size(165, 35);
            this.btn_Converter.TabIndex = 15;
            this.btn_Converter.Text = "Converter";
            this.btn_Converter.UseVisualStyleBackColor = true;
            this.btn_Converter.Click += new System.EventHandler(this.btn_Converter_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSoma.Location = new System.Drawing.Point(368, 295);
            this.btnSoma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(66, 46);
            this.btnSoma.TabIndex = 16;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(482, 295);
            this.btnSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(66, 46);
            this.btnSub.TabIndex = 17;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.Location = new System.Drawing.Point(482, 380);
            this.btnDivisao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(66, 46);
            this.btnDivisao.TabIndex = 18;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacao.Location = new System.Drawing.Point(368, 380);
            this.btnMultiplicacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(66, 46);
            this.btnMultiplicacao.TabIndex = 19;
            this.btnMultiplicacao.Text = "x";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 665);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Decimal:";
            // 
            // txt_Resp_Decimal
            // 
            this.txt_Resp_Decimal.Location = new System.Drawing.Point(369, 660);
            this.txt_Resp_Decimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Resp_Decimal.Name = "txt_Resp_Decimal";
            this.txt_Resp_Decimal.ReadOnly = true;
            this.txt_Resp_Decimal.Size = new System.Drawing.Size(168, 26);
            this.txt_Resp_Decimal.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 545);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Binário:";
            // 
            // txt_Resp_Binario
            // 
            this.txt_Resp_Binario.Location = new System.Drawing.Point(369, 540);
            this.txt_Resp_Binario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Resp_Binario.Name = "txt_Resp_Binario";
            this.txt_Resp_Binario.ReadOnly = true;
            this.txt_Resp_Binario.Size = new System.Drawing.Size(168, 26);
            this.txt_Resp_Binario.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 585);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Octal:";
            // 
            // txt_Resp_Octal
            // 
            this.txt_Resp_Octal.Location = new System.Drawing.Point(369, 580);
            this.txt_Resp_Octal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Resp_Octal.Name = "txt_Resp_Octal";
            this.txt_Resp_Octal.ReadOnly = true;
            this.txt_Resp_Octal.Size = new System.Drawing.Size(168, 26);
            this.txt_Resp_Octal.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 625);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Hexadecimal:";
            // 
            // txt_Resp_Hexa
            // 
            this.txt_Resp_Hexa.Location = new System.Drawing.Point(369, 620);
            this.txt_Resp_Hexa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Resp_Hexa.Name = "txt_Resp_Hexa";
            this.txt_Resp_Hexa.ReadOnly = true;
            this.txt_Resp_Hexa.Size = new System.Drawing.Size(168, 26);
            this.txt_Resp_Hexa.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(382, 491);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 29);
            this.label10.TabIndex = 28;
            this.label10.Text = "Resposta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 385);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Hexadecimal:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 345);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Octal:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 305);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Binário:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 425);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Decimal:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(573, 385);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "Hexadecimal:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(627, 345);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 20);
            this.label16.TabIndex = 35;
            this.label16.Text = "Octal:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(616, 305);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 20);
            this.label17.TabIndex = 34;
            this.label17.Text = "Binário:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(608, 425);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 20);
            this.label18.TabIndex = 33;
            this.label18.Text = "Decimal:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(664, 649);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 20);
            this.label19.TabIndex = 45;
            this.label19.Text = "Desenvolvedores:";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(664, 708);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(122, 20);
            this.label20.TabIndex = 46;
            this.label20.Text = "Paulo Henrique ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(664, 679);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 20);
            this.label21.TabIndex = 47;
            this.label21.Text = "Igor Palhares ";
            // 
            // txt_Hexa_A
            // 
            this.txt_Hexa_A.Location = new System.Drawing.Point(123, 380);
            this.txt_Hexa_A.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Hexa_A.Name = "txt_Hexa_A";
            this.txt_Hexa_A.ReadOnly = true;
            this.txt_Hexa_A.Size = new System.Drawing.Size(168, 26);
            this.txt_Hexa_A.TabIndex = 51;
            // 
            // txt_Octal_A
            // 
            this.txt_Octal_A.Location = new System.Drawing.Point(123, 340);
            this.txt_Octal_A.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Octal_A.Name = "txt_Octal_A";
            this.txt_Octal_A.ReadOnly = true;
            this.txt_Octal_A.Size = new System.Drawing.Size(168, 26);
            this.txt_Octal_A.TabIndex = 50;
            // 
            // txt_Binario_A
            // 
            this.txt_Binario_A.Location = new System.Drawing.Point(123, 300);
            this.txt_Binario_A.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Binario_A.Name = "txt_Binario_A";
            this.txt_Binario_A.ReadOnly = true;
            this.txt_Binario_A.Size = new System.Drawing.Size(168, 26);
            this.txt_Binario_A.TabIndex = 49;
            // 
            // txt_Decimal_A
            // 
            this.txt_Decimal_A.Location = new System.Drawing.Point(123, 420);
            this.txt_Decimal_A.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Decimal_A.Name = "txt_Decimal_A";
            this.txt_Decimal_A.ReadOnly = true;
            this.txt_Decimal_A.Size = new System.Drawing.Size(168, 26);
            this.txt_Decimal_A.TabIndex = 48;
            // 
            // txt_Hexa_B
            // 
            this.txt_Hexa_B.Location = new System.Drawing.Point(688, 380);
            this.txt_Hexa_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Hexa_B.Name = "txt_Hexa_B";
            this.txt_Hexa_B.ReadOnly = true;
            this.txt_Hexa_B.Size = new System.Drawing.Size(168, 26);
            this.txt_Hexa_B.TabIndex = 55;
            // 
            // txt_Octal_B
            // 
            this.txt_Octal_B.Location = new System.Drawing.Point(688, 340);
            this.txt_Octal_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Octal_B.Name = "txt_Octal_B";
            this.txt_Octal_B.ReadOnly = true;
            this.txt_Octal_B.Size = new System.Drawing.Size(168, 26);
            this.txt_Octal_B.TabIndex = 54;
            // 
            // txt_Binario_B
            // 
            this.txt_Binario_B.Location = new System.Drawing.Point(688, 300);
            this.txt_Binario_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Binario_B.Name = "txt_Binario_B";
            this.txt_Binario_B.ReadOnly = true;
            this.txt_Binario_B.Size = new System.Drawing.Size(168, 26);
            this.txt_Binario_B.TabIndex = 53;
            // 
            // txt_Decimal_B
            // 
            this.txt_Decimal_B.Location = new System.Drawing.Point(688, 420);
            this.txt_Decimal_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Decimal_B.Name = "txt_Decimal_B";
            this.txt_Decimal_B.ReadOnly = true;
            this.txt_Decimal_B.Size = new System.Drawing.Size(168, 26);
            this.txt_Decimal_B.TabIndex = 52;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(18, 688);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(138, 35);
            this.btn_Sair.TabIndex = 56;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 742);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.txt_Hexa_B);
            this.Controls.Add(this.txt_Octal_B);
            this.Controls.Add(this.txt_Binario_B);
            this.Controls.Add(this.txt_Decimal_B);
            this.Controls.Add(this.txt_Hexa_A);
            this.Controls.Add(this.txt_Octal_A);
            this.Controls.Add(this.txt_Binario_A);
            this.Controls.Add(this.txt_Decimal_A);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Resp_Hexa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Resp_Octal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Resp_Binario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Resp_Decimal);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btn_Converter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumB);
            this.Controls.Add(this.txtNumA);
            this.Controls.Add(this.cbxOP_ULA);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Principal";
            this.Text = "Projeto ULA";
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxOP_ULA;
        private System.Windows.Forms.TextBox txtNumA;
        private System.Windows.Forms.TextBox txtNumB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Converter;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Resp_Decimal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Resp_Binario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Resp_Octal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Resp_Hexa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_Hexa_A;
        private System.Windows.Forms.TextBox txt_Octal_A;
        private System.Windows.Forms.TextBox txt_Binario_A;
        private System.Windows.Forms.TextBox txt_Decimal_A;
        private System.Windows.Forms.TextBox txt_Hexa_B;
        private System.Windows.Forms.TextBox txt_Octal_B;
        private System.Windows.Forms.TextBox txt_Binario_B;
        private System.Windows.Forms.TextBox txt_Decimal_B;
        private System.Windows.Forms.Button btn_Sair;
    }
}

