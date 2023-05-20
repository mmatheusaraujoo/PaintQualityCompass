using PaintQualityCompass.Controllers;
using PaintQualityCompass.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintQualityCompass.Views.Components
{
    public partial class UserControlProdutos : UserControl
    {
        private Controller<Produto> _controller;
        private List<Produto> _produtos = new List<Produto>();
        public UserControlProdutos()
        {
            InitializeComponent();
            _controller = new Controller<Produto>();
            AtualizarDataGridViewProdutos();

        }

        private void buttonCadastrarNovoProduto_Click(object sender, EventArgs e)
        {
            var cadastroForm = new CadastrarProdutoForm();
            var result = cadastroForm.ShowDialog();
            if (result == DialogResult.OK) { MessageBox.Show("Produto salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            cadastroForm.Dispose();
            AtualizarDataGridViewProdutos();
        }

        private void AtualizarDataGridViewProdutos()
        {
            _produtos = _controller.GetAll().ToList();
            dataGridView1.DataSource = _produtos;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            try
            {
                int id = (int)linhaSelecionada.Cells["Id"].Value;
                _controller.Delete(id);
                MessageBox.Show("Produto apagado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarDataGridViewProdutos();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível apagar o produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
