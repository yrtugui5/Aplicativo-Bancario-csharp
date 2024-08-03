namespace ExtraP2
{
    partial class FormTransferencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbxContasDestino = new System.Windows.Forms.ComboBox();
            this.gpBoxMeusDados = new System.Windows.Forms.GroupBox();
            this.lblValorMinhaConta = new System.Windows.Forms.Label();
            this.lblContaMinhaConta = new System.Windows.Forms.Label();
            this.lblCPFMinhaConta = new System.Windows.Forms.Label();
            this.lblNomeMinhaConta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timerUpdateValor = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorTransferencia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCPFContaDestino = new System.Windows.Forms.Label();
            this.lblNomeContaDestino = new System.Windows.Forms.Label();
            this.gpBoxMeusDados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxContasDestino
            // 
            this.cbxContasDestino.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxContasDestino.FormattingEnabled = true;
            this.cbxContasDestino.Location = new System.Drawing.Point(24, 305);
            this.cbxContasDestino.MaxLength = 5;
            this.cbxContasDestino.Name = "cbxContasDestino";
            this.cbxContasDestino.Size = new System.Drawing.Size(261, 25);
            this.cbxContasDestino.TabIndex = 0;
            this.cbxContasDestino.SelectionChangeCommitted += new System.EventHandler(this.cbxContasDestino_SelectionChangeCommitted);
            this.cbxContasDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber_KeyPressEvent);
            // 
            // gpBoxMeusDados
            // 
            this.gpBoxMeusDados.Controls.Add(this.lblValorMinhaConta);
            this.gpBoxMeusDados.Controls.Add(this.lblContaMinhaConta);
            this.gpBoxMeusDados.Controls.Add(this.lblCPFMinhaConta);
            this.gpBoxMeusDados.Controls.Add(this.lblNomeMinhaConta);
            this.gpBoxMeusDados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxMeusDados.Location = new System.Drawing.Point(24, 81);
            this.gpBoxMeusDados.Name = "gpBoxMeusDados";
            this.gpBoxMeusDados.Size = new System.Drawing.Size(261, 186);
            this.gpBoxMeusDados.TabIndex = 1;
            this.gpBoxMeusDados.TabStop = false;
            this.gpBoxMeusDados.Text = "Dados da Conta";
            // 
            // lblValorMinhaConta
            // 
            this.lblValorMinhaConta.AutoSize = true;
            this.lblValorMinhaConta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMinhaConta.Location = new System.Drawing.Point(16, 137);
            this.lblValorMinhaConta.Name = "lblValorMinhaConta";
            this.lblValorMinhaConta.Size = new System.Drawing.Size(106, 21);
            this.lblValorMinhaConta.TabIndex = 8;
            this.lblValorMinhaConta.Text = "Conta destino";
            // 
            // lblContaMinhaConta
            // 
            this.lblContaMinhaConta.AutoSize = true;
            this.lblContaMinhaConta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaMinhaConta.Location = new System.Drawing.Point(16, 102);
            this.lblContaMinhaConta.Name = "lblContaMinhaConta";
            this.lblContaMinhaConta.Size = new System.Drawing.Size(106, 21);
            this.lblContaMinhaConta.TabIndex = 7;
            this.lblContaMinhaConta.Text = "Conta destino";
            // 
            // lblCPFMinhaConta
            // 
            this.lblCPFMinhaConta.AutoSize = true;
            this.lblCPFMinhaConta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFMinhaConta.Location = new System.Drawing.Point(16, 67);
            this.lblCPFMinhaConta.Name = "lblCPFMinhaConta";
            this.lblCPFMinhaConta.Size = new System.Drawing.Size(106, 21);
            this.lblCPFMinhaConta.TabIndex = 6;
            this.lblCPFMinhaConta.Text = "Conta destino";
            // 
            // lblNomeMinhaConta
            // 
            this.lblNomeMinhaConta.AutoSize = true;
            this.lblNomeMinhaConta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMinhaConta.Location = new System.Drawing.Point(16, 32);
            this.lblNomeMinhaConta.Name = "lblNomeMinhaConta";
            this.lblNomeMinhaConta.Size = new System.Drawing.Size(106, 21);
            this.lblNomeMinhaConta.TabIndex = 5;
            this.lblNomeMinhaConta.Text = "Conta destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transferência";
            // 
            // btnTransferir
            // 
            this.btnTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferir.Location = new System.Drawing.Point(24, 546);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(261, 45);
            this.btnTransferir.TabIndex = 3;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Conta Destino";
            // 
            // timerUpdateValor
            // 
            this.timerUpdateValor.Enabled = true;
            this.timerUpdateValor.Interval = 1000;
            this.timerUpdateValor.Tick += new System.EventHandler(this.timerUpdateValor_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor da Transferência";
            // 
            // txtValorTransferencia
            // 
            this.txtValorTransferencia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTransferencia.Location = new System.Drawing.Point(24, 501);
            this.txtValorTransferencia.Name = "txtValorTransferencia";
            this.txtValorTransferencia.Size = new System.Drawing.Size(261, 25);
            this.txtValorTransferencia.TabIndex = 8;
            this.txtValorTransferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber_KeyPressEvent);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCPFContaDestino);
            this.groupBox1.Controls.Add(this.lblNomeContaDestino);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 117);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Conta Destinatário";
            // 
            // lblCPFContaDestino
            // 
            this.lblCPFContaDestino.AutoSize = true;
            this.lblCPFContaDestino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFContaDestino.Location = new System.Drawing.Point(16, 67);
            this.lblCPFContaDestino.Name = "lblCPFContaDestino";
            this.lblCPFContaDestino.Size = new System.Drawing.Size(106, 21);
            this.lblCPFContaDestino.TabIndex = 6;
            this.lblCPFContaDestino.Text = "Conta destino";
            // 
            // lblNomeContaDestino
            // 
            this.lblNomeContaDestino.AutoSize = true;
            this.lblNomeContaDestino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeContaDestino.Location = new System.Drawing.Point(16, 32);
            this.lblNomeContaDestino.Name = "lblNomeContaDestino";
            this.lblNomeContaDestino.Size = new System.Drawing.Size(108, 21);
            this.lblNomeContaDestino.TabIndex = 5;
            this.lblNomeContaDestino.Text = "Nome destino";
            // 
            // FormTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(316, 615);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValorTransferencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpBoxMeusDados);
            this.Controls.Add(this.cbxContasDestino);
            this.Name = "FormTransferencia";
            this.Text = "Transferencia";
            this.Load += new System.EventHandler(this.FormTransferencia_Load);
            this.gpBoxMeusDados.ResumeLayout(false);
            this.gpBoxMeusDados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxContasDestino;
        private System.Windows.Forms.GroupBox gpBoxMeusDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Label lblValorMinhaConta;
        private System.Windows.Forms.Label lblContaMinhaConta;
        private System.Windows.Forms.Label lblCPFMinhaConta;
        private System.Windows.Forms.Label lblNomeMinhaConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerUpdateValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorTransferencia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCPFContaDestino;
        private System.Windows.Forms.Label lblNomeContaDestino;
    }
}