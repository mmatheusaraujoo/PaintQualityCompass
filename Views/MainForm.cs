using PaintQualityCompass.Data;
using PaintQualityCompass.Views.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintQualityCompass.Views
{
    public partial class MainForm : Form
    {
        private UserControl? activeUserControl;
        private Button? activeButton;
        private DbContext? _dbContext;

        public MainForm()
        {
            InitializeComponent();

            try { _dbContext = new DbContext(); } 
            catch (Exception e) 
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.Close();
            }
            LoadFormInPanel(new UserControlInicio());
            SetActiveButton(this.buttonInicio);
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender);
            LoadFormInPanel(new UserControlInicio());
        }
        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender);
            LoadFormInPanel(new UserControlProdutos());
        }

        private void buttonAnalises_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender);
            LoadFormInPanel(new UserControlAnalises());
        }

        private void buttonRelatorios_Click(object sender, EventArgs e)
        {

           SetActiveButton(sender);

            LoadFormInPanel(new UserControlRelatorios());
        }
        private void buttonConfiguracoes_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender);
            LoadFormInPanel(new UserControlConfiguracoes());
        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadFormInPanel(UserControl userControl)
        {
            DisposeCurrentPanel();
            this.panelContent.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
            userControl.Show();
            activeUserControl = userControl;

        }

        private void SetActiveButton(object sender)
        {
            if(sender is Button button)
            {
                if (this.activeButton == null) { this.activeButton = buttonInicio; }
                this.activeButton.BackColor = Color.FromArgb(27, 38, 59);
                button.BackColor = Color.FromArgb(119, 141, 169);
                this.activeButton = button;
            }
        }

        private void DisposeCurrentPanel()
        {
            if (activeUserControl != null)
            {
                activeUserControl.Dispose();
            }
        }

        
    }
}
