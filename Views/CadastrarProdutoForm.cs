using Microsoft.Data.Sqlite;
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

namespace PaintQualityCompass.Views
{
    public partial class CadastrarProdutoForm : Form
    {
        private readonly string[] tiposDeProduto = { "", "Tinta Látex", "Tinta a óleo", "Verniz", "Esmalte", "Massa Niveladora" };
        private readonly string[] tiposDeLinha = { "", "Econômica", "Standard", "Premium", "Super Premium", "Interna", "Externa" };
        private readonly string[] tiposDeAcabamento = { "", "Fosco", "Semi-Acetinado", "Acetinado", "Semi-brilho", "Brilhoso" };
        private Controller<Produto> _controller = new();

        public CadastrarProdutoForm()
        {
            InitializeComponent();
            comboBoxTipo.DataSource = tiposDeProduto;
            comboBoxLinha.DataSource = tiposDeLinha;
            comboBoxAcabamento.DataSource = tiposDeAcabamento;
            comboBoxLinha.Enabled = false;
            comboBoxAcabamento.Enabled = false;
        }

        private void buttonCacelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var confirmationBoxResult = MessageBox.Show("Deseja salvar o Produto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmationBoxResult == DialogResult.Yes) 
            {
                try
                {
                    var produtoCriado = new Produto(comboBoxTipo.Text,comboBoxLinha.Text,comboBoxAcabamento.Text,textBoxCor.Text);
                    _controller.Create(produtoCriado);
                    DialogResult = DialogResult.OK;
                }
                catch (SqliteException sqlexception)
                {
                    var errorBoxResult = MessageBox.Show("Problema ao inserir dados no banco, verifique se o produto já foi cadastrado. Deseja verificar os detalhes?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (errorBoxResult == DialogResult.Yes)
                    {
                        MessageBox.Show(sqlexception.Message, "Erro", MessageBoxButtons.OK);
                    }
                }
                catch (Exception exception)
                { 
                    var errorBoxResult = MessageBox.Show("Não foi possível cadastrar o produto. Deseja verificar os detalhes?","Erro",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                    if (errorBoxResult == DialogResult.Yes)
                    {
                        MessageBox.Show(exception.Message, "Erro",MessageBoxButtons.OK);
                    }
                }
            }
            this.Close();
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool linhaEnabled = true;
            bool acabamentoEnabled = true;
            bool corEnabled = true;
            string[] linhas = { "" };
            string[] acabamentos = { "" };
            string cor = "";

            switch (comboBoxTipo.Text)
            {
                case "Tinta Látex":
                    linhas = new string[] { "Econômica", "Standard", "Premium", "Super Premium" };
                    acabamentos = new string[] { "Fosco", "Semi-Acetinado", "Acetinado", "Semi-brilho" };
                    break;
                case "Tinta a óleo":
                    linhas = new string[] { "Standard" };
                    acabamentos = new string[] { "Brilhoso" };
                    break;
                case "Verniz":
                    corEnabled = false;
                    linhas = new string[] { "Interna" };
                    acabamentos = new string[] { "Brilhoso" };
                    cor = "Incolor";
                    break;
                case "Esmalte":
                    linhas = new string[] { "Standard", "Premium" };
                    acabamentos = new string[] { "Brilhoso" };
                    break;
                case "Massa Niveladora":
                    linhas = new string[] { "Interno", "Externo" };
                    break;
                default:
                    break;
            }

            comboBoxLinha.Enabled = linhaEnabled;
            comboBoxAcabamento.Enabled = acabamentoEnabled;
            textBoxCor.Enabled = corEnabled;
            comboBoxLinha.DataSource = linhas;
            comboBoxAcabamento.DataSource = acabamentos;
            textBoxCor.Text = cor;
        }

        private void comboBoxLinha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLinha.Text == "Econômica")
            {
                comboBoxAcabamento.Enabled = false;
                comboBoxAcabamento.Text = "Fosco";
            }
            else
            {
                comboBoxAcabamento.Enabled = true;
            }
        }
    }
}
