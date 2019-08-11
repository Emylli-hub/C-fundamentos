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
            dgvPessoas.Rows.Clear();
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas = ps.Ler();
            foreach (var item in pessoas)
            {
                string[] row = new string[3];
                row[0] = item.Id.ToString();
                row[1] = item.Nome;
                row[2] = item.Contato.NumeroTelefone;

                dgvPessoas.Rows.Add(row);
            }


            if (dgvPessoas.Columns.Count==3)
            {
                dgvPessoas.Columns.Add( addBntExluir() );
            }
        }

        private DataGridViewButtonColumn addBntExluir()
        {
            DataGridViewButtonColumn colBtn = new DataGridViewButtonColumn();
            colBtn.HeaderText = "";
            colBtn.Text = "Excluir";
            colBtn.Name = "btnExcluir";
            colBtn.UseColumnTextForButtonValue = true;
            return colBtn;
        }

        private void DgvPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.ColumnIndex;
            if ( index==3 )
            {
                
                int indexLinha = e.RowIndex;
                int id = Convert.ToInt32(dgvPessoas.Rows[indexLinha].Cells[0].Value);
                ps.Deletar(id);
                CarregaPessoa();
            }
        }
    }
}
