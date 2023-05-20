namespace PaintQualityCompass.Views
{
    partial class CadastrarProdutoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarProdutoForm));
            buttonCacelar = new Button();
            buttonSalvar = new Button();
            labelTipo = new Label();
            comboBoxTipo = new ComboBox();
            groupBox1 = new GroupBox();
            textBoxCor = new TextBox();
            comboBoxAcabamento = new ComboBox();
            comboBoxLinha = new ComboBox();
            label4 = new Label();
            labelAcabamento = new Label();
            labelLinha = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCacelar
            // 
            resources.ApplyResources(buttonCacelar, "buttonCacelar");
            buttonCacelar.BackColor = Color.FromArgb(165, 55, 55);
            buttonCacelar.Name = "buttonCacelar";
            buttonCacelar.UseVisualStyleBackColor = false;
            buttonCacelar.Click += buttonCacelar_Click;
            // 
            // buttonSalvar
            // 
            resources.ApplyResources(buttonSalvar, "buttonSalvar");
            buttonSalvar.BackColor = Color.FromArgb(88, 140, 199);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // labelTipo
            // 
            resources.ApplyResources(labelTipo, "labelTipo");
            labelTipo.Name = "labelTipo";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.BackColor = Color.FromArgb(119, 141, 169);
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(comboBoxTipo, "comboBoxTipo");
            comboBoxTipo.ForeColor = Color.FromArgb(27, 38, 59);
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.SelectedIndexChanged += comboBoxTipo_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxCor);
            groupBox1.Controls.Add(comboBoxAcabamento);
            groupBox1.Controls.Add(comboBoxLinha);
            groupBox1.Controls.Add(comboBoxTipo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(labelAcabamento);
            groupBox1.Controls.Add(labelLinha);
            groupBox1.Controls.Add(labelTipo);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // textBoxCor
            // 
            resources.ApplyResources(textBoxCor, "textBoxCor");
            textBoxCor.BackColor = Color.FromArgb(119, 141, 169);
            textBoxCor.ForeColor = Color.FromArgb(224, 225, 221);
            textBoxCor.Name = "textBoxCor";
            // 
            // comboBoxAcabamento
            // 
            comboBoxAcabamento.BackColor = Color.FromArgb(119, 141, 169);
            comboBoxAcabamento.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(comboBoxAcabamento, "comboBoxAcabamento");
            comboBoxAcabamento.ForeColor = Color.FromArgb(27, 38, 59);
            comboBoxAcabamento.FormattingEnabled = true;
            comboBoxAcabamento.Name = "comboBoxAcabamento";
            // 
            // comboBoxLinha
            // 
            comboBoxLinha.BackColor = Color.FromArgb(119, 141, 169);
            comboBoxLinha.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(comboBoxLinha, "comboBoxLinha");
            comboBoxLinha.ForeColor = Color.FromArgb(27, 38, 59);
            comboBoxLinha.FormattingEnabled = true;
            comboBoxLinha.Name = "comboBoxLinha";
            comboBoxLinha.SelectedIndexChanged += comboBoxLinha_SelectedIndexChanged;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // labelAcabamento
            // 
            resources.ApplyResources(labelAcabamento, "labelAcabamento");
            labelAcabamento.Name = "labelAcabamento";
            // 
            // labelLinha
            // 
            resources.ApplyResources(labelLinha, "labelLinha");
            labelLinha.Name = "labelLinha";
            // 
            // CadastrarProdutoForm
            // 
            AcceptButton = buttonSalvar;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 38, 59);
            CancelButton = buttonCacelar;
            Controls.Add(buttonSalvar);
            Controls.Add(buttonCacelar);
            Controls.Add(groupBox1);
            ForeColor = Color.FromArgb(225, 224, 221);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastrarProdutoForm";
            SizeGripStyle = SizeGripStyle.Show;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCacelar;
        private Button buttonSalvar;
        private Label labelTipo;
        private ComboBox comboBoxTipo;
        private GroupBox groupBox1;
        private Label labelLinha;
        private ComboBox comboBoxLinha;
        private Label labelAcabamento;
        private ComboBox comboBoxAcabamento;
        private Label label4;
        private TextBox textBoxCor;
    }
}