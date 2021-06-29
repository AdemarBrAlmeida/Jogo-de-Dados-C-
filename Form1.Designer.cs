namespace JogandoDado
{
    partial class frmJogo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogo));
            this.btnLancarDados = new System.Windows.Forms.Button();
            this.btnOutravez = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGbx3 = new System.Windows.Forms.Label();
            this.lblSomaCpu = new System.Windows.Forms.Label();
            this.lblGbx2 = new System.Windows.Forms.Label();
            this.lblSomaUsu = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblGbx1 = new System.Windows.Forms.Label();
            this.pcbResulTres = new System.Windows.Forms.PictureBox();
            this.lblTotCpu = new System.Windows.Forms.Label();
            this.pcbResulDois = new System.Windows.Forms.PictureBox();
            this.pcbResulUm = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVoce = new System.Windows.Forms.Label();
            this.lblTotUsu = new System.Windows.Forms.Label();
            this.pcbUm = new System.Windows.Forms.PictureBox();
            this.pcbDois = new System.Windows.Forms.PictureBox();
            this.pcbTres = new System.Windows.Forms.PictureBox();
            this.pcbQuatro = new System.Windows.Forms.PictureBox();
            this.pcbCinco = new System.Windows.Forms.PictureBox();
            this.pcbSeis = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVencedor = new System.Windows.Forms.Label();
            this.pcbVencedor = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResulTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResulDois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResulUm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQuatro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCinco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSeis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVencedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLancarDados
            // 
            this.btnLancarDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLancarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancarDados.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancarDados.ForeColor = System.Drawing.Color.Red;
            this.btnLancarDados.Location = new System.Drawing.Point(35, 437);
            this.btnLancarDados.Name = "btnLancarDados";
            this.btnLancarDados.Size = new System.Drawing.Size(249, 53);
            this.btnLancarDados.TabIndex = 0;
            this.btnLancarDados.Text = "Lançar Dados";
            this.btnLancarDados.UseVisualStyleBackColor = false;
            this.btnLancarDados.Click += new System.EventHandler(this.btnLancarDados_Click);
            // 
            // btnOutravez
            // 
            this.btnOutravez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOutravez.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutravez.Enabled = false;
            this.btnOutravez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutravez.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutravez.ForeColor = System.Drawing.Color.Green;
            this.btnOutravez.Location = new System.Drawing.Point(35, 496);
            this.btnOutravez.Name = "btnOutravez";
            this.btnOutravez.Size = new System.Drawing.Size(146, 66);
            this.btnOutravez.TabIndex = 1;
            this.btnOutravez.Text = "Reiniciar";
            this.btnOutravez.UseVisualStyleBackColor = false;
            this.btnOutravez.Click += new System.EventHandler(this.btnOutraVez_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Green;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblGbx3);
            this.groupBox1.Controls.Add(this.lblSomaCpu);
            this.groupBox1.Controls.Add(this.lblGbx2);
            this.groupBox1.Controls.Add(this.lblSomaUsu);
            this.groupBox1.Controls.Add(this.lblCPU);
            this.groupBox1.Controls.Add(this.lblGbx1);
            this.groupBox1.Controls.Add(this.pcbResulTres);
            this.groupBox1.Controls.Add(this.lblTotCpu);
            this.groupBox1.Controls.Add(this.pcbResulDois);
            this.groupBox1.Controls.Add(this.pcbResulUm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblVoce);
            this.groupBox1.Controls.Add(this.lblTotUsu);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Location = new System.Drawing.Point(333, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 342);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Números Sorteados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(115, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(401, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Acertando o Número Sorteado tem Bonus +1";
            // 
            // lblGbx3
            // 
            this.lblGbx3.AutoSize = true;
            this.lblGbx3.Location = new System.Drawing.Point(412, 222);
            this.lblGbx3.Name = "lblGbx3";
            this.lblGbx3.Size = new System.Drawing.Size(0, 20);
            this.lblGbx3.TabIndex = 5;
            // 
            // lblSomaCpu
            // 
            this.lblSomaCpu.AutoSize = true;
            this.lblSomaCpu.ForeColor = System.Drawing.Color.White;
            this.lblSomaCpu.Location = new System.Drawing.Point(461, 281);
            this.lblSomaCpu.Name = "lblSomaCpu";
            this.lblSomaCpu.Size = new System.Drawing.Size(18, 20);
            this.lblSomaCpu.TabIndex = 23;
            this.lblSomaCpu.Text = "+";
            // 
            // lblGbx2
            // 
            this.lblGbx2.AutoSize = true;
            this.lblGbx2.Location = new System.Drawing.Point(252, 222);
            this.lblGbx2.Name = "lblGbx2";
            this.lblGbx2.Size = new System.Drawing.Size(0, 20);
            this.lblGbx2.TabIndex = 4;
            // 
            // lblSomaUsu
            // 
            this.lblSomaUsu.AutoSize = true;
            this.lblSomaUsu.ForeColor = System.Drawing.Color.White;
            this.lblSomaUsu.Location = new System.Drawing.Point(301, 282);
            this.lblSomaUsu.Name = "lblSomaUsu";
            this.lblSomaUsu.Size = new System.Drawing.Size(18, 20);
            this.lblSomaUsu.TabIndex = 22;
            this.lblSomaUsu.Text = "+";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblCPU.Location = new System.Drawing.Point(353, 292);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(61, 35);
            this.lblCPU.TabIndex = 20;
            this.lblCPU.Text = "CPU";
            // 
            // lblGbx1
            // 
            this.lblGbx1.AutoSize = true;
            this.lblGbx1.Location = new System.Drawing.Point(76, 222);
            this.lblGbx1.Name = "lblGbx1";
            this.lblGbx1.Size = new System.Drawing.Size(0, 20);
            this.lblGbx1.TabIndex = 3;
            // 
            // pcbResulTres
            // 
            this.pcbResulTres.Location = new System.Drawing.Point(357, 59);
            this.pcbResulTres.Name = "pcbResulTres";
            this.pcbResulTres.Size = new System.Drawing.Size(155, 158);
            this.pcbResulTres.TabIndex = 2;
            this.pcbResulTres.TabStop = false;
            // 
            // lblTotCpu
            // 
            this.lblTotCpu.AutoSize = true;
            this.lblTotCpu.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotCpu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotCpu.Location = new System.Drawing.Point(421, 292);
            this.lblTotCpu.Name = "lblTotCpu";
            this.lblTotCpu.Size = new System.Drawing.Size(30, 35);
            this.lblTotCpu.TabIndex = 17;
            this.lblTotCpu.Text = "0";
            this.lblTotCpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbResulDois
            // 
            this.pcbResulDois.Location = new System.Drawing.Point(188, 59);
            this.pcbResulDois.Name = "pcbResulDois";
            this.pcbResulDois.Size = new System.Drawing.Size(155, 158);
            this.pcbResulDois.TabIndex = 1;
            this.pcbResulDois.TabStop = false;
            // 
            // pcbResulUm
            // 
            this.pcbResulUm.Location = new System.Drawing.Point(18, 59);
            this.pcbResulUm.Name = "pcbResulUm";
            this.pcbResulUm.Size = new System.Drawing.Size(155, 158);
            this.pcbResulUm.TabIndex = 0;
            this.pcbResulUm.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(10, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total de Pontos  ";
            // 
            // lblVoce
            // 
            this.lblVoce.AutoSize = true;
            this.lblVoce.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoce.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblVoce.Location = new System.Drawing.Point(170, 292);
            this.lblVoce.Name = "lblVoce";
            this.lblVoce.Size = new System.Drawing.Size(80, 35);
            this.lblVoce.TabIndex = 15;
            this.lblVoce.Text = "VOCÊ";
            // 
            // lblTotUsu
            // 
            this.lblTotUsu.AutoSize = true;
            this.lblTotUsu.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotUsu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotUsu.Location = new System.Drawing.Point(258, 292);
            this.lblTotUsu.Name = "lblTotUsu";
            this.lblTotUsu.Size = new System.Drawing.Size(30, 35);
            this.lblTotUsu.TabIndex = 16;
            this.lblTotUsu.Text = "0";
            this.lblTotUsu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbUm
            // 
            this.pcbUm.BackColor = System.Drawing.Color.Green;
            this.pcbUm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbUm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbUm.Image = global::JogandoDado.Properties.Resources._1;
            this.pcbUm.Location = new System.Drawing.Point(35, 94);
            this.pcbUm.Name = "pcbUm";
            this.pcbUm.Size = new System.Drawing.Size(97, 93);
            this.pcbUm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUm.TabIndex = 3;
            this.pcbUm.TabStop = false;
            this.pcbUm.Click += new System.EventHandler(this.pcbUm_Click);
            // 
            // pcbDois
            // 
            this.pcbDois.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbDois.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbDois.Image = global::JogandoDado.Properties.Resources._2;
            this.pcbDois.Location = new System.Drawing.Point(187, 94);
            this.pcbDois.Name = "pcbDois";
            this.pcbDois.Size = new System.Drawing.Size(97, 93);
            this.pcbDois.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDois.TabIndex = 4;
            this.pcbDois.TabStop = false;
            this.pcbDois.Click += new System.EventHandler(this.pcbDois_Click);
            // 
            // pcbTres
            // 
            this.pcbTres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbTres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbTres.Image = global::JogandoDado.Properties.Resources._3;
            this.pcbTres.Location = new System.Drawing.Point(35, 216);
            this.pcbTres.Name = "pcbTres";
            this.pcbTres.Size = new System.Drawing.Size(97, 93);
            this.pcbTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTres.TabIndex = 5;
            this.pcbTres.TabStop = false;
            this.pcbTres.Click += new System.EventHandler(this.pcbTres_Click);
            // 
            // pcbQuatro
            // 
            this.pcbQuatro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbQuatro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbQuatro.Image = global::JogandoDado.Properties.Resources._4;
            this.pcbQuatro.Location = new System.Drawing.Point(187, 216);
            this.pcbQuatro.Name = "pcbQuatro";
            this.pcbQuatro.Size = new System.Drawing.Size(97, 93);
            this.pcbQuatro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbQuatro.TabIndex = 6;
            this.pcbQuatro.TabStop = false;
            this.pcbQuatro.Click += new System.EventHandler(this.pcbQuatro_Click);
            // 
            // pcbCinco
            // 
            this.pcbCinco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbCinco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCinco.Image = global::JogandoDado.Properties.Resources._5;
            this.pcbCinco.Location = new System.Drawing.Point(35, 334);
            this.pcbCinco.Name = "pcbCinco";
            this.pcbCinco.Size = new System.Drawing.Size(97, 93);
            this.pcbCinco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCinco.TabIndex = 7;
            this.pcbCinco.TabStop = false;
            this.pcbCinco.Click += new System.EventHandler(this.pcbCinco_Click);
            // 
            // pcbSeis
            // 
            this.pcbSeis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbSeis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbSeis.Image = global::JogandoDado.Properties.Resources._6;
            this.pcbSeis.Location = new System.Drawing.Point(187, 334);
            this.pcbSeis.Name = "pcbSeis";
            this.pcbSeis.Size = new System.Drawing.Size(97, 93);
            this.pcbSeis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSeis.TabIndex = 8;
            this.pcbSeis.TabStop = false;
            this.pcbSeis.Click += new System.EventHandler(this.pcbSeis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(42, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selecione seu Número da Sorte";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Teal;
            this.btnSair.Location = new System.Drawing.Point(187, 496);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 66);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JogandoDado.Properties.Resources.Dado_verm_girando;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(706, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "by DemaSoft";
            // 
            // lblVencedor
            // 
            this.lblVencedor.AutoSize = true;
            this.lblVencedor.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblVencedor.Location = new System.Drawing.Point(468, 461);
            this.lblVencedor.Name = "lblVencedor";
            this.lblVencedor.Size = new System.Drawing.Size(0, 35);
            this.lblVencedor.TabIndex = 18;
            this.lblVencedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pcbVencedor
            // 
            this.pcbVencedor.Location = new System.Drawing.Point(314, 419);
            this.pcbVencedor.Name = "pcbVencedor";
            this.pcbVencedor.Size = new System.Drawing.Size(134, 120);
            this.pcbVencedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVencedor.TabIndex = 19;
            this.pcbVencedor.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(67, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(780, 35);
            this.label4.TabIndex = 21;
            this.label4.Text = "* Quem  Chegar a 200 ou mais pontos primeiro está com Sorte *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Green;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OliveDrab;
            this.label6.Location = new System.Drawing.Point(139, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 47);
            this.label6.TabIndex = 22;
            this.label6.Text = "B";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Green;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OliveDrab;
            this.label7.Location = new System.Drawing.Point(138, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 47);
            this.label7.TabIndex = 23;
            this.label7.Text = "O";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Green;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OliveDrab;
            this.label8.Location = new System.Drawing.Point(139, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 47);
            this.label8.TabIndex = 24;
            this.label8.Text = "N";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Green;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OliveDrab;
            this.label9.Location = new System.Drawing.Point(139, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 47);
            this.label9.TabIndex = 25;
            this.label9.Text = "U";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Green;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OliveDrab;
            this.label10.Location = new System.Drawing.Point(139, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 47);
            this.label10.TabIndex = 26;
            this.label10.Text = "S";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 592);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pcbVencedor);
            this.Controls.Add(this.lblVencedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcbSeis);
            this.Controls.Add(this.pcbCinco);
            this.Controls.Add(this.pcbQuatro);
            this.Controls.Add(this.pcbTres);
            this.Controls.Add(this.pcbDois);
            this.Controls.Add(this.pcbUm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOutravez);
            this.Controls.Add(this.btnLancarDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogando Dado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResulTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResulDois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResulUm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQuatro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCinco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSeis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVencedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLancarDados;
        private System.Windows.Forms.Button btnOutravez;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcbResulTres;
        private System.Windows.Forms.PictureBox pcbResulDois;
        private System.Windows.Forms.PictureBox pcbResulUm;
        private System.Windows.Forms.PictureBox pcbUm;
        private System.Windows.Forms.PictureBox pcbDois;
        private System.Windows.Forms.PictureBox pcbTres;
        private System.Windows.Forms.PictureBox pcbQuatro;
        private System.Windows.Forms.PictureBox pcbCinco;
        private System.Windows.Forms.PictureBox pcbSeis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblGbx3;
        private System.Windows.Forms.Label lblGbx2;
        private System.Windows.Forms.Label lblGbx1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVoce;
        private System.Windows.Forms.Label lblTotUsu;
        private System.Windows.Forms.Label lblTotCpu;
        private System.Windows.Forms.Label lblVencedor;
        private System.Windows.Forms.PictureBox pcbVencedor;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSomaUsu;
        private System.Windows.Forms.Label lblSomaCpu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

