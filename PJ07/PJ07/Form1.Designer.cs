namespace PJ07
{
    partial class frmReais
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtVdolar = new System.Windows.Forms.TextBox();
            this.txtCdolar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(356, 196);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.Calcular);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(253, 96);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(86, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Conversão Dolar";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(271, 143);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(59, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Valor Dolar";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // txtVdolar
            // 
            this.txtVdolar.Location = new System.Drawing.Point(345, 93);
            this.txtVdolar.Name = "txtVdolar";
            this.txtVdolar.Size = new System.Drawing.Size(100, 20);
            this.txtVdolar.TabIndex = 3;
            // 
            // txtCdolar
            // 
            this.txtCdolar.Location = new System.Drawing.Point(345, 140);
            this.txtCdolar.Name = "txtCdolar";
            this.txtCdolar.Size = new System.Drawing.Size(100, 20);
            this.txtCdolar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(431, 251);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "0";
            // 
            // frmReais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCdolar);
            this.Controls.Add(this.txtVdolar);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frmReais";
            this.Text = "Reais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtVdolar;
        private System.Windows.Forms.TextBox txtCdolar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
    }
}

