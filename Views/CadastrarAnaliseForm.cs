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
    public partial class CadastrarAnaliseForm : Form
    {
        public CadastrarAnaliseForm()
        {
            InitializeComponent();
        }

        private void checkBoxLoteTeste_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxLoteTeste.Checked)
            {
                textBoxLote.Text = "";
                textBoxLote.ReadOnly = true;
                textBoxLote.Enabled = false;
                textBoxLote.BackColor = Color.FromArgb(224, 225, 221);
            }
            else
            {
                textBoxLote.ReadOnly = false;
                textBoxLote.Enabled = true;
                textBoxLote.BackColor = Color.FromArgb(119, 141, 169);
            }
        }

        private void buttonCacelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelDataDaAnalise_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxDataDeFabricacao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var messageBoxResult = MessageBox.Show("Deseja salvar a análise?","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (messageBoxResult == DialogResult.Yes) { DialogResult = DialogResult.OK; }
        }
    }
}
