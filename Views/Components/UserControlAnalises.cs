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
    public partial class UserControlAnalises : UserControl
    {
        public UserControlAnalises()
        {
            InitializeComponent();
        }

        private void buttonCadastrarNovaAnalise_Click(object sender, EventArgs e)
        {
            var cadastroForm = new CadastrarAnaliseForm();
            var result = cadastroForm.ShowDialog();
            if (result == DialogResult.OK) { }
            cadastroForm.Dispose();
        }
    }
}
