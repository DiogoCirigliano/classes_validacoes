using prj37652_CC;
using prj37652_cnh;
using prj37652_CNPJ;
using prj37652_CPF;
using prj37652_PIS;
using Prj37652_Titulo;
using RGvalidacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjValidacoes_37652
{
    public partial class frm37652_validacoes : Form
    {
        public frm37652_validacoes()
        {
            InitializeComponent();
        }
        private void frm37652_validacoes_Load(object sender, EventArgs e)
        {
            cmbSelecao.Text = "Selecione a validação";
        }
        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtValidar.Text) )
            {
                MessageBox.Show("caixa de texto vazia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtValidar.Focus();
            }
            try
            {
                if (cmbSelecao.SelectedIndex == 0)
                {
                    btnValidar.Text = cls37652_CC.validar(txtValidar.Text)? "Válido":"Inválido";
                    return;
                }
                if(cmbSelecao.SelectedIndex == 1)
                {
                    btnValidar.Text = cls37652_cnh.Validar(txtValidar.Text)? "Válido": "Inválido";
                    return;
                }
                if(cmbSelecao.SelectedIndex == 2)
                {
                    btnValidar.Text = cls37652_CPF.vldDigito(txtValidar.Text) ? "Válido" : "Inválido";
                    return;
                }
                if (cmbSelecao.SelectedIndex == 3)
                {
                    btnValidar.Text = CLS_RG.RG(txtValidar.Text) ? "Válido" : "Inválido";
                    return;
                }
                if (cmbSelecao.SelectedIndex == 4)
                {
                    btnValidar.Text = cls37652_CNPJ.CNPJ(txtValidar.Text) ? "Válido" : "Inválido";
                    return;
                }
                if (cmbSelecao.SelectedIndex == 5)
                {
                    btnValidar.Text = cls37652_Titulo.vldTitulo(txtValidar.Text) ? "Válido" : "Inválido";
                    return;
                }
                if (cmbSelecao.SelectedIndex == 6)
                {
                    btnValidar.Text = cls37652_PIS.Validar(txtValidar.Text) ? "Válido" : "Inválido";
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Erro inesperado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValidar.Clear();
                txtValidar.Focus();
                lblValidacao.Text = "Validações";
                cmbSelecao.Text = "Selecione a validação";
                return;
            }
        }
        private void cmbSelecao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSelecao.SelectedIndex == 0)
                {
                    txtValidar.MaxLength = 16;
                    lblValidacao.Text = "Cartão de crédito";
                    txtValidar.Focus();
                    return;
                }
                if (cmbSelecao.SelectedIndex == 1)
                {
                    txtValidar.MaxLength = 11;
                    lblValidacao.Text = "Validar CNH";
                    txtValidar.Focus();
                    return;
                }
                if (cmbSelecao.SelectedIndex == 2)
                {
                    txtValidar.MaxLength = 11;
                    lblValidacao.Text = "Validar CPF";
                    txtValidar.Focus();
                    return;
                }
                if (cmbSelecao.SelectedIndex == 3)
                {
                    txtValidar.MaxLength = 9;
                    lblValidacao.Text = "Validar RG";
                    txtValidar.Focus();
                    return;
                }
                if (cmbSelecao.SelectedIndex == 4)
                {
                    txtValidar.MaxLength = 14;
                    lblValidacao.Text = "Validar CNPJ";
                    txtValidar.Focus();
                    return;
                }
                if (cmbSelecao.SelectedIndex == 5)
                {
                    txtValidar.MaxLength = 12;
                    lblValidacao.Text = "Validar Titulo";
                    txtValidar.Focus();
                    return;
                }
                if (cmbSelecao.SelectedIndex == 6)
                {
                    txtValidar.MaxLength = 11;
                    lblValidacao.Text = "Validar PIS/PASEP";
                    txtValidar.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Erro inesperado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValidar.Clear();
                txtValidar.Focus();
                lblValidacao.Text = "Validações";
                cmbSelecao.Text = "Selecione a validação";
                return;
            }


        }

        private void txtValidar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
