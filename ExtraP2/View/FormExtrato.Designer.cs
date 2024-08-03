namespace ExtraP2
{
    partial class FormExtrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExtrato));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.visualizador = new System.Windows.Forms.PrintPreviewDialog();
            this.printExtrato = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(12, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(513, 50);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Gerar Nota de Extrato";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // visualizador
            // 
            this.visualizador.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.visualizador.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.visualizador.ClientSize = new System.Drawing.Size(400, 300);
            this.visualizador.Document = this.printExtrato;
            this.visualizador.Enabled = true;
            this.visualizador.Icon = ((System.Drawing.Icon)(resources.GetObject("visualizador.Icon")));
            this.visualizador.Name = "printPreviewDialog1";
            this.visualizador.Visible = false;
            this.visualizador.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.visualizador_FormClosed);
            // 
            // printExtrato
            // 
            this.printExtrato.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printExtrato_PrintPage);
            // 
            // FormExtrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(540, 75);
            this.Controls.Add(this.btnImprimir);
            this.Name = "FormExtrato";
            this.Text = "Extrato";
            this.Load += new System.EventHandler(this.FormExtrato_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintPreviewDialog visualizador;
        private System.Drawing.Printing.PrintDocument printExtrato;
    }
}