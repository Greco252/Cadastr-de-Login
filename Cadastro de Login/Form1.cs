using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtNome.Text = "";
            TxtSobrenome.Text = "";
            txtEmail.Text = "";
            mskNascimento.Text = "";
            TxtSenha.Text = "";
            mskCelular.Text = "";
            txtRep.Text = "";
            cmbGenêro.Text = "";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string nome = TxtNome.Text;
            string sobrenome = TxtSobrenome.Text;
            string email = txtEmail.Text;
            string data = mskNascimento.Text;
            string celular = mskCelular.Text;
            string senha = TxtSenha.Text;
            string repetir = txtRep.Text;
            string genero = cmbGenêro.Text;

            MessageBox.Show("Nome: " + nome +
                            ", Sobrenome: " + sobrenome +
                            ", E-mail: " + email +
                            ", Data de Nascimento: " + data +
                            ", Celular: " + celular+
                            ", Genêro: " + genero +
                            ", Senha: " + senha);
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
