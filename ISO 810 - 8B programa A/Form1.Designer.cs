namespace ISO_810___8B_programa_A
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtNoCheque = new TextBox();
            txtMontoNumero = new TextBox();
            txtMontoLetra = new TextBox();
            txtFacturaPagada = new TextBox();
            txtCedulaCliente = new TextBox();
            txtConceptoPago = new TextBox();
            dtpFechaPago = new DateTimePicker();
            btnGuardar = new Button();
            btnGuardarYVerFactura = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(308, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "Registro de Cheques";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 92);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "No. Cheque:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 121);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 2;
            label3.Text = "Concepto de Pago:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 151);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Cédula:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 185);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 4;
            label5.Text = "Fecha de pago:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 278);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 5;
            label6.Text = "Factura pagada:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 218);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 6;
            label7.Text = "Monto (Número): ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(84, 247);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 7;
            label8.Text = "Monto (Letra): ";
            // 
            // txtNoCheque
            // 
            txtNoCheque.Location = new Point(252, 89);
            txtNoCheque.Name = "txtNoCheque";
            txtNoCheque.Size = new Size(250, 27);
            txtNoCheque.TabIndex = 8;
            // 
            // txtMontoNumero
            // 
            txtMontoNumero.Location = new Point(252, 215);
            txtMontoNumero.Name = "txtMontoNumero";
            txtMontoNumero.Size = new Size(250, 27);
            txtMontoNumero.TabIndex = 9;
            // 
            // txtMontoLetra
            // 
            txtMontoLetra.Location = new Point(252, 245);
            txtMontoLetra.Name = "txtMontoLetra";
            txtMontoLetra.Size = new Size(250, 27);
            txtMontoLetra.TabIndex = 10;
            // 
            // txtFacturaPagada
            // 
            txtFacturaPagada.Location = new Point(252, 275);
            txtFacturaPagada.Name = "txtFacturaPagada";
            txtFacturaPagada.Size = new Size(250, 27);
            txtFacturaPagada.TabIndex = 11;
            // 
            // txtCedulaCliente
            // 
            txtCedulaCliente.Location = new Point(252, 148);
            txtCedulaCliente.Name = "txtCedulaCliente";
            txtCedulaCliente.Size = new Size(250, 27);
            txtCedulaCliente.TabIndex = 12;
            // 
            // txtConceptoPago
            // 
            txtConceptoPago.Location = new Point(252, 118);
            txtConceptoPago.Name = "txtConceptoPago";
            txtConceptoPago.Size = new Size(250, 27);
            txtConceptoPago.TabIndex = 13;
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Location = new Point(252, 180);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(250, 27);
            dtpFechaPago.TabIndex = 14;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(133, 363);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(167, 36);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnGuardarYVerFactura
            // 
            btnGuardarYVerFactura.Location = new Point(385, 363);
            btnGuardarYVerFactura.Name = "btnGuardarYVerFactura";
            btnGuardarYVerFactura.Size = new Size(167, 36);
            btnGuardarYVerFactura.TabIndex = 16;
            btnGuardarYVerFactura.Text = "Guardar y Ver Factura";
            btnGuardarYVerFactura.UseVisualStyleBackColor = true;
            btnGuardarYVerFactura.Click += btnGuardarYVerFactura_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 424);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 17;
            label9.Text = "label9";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 453);
            Controls.Add(label9);
            Controls.Add(btnGuardarYVerFactura);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFechaPago);
            Controls.Add(txtConceptoPago);
            Controls.Add(txtCedulaCliente);
            Controls.Add(txtFacturaPagada);
            Controls.Add(txtMontoLetra);
            Controls.Add(txtMontoNumero);
            Controls.Add(txtNoCheque);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtNoCheque;
        private TextBox txtMontoNumero;
        private TextBox txtMontoLetra;
        private TextBox txtFacturaPagada;
        private TextBox txtCedulaCliente;
        private TextBox txtConceptoPago;
        private DateTimePicker dtpFechaPago;
        private Button btnGuardar;
        private Button btnGuardarYVerFactura;
        private Label label9;
    }
}
