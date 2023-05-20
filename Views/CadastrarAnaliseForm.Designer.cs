namespace PaintQualityCompass.Views
{
    partial class CadastrarAnaliseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarAnaliseForm));
            groupBoxAnalise = new GroupBox();
            comboBoxNorma = new ComboBox();
            labelNorma = new Label();
            maskedTextBoxDatadaAnalise = new MaskedTextBox();
            textBoxDescricao = new TextBox();
            labelDataDaAnalise = new Label();
            labelDescricao = new Label();
            textBoxAnalista = new TextBox();
            labelAnalista = new Label();
            labelDataDeFabricacao = new Label();
            textBoxLote = new TextBox();
            labelLote = new Label();
            groupBoxProduto = new GroupBox();
            label2 = new Label();
            checkBoxLoteTeste = new CheckBox();
            maskedTextBoxDataDeFabricacao = new MaskedTextBox();
            buttonSalvar = new Button();
            buttonCacelar = new Button();
            dataGridViewEnsaios = new DataGridView();
            groupBoxAnalise.SuspendLayout();
            groupBoxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnsaios).BeginInit();
            SuspendLayout();
            // 
            // groupBoxAnalise
            // 
            resources.ApplyResources(groupBoxAnalise, "groupBoxAnalise");
            groupBoxAnalise.BackColor = Color.Transparent;
            groupBoxAnalise.Controls.Add(comboBoxNorma);
            groupBoxAnalise.Controls.Add(labelNorma);
            groupBoxAnalise.Controls.Add(maskedTextBoxDatadaAnalise);
            groupBoxAnalise.Controls.Add(textBoxDescricao);
            groupBoxAnalise.Controls.Add(labelDataDaAnalise);
            groupBoxAnalise.Controls.Add(labelDescricao);
            groupBoxAnalise.Controls.Add(textBoxAnalista);
            groupBoxAnalise.Controls.Add(labelAnalista);
            groupBoxAnalise.FlatStyle = FlatStyle.Flat;
            groupBoxAnalise.Name = "groupBoxAnalise";
            groupBoxAnalise.TabStop = false;
            // 
            // comboBoxNorma
            // 
            comboBoxNorma.BackColor = Color.FromArgb(119, 141, 169);
            resources.ApplyResources(comboBoxNorma, "comboBoxNorma");
            comboBoxNorma.ForeColor = Color.FromArgb(224, 225, 221);
            comboBoxNorma.FormattingEnabled = true;
            comboBoxNorma.Name = "comboBoxNorma";
            // 
            // labelNorma
            // 
            resources.ApplyResources(labelNorma, "labelNorma");
            labelNorma.Name = "labelNorma";
            // 
            // maskedTextBoxDatadaAnalise
            // 
            resources.ApplyResources(maskedTextBoxDatadaAnalise, "maskedTextBoxDatadaAnalise");
            maskedTextBoxDatadaAnalise.BackColor = Color.FromArgb(119, 141, 169);
            maskedTextBoxDatadaAnalise.ForeColor = Color.FromArgb(224, 225, 221);
            maskedTextBoxDatadaAnalise.Name = "maskedTextBoxDatadaAnalise";
            maskedTextBoxDatadaAnalise.ValidatingType = typeof(DateTime);
            // 
            // textBoxDescricao
            // 
            resources.ApplyResources(textBoxDescricao, "textBoxDescricao");
            textBoxDescricao.BackColor = Color.FromArgb(119, 141, 169);
            textBoxDescricao.ForeColor = Color.FromArgb(224, 225, 221);
            textBoxDescricao.Name = "textBoxDescricao";
            // 
            // labelDataDaAnalise
            // 
            resources.ApplyResources(labelDataDaAnalise, "labelDataDaAnalise");
            labelDataDaAnalise.Name = "labelDataDaAnalise";
            labelDataDaAnalise.Click += labelDataDaAnalise_Click;
            // 
            // labelDescricao
            // 
            resources.ApplyResources(labelDescricao, "labelDescricao");
            labelDescricao.Name = "labelDescricao";
            // 
            // textBoxAnalista
            // 
            resources.ApplyResources(textBoxAnalista, "textBoxAnalista");
            textBoxAnalista.BackColor = Color.FromArgb(119, 141, 169);
            textBoxAnalista.ForeColor = Color.FromArgb(224, 225, 221);
            textBoxAnalista.Name = "textBoxAnalista";
            // 
            // labelAnalista
            // 
            resources.ApplyResources(labelAnalista, "labelAnalista");
            labelAnalista.Name = "labelAnalista";
            // 
            // labelDataDeFabricacao
            // 
            resources.ApplyResources(labelDataDeFabricacao, "labelDataDeFabricacao");
            labelDataDeFabricacao.Name = "labelDataDeFabricacao";
            // 
            // textBoxLote
            // 
            textBoxLote.BackColor = Color.FromArgb(119, 141, 169);
            resources.ApplyResources(textBoxLote, "textBoxLote");
            textBoxLote.ForeColor = Color.FromArgb(224, 225, 221);
            textBoxLote.Name = "textBoxLote";
            // 
            // labelLote
            // 
            resources.ApplyResources(labelLote, "labelLote");
            labelLote.Name = "labelLote";
            // 
            // groupBoxProduto
            // 
            resources.ApplyResources(groupBoxProduto, "groupBoxProduto");
            groupBoxProduto.BackColor = Color.Transparent;
            groupBoxProduto.Controls.Add(label2);
            groupBoxProduto.Controls.Add(checkBoxLoteTeste);
            groupBoxProduto.Controls.Add(labelLote);
            groupBoxProduto.Controls.Add(maskedTextBoxDataDeFabricacao);
            groupBoxProduto.Controls.Add(textBoxLote);
            groupBoxProduto.Controls.Add(labelDataDeFabricacao);
            groupBoxProduto.Name = "groupBoxProduto";
            groupBoxProduto.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Red;
            label2.Name = "label2";
            // 
            // checkBoxLoteTeste
            // 
            resources.ApplyResources(checkBoxLoteTeste, "checkBoxLoteTeste");
            checkBoxLoteTeste.Name = "checkBoxLoteTeste";
            checkBoxLoteTeste.UseVisualStyleBackColor = true;
            checkBoxLoteTeste.CheckedChanged += checkBoxLoteTeste_CheckedChanged;
            // 
            // maskedTextBoxDataDeFabricacao
            // 
            maskedTextBoxDataDeFabricacao.BackColor = Color.FromArgb(119, 141, 169);
            resources.ApplyResources(maskedTextBoxDataDeFabricacao, "maskedTextBoxDataDeFabricacao");
            maskedTextBoxDataDeFabricacao.ForeColor = Color.FromArgb(224, 225, 221);
            maskedTextBoxDataDeFabricacao.Name = "maskedTextBoxDataDeFabricacao";
            maskedTextBoxDataDeFabricacao.ValidatingType = typeof(DateTime);
            maskedTextBoxDataDeFabricacao.MaskInputRejected += maskedTextBoxDataDeFabricacao_MaskInputRejected;
            // 
            // buttonSalvar
            // 
            resources.ApplyResources(buttonSalvar, "buttonSalvar");
            buttonSalvar.BackColor = Color.FromArgb(88, 140, 199);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonCacelar
            // 
            resources.ApplyResources(buttonCacelar, "buttonCacelar");
            buttonCacelar.BackColor = Color.FromArgb(165, 55, 55);
            buttonCacelar.Name = "buttonCacelar";
            buttonCacelar.UseVisualStyleBackColor = false;
            buttonCacelar.Click += buttonCacelar_Click;
            // 
            // dataGridViewEnsaios
            // 
            dataGridViewEnsaios.AllowUserToAddRows = false;
            dataGridViewEnsaios.AllowUserToDeleteRows = false;
            dataGridViewEnsaios.BackgroundColor = Color.FromArgb(119, 141, 169);
            dataGridViewEnsaios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEnsaios.GridColor = Color.White;
            resources.ApplyResources(dataGridViewEnsaios, "dataGridViewEnsaios");
            dataGridViewEnsaios.Name = "dataGridViewEnsaios";
            dataGridViewEnsaios.RowTemplate.Height = 25;
            // 
            // CadastrarAnaliseForm
            // 
            AcceptButton = buttonSalvar;
            AutoScaleMode = AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            BackColor = Color.FromArgb(27, 38, 59);
            CancelButton = buttonSalvar;
            Controls.Add(dataGridViewEnsaios);
            Controls.Add(buttonCacelar);
            Controls.Add(buttonSalvar);
            Controls.Add(groupBoxProduto);
            Controls.Add(groupBoxAnalise);
            ForeColor = Color.FromArgb(224, 225, 221);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CadastrarAnaliseForm";
            TopMost = true;
            groupBoxAnalise.ResumeLayout(false);
            groupBoxAnalise.PerformLayout();
            groupBoxProduto.ResumeLayout(false);
            groupBoxProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnsaios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAnalise;
        private Label labelDataDaAnalise;
        private TextBox textBoxAnalista;
        private Label labelAnalista;
        private TextBox textBoxDescricao;
        private Label labelDescricao;
        private ComboBox comboBoxNorma;
        private Label labelNorma;
        private MaskedTextBox maskedTextBoxDatadaAnalise;
        private Label labelDataDeFabricacao;
        private TextBox textBoxLote;
        private Label labelLote;
        private CheckBox checkBoxLoteTeste;
        private MaskedTextBox maskedTextBoxDataDeFabricacao;
        private Button buttonSalvar;
        private Button buttonCacelar;
        private Label label2;
        internal protected GroupBox groupBoxProduto;
        private DataGridView dataGridViewEnsaios;
    }
}