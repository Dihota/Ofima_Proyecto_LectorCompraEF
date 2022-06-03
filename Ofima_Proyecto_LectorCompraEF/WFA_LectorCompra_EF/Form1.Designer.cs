namespace WFA_LectorCompra_EF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNitEmisor = new System.Windows.Forms.Label();
            this.lblNomEmisor = new System.Windows.Forms.Label();
            this.lblNumFact = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblmedpag = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblVenci = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblCufe = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFpago = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCiu = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDirec = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFechExp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNitAdqui = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNomAdqui = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Capturar datos XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblNitEmisor);
            this.panel1.Controls.Add(this.lblNomEmisor);
            this.panel1.Controls.Add(this.lblNumFact);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 56);
            this.panel1.TabIndex = 1;
            // 
            // lblNitEmisor
            // 
            this.lblNitEmisor.AutoSize = true;
            this.lblNitEmisor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNitEmisor.Location = new System.Drawing.Point(108, 34);
            this.lblNitEmisor.Name = "lblNitEmisor";
            this.lblNitEmisor.Size = new System.Drawing.Size(14, 15);
            this.lblNitEmisor.TabIndex = 5;
            this.lblNitEmisor.Text = "#";
            // 
            // lblNomEmisor
            // 
            this.lblNomEmisor.AutoSize = true;
            this.lblNomEmisor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEmisor.Location = new System.Drawing.Point(108, 10);
            this.lblNomEmisor.Name = "lblNomEmisor";
            this.lblNomEmisor.Size = new System.Drawing.Size(14, 15);
            this.lblNomEmisor.TabIndex = 4;
            this.lblNomEmisor.Text = "#";
            // 
            // lblNumFact
            // 
            this.lblNumFact.AutoSize = true;
            this.lblNumFact.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFact.Location = new System.Drawing.Point(506, 10);
            this.lblNumFact.Name = "lblNumFact";
            this.lblNumFact.Size = new System.Drawing.Size(14, 15);
            this.lblNumFact.TabIndex = 3;
            this.lblNumFact.Text = "#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emisor : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Factura";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblmedpag);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lblPlazo);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblVenci);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.lblCufe);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblFpago);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lblTel);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblCiu);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblDirec);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblFechExp);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblNitAdqui);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblNomAdqui);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 183);
            this.panel2.TabIndex = 2;
            // 
            // lblmedpag
            // 
            this.lblmedpag.AutoSize = true;
            this.lblmedpag.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmedpag.Location = new System.Drawing.Point(506, 133);
            this.lblmedpag.Name = "lblmedpag";
            this.lblmedpag.Size = new System.Drawing.Size(14, 15);
            this.lblmedpag.TabIndex = 27;
            this.lblmedpag.Text = "#";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(388, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 15);
            this.label15.TabIndex = 26;
            this.label15.Text = "Medio de Pago : ";
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlazo.Location = new System.Drawing.Point(333, 133);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(14, 15);
            this.lblPlazo.TabIndex = 25;
            this.lblPlazo.Text = "#";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(246, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "Dias Plazo : ";
            // 
            // lblVenci
            // 
            this.lblVenci.AutoSize = true;
            this.lblVenci.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenci.Location = new System.Drawing.Point(506, 37);
            this.lblVenci.Name = "lblVenci";
            this.lblVenci.Size = new System.Drawing.Size(14, 15);
            this.lblVenci.TabIndex = 23;
            this.lblVenci.Text = "#";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(388, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Fecha Vencimiento: ";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(601, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(14, 15);
            this.lblHora.TabIndex = 21;
            this.lblHora.Text = "#";
            // 
            // lblCufe
            // 
            this.lblCufe.AutoSize = true;
            this.lblCufe.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCufe.Location = new System.Drawing.Point(107, 159);
            this.lblCufe.Name = "lblCufe";
            this.lblCufe.Size = new System.Drawing.Size(14, 15);
            this.lblCufe.TabIndex = 20;
            this.lblCufe.Text = "#";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "CUFE : ";
            // 
            // lblFpago
            // 
            this.lblFpago.AutoSize = true;
            this.lblFpago.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFpago.Location = new System.Drawing.Point(108, 133);
            this.lblFpago.Name = "lblFpago";
            this.lblFpago.Size = new System.Drawing.Size(14, 15);
            this.lblFpago.TabIndex = 18;
            this.lblFpago.Text = "#";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 15);
            this.label14.TabIndex = 17;
            this.label14.Text = "F. Pago : ";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(108, 109);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(14, 15);
            this.lblTel.TabIndex = 16;
            this.lblTel.Text = "#";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "Telefono : ";
            // 
            // lblCiu
            // 
            this.lblCiu.AutoSize = true;
            this.lblCiu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiu.Location = new System.Drawing.Point(108, 85);
            this.lblCiu.Name = "lblCiu";
            this.lblCiu.Size = new System.Drawing.Size(14, 15);
            this.lblCiu.TabIndex = 14;
            this.lblCiu.Text = "#";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ciudad : ";
            // 
            // lblDirec
            // 
            this.lblDirec.AutoSize = true;
            this.lblDirec.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirec.Location = new System.Drawing.Point(108, 61);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(14, 15);
            this.lblDirec.TabIndex = 12;
            this.lblDirec.Text = "#";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Direccion : ";
            // 
            // lblFechExp
            // 
            this.lblFechExp.AutoSize = true;
            this.lblFechExp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechExp.Location = new System.Drawing.Point(506, 13);
            this.lblFechExp.Name = "lblFechExp";
            this.lblFechExp.Size = new System.Drawing.Size(14, 15);
            this.lblFechExp.TabIndex = 10;
            this.lblFechExp.Text = "#";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(388, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Fecha Expedicion: ";
            // 
            // lblNitAdqui
            // 
            this.lblNitAdqui.AutoSize = true;
            this.lblNitAdqui.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNitAdqui.Location = new System.Drawing.Point(108, 37);
            this.lblNitAdqui.Name = "lblNitAdqui";
            this.lblNitAdqui.Size = new System.Drawing.Size(14, 15);
            this.lblNitAdqui.TabIndex = 8;
            this.lblNitAdqui.Text = "#";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nit : ";
            // 
            // lblNomAdqui
            // 
            this.lblNomAdqui.AutoSize = true;
            this.lblNomAdqui.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomAdqui.Location = new System.Drawing.Point(108, 13);
            this.lblNomAdqui.Name = "lblNomAdqui";
            this.lblNomAdqui.Size = new System.Drawing.Size(14, 15);
            this.lblNomAdqui.TabIndex = 6;
            this.lblNomAdqui.Text = "#";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adquiriente : ";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(12, 257);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(770, 150);
            this.dgvDetalle.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 22);
            this.button2.TabIndex = 4;
            this.button2.Text = "Guardar Datos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(311, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 20);
            this.button3.TabIndex = 5;
            this.button3.Text = "Capturar Archivox XML";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 487);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNitEmisor;
        private System.Windows.Forms.Label lblNomEmisor;
        private System.Windows.Forms.Label lblNumFact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNitAdqui;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNomAdqui;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFechExp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFpago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCiu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDirec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCufe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblVenci;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblmedpag;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

