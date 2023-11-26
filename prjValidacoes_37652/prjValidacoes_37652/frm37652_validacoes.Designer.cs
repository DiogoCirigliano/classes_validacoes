namespace prjValidacoes_37652
{
    partial class frm37652_validacoes
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
            this.lblValidacao = new System.Windows.Forms.Label();
            this.txtValidar = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.cmbSelecao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblValidacao
            // 
            this.lblValidacao.AutoSize = true;
            this.lblValidacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidacao.Location = new System.Drawing.Point(8, 8);
            this.lblValidacao.Name = "lblValidacao";
            this.lblValidacao.Size = new System.Drawing.Size(97, 20);
            this.lblValidacao.TabIndex = 0;
            this.lblValidacao.Text = "Validações";
            // 
            // txtValidar
            // 
            this.txtValidar.Location = new System.Drawing.Point(8, 42);
            this.txtValidar.MaxLength = 16;
            this.txtValidar.Multiline = true;
            this.txtValidar.Name = "txtValidar";
            this.txtValidar.Size = new System.Drawing.Size(198, 23);
            this.txtValidar.TabIndex = 1;
            this.txtValidar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidar_KeyPress);
            // 
            // btnValidar
            // 
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValidar.Location = new System.Drawing.Point(126, 42);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(80, 23);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // cmbSelecao
            // 
            this.cmbSelecao.FormattingEnabled = true;
            this.cmbSelecao.Items.AddRange(new object[] {
            "Validar cartão de crédito",
            "Validar CNH",
            "Validar CPF",
            "Validar RG",
            "Validar CNPJ",
            "Validar Titulo de eleitor",
            "Validar Pis/Pasep"});
            this.cmbSelecao.Location = new System.Drawing.Point(8, 78);
            this.cmbSelecao.Name = "cmbSelecao";
            this.cmbSelecao.Size = new System.Drawing.Size(198, 21);
            this.cmbSelecao.TabIndex = 3;
            this.cmbSelecao.SelectedIndexChanged += new System.EventHandler(this.cmbSelecao_SelectedIndexChanged);
            // 
            // frm37652_validacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(224, 117);
            this.Controls.Add(this.cmbSelecao);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtValidar);
            this.Controls.Add(this.lblValidacao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm37652_validacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm37652_validacoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValidacao;
        private System.Windows.Forms.TextBox txtValidar;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.ComboBox cmbSelecao;
    }
}

