using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintQualityCompass.Views.Components
{
    public partial class UserControlConfiguracoes : UserControl
    {
        public UserControlConfiguracoes()
        {
            InitializeComponent();
        }

        private void UserControlConfiguracoes_Load(object sender, EventArgs e)
        {

            string pastaProjeto = Path.GetDirectoryName(Application.ExecutablePath)!;
            string pastaDoArquivo = "Data";
            string nomeDoArquivo = "Database.db";

            string caminhoArquivo = Path.Combine(pastaProjeto, pastaDoArquivo, nomeDoArquivo);

            var sb = new StringBuilder();
            sb.Append(@"Data Source=");
            sb.Append(caminhoArquivo);
            sb.Append(";");

            var connectionString = sb.ToString();
            textBoxDbPath.Text = connectionString;
        }
    }
}
