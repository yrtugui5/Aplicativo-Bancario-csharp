namespace ExtraP2
{
    partial class FormDeposito
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
            this.btnDepositar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorDeposito = new System.Windows.Forms.TextBox();
            this.lblDepoInfoNome = new System.Windows.Forms.Label();
            this.lblDepoInfoConta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.updateValorTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnDepositar
            // 
            this.btnDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.Location = new System.Drawing.Point(49, 248);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(156, 37);
            this.btnDepositar.TabIndex = 0;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor do Deposito:";
            // 
            // txtValorDeposito
            // 
            this.txtValorDeposito.Location = new System.Drawing.Point(49, 201);
            this.txtValorDeposito.Name = "txtValorDeposito";
            this.txtValorDeposito.Size = new System.Drawing.Size(156, 20);
            this.txtValorDeposito.TabIndex = 2;
            this.txtValorDeposito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber_KeyPressEvent);
            // 
            // lblDepoInfoNome
            // 
            this.lblDepoInfoNome.AutoSize = true;
            this.lblDepoInfoNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepoInfoNome.Location = new System.Drawing.Point(46, 68);
            this.lblDepoInfoNome.Name = "lblDepoInfoNome";
            this.lblDepoInfoNome.Size = new System.Drawing.Size(43, 17);
            this.lblDepoInfoNome.TabIndex = 3;
            this.lblDepoInfoNome.Text = "label2";
            // 
            // lblDepoInfoConta
            // 
            this.lblDepoInfoConta.AutoSize = true;
            this.lblDepoInfoConta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepoInfoConta.Location = new System.Drawing.Point(46, 93);
            this.lblDepoInfoConta.Name = "lblDepoInfoConta";
            this.lblDepoInfoConta.Size = new System.Drawing.Size(43, 17);
            this.lblDepoInfoConta.TabIndex = 4;
            this.lblDepoInfoConta.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Depósito";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(46, 142);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(48, 17);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "Saldo: ";
            // 
            // updateValorTimer
            // 
            this.updateValorTimer.Enabled = true;
            this.updateValorTimer.Interval = 1000;
            this.updateValorTimer.Tick += new System.EventHandler(this.updateValorTimer_Tick);
            // 
            // FormDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(259, 324);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDepoInfoConta);
            this.Controls.Add(this.lblDepoInfoNome);
            this.Controls.Add(this.txtValorDeposito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDepositar);
            this.Name = "FormDeposito";
            this.Text = "Deposito";
            this.Load += new System.EventHandler(this.FormDeposito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorDeposito;
        private System.Windows.Forms.Label lblDepoInfoNome;
        private System.Windows.Forms.Label lblDepoInfoConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Timer updateValorTimer;
    }
}