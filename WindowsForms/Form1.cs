using Dominio;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        Pessoa p = new Pessoa();
        PessoaService ps = new PessoaService();
        public Form1()
        {
            InitializeComponent();
            CarregaPessoa();
        }



        private void BntLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void BntSalvar_Click(object sender, EventArgs e)
        {
            p.Nome = txtNome.Text;
            p.Contato.NumeroTelefone = txbTelefone.Text;
            ps.Gravar(p);
            Limpar();
            CarregaPessoa();
        }
        private void Limpar()
        {
            txtNome.Text = string.Empty;
            txbTelefone.Text = string.Empty;
        }
        private void CarregaPessoa()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas = ps.Ler();
            foreach (var item in pessoas)
            {
                DataGridViewRow row = new DataGridViewRow();
                dgvPessoas.Rows.Add();
            }
        }
    }
}
