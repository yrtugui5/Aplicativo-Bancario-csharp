namespace ExtraP2
{
    partial class FormSaque
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
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSaqueInfoConta = new System.Windows.Forms.Label();
            this.lblSaqueInfoNome = new System.Windows.Forms.Label();
            this.txtValorSaque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaque = new System.Windows.Forms.Button();
            this.timerUpdateValor = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(41, 156);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(48, 17);
            this.lblSaldo.TabIndex = 13;
            this.lblSaldo.Text = "Saldo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Saque";
            // 
            // lblSaqueInfoConta
            // 
            this.lblSaqueInfoConta.AutoSize = true;
            this.lblSaqueInfoConta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaqueInfoConta.Location = new System.Drawing.Point(41, 107);
            this.lblSaqueInfoConta.Name = "lblSaqueInfoConta";
            this.lblSaqueInfoConta.Size = new System.Drawing.Size(43, 17);
            this.lblSaqueInfoConta.TabIndex = 11;
            this.lblSaqueInfoConta.Text = "label3";
            // 
            // lblSaqueInfoNome
            // 
            this.lblSaqueInfoNome.AutoSize = true;
            this.lblSaqueInfoNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaqueInfoNome.Location = new System.Drawing.Point(41, 82);
            this.lblSaqueInfoNome.Name = "lblSaqueInfoNome";
            this.lblSaqueInfoNome.Size = new System.Drawing.Size(43, 17);
            this.lblSaqueInfoNome.TabIndex = 10;
            this.lblSaqueInfoNome.Text = "label2";
            // 
            // txtValorSaque
            // 
            this.txtValorSaque.Location = new System.Drawing.Point(44, 215);
            this.txtValorSaque.Name = "txtValorSaque";
            this.txtValorSaque.Size = new System.Drawing.Size(156, 20);
            this.txtValorSaque.TabIndex = 9;
            this.txtValorSaque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber_KeyPressEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Valor do Saque:";
            // 
            // btnSaque
            // 
            this.btnSaque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaque.Location = new System.Drawing.Point(44, 263);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(156, 37);
            this.btnSaque.TabIndex = 7;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // timerUpdateValor
            // 
            this.timerUpdateValor.Enabled = true;
            this.timerUpdateValor.Interval = 1000;
            this.timerUpdateValor.Tick += new System.EventHandler(this.timerUpdateValor_Tick);
            // 
            // FormSaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(257, 336);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSaqueInfoConta);
            this.Controls.Add(this.lblSaqueInfoNome);
            this.Controls.Add(this.txtValorSaque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaque);
            this.Name = "FormSaque";
            this.Text = "Saque";
            this.Load += new System.EventHandler(this.FormSaque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSaqueInfoConta;
        private System.Windows.Forms.Label lblSaqueInfoNome;
        private System.Windows.Forms.TextBox txtValorSaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Timer timerUpdateValor;
    }
}