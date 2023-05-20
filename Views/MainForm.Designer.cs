namespace PaintQualityCompass.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelSelecao = new Panel();
            buttonConfiguracoes = new Button();
            buttonRelatorios = new Button();
            buttonAnalises = new Button();
            buttonProdutos = new Button();
            buttonInicio = new Button();
            panelLogo = new Panel();
            labelTitle = new Label();
            pictureBoxLogo = new PictureBox();
            buttonSair = new Button();
            panelContent = new Panel();
            panelSelecao.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelSelecao
            // 
            panelSelecao.BackColor = Color.FromArgb(13, 27, 42);
            panelSelecao.Controls.Add(buttonConfiguracoes);
            panelSelecao.Controls.Add(buttonRelatorios);
            panelSelecao.Controls.Add(buttonAnalises);
            panelSelecao.Controls.Add(buttonProdutos);
            panelSelecao.Controls.Add(buttonInicio);
            panelSelecao.Controls.Add(panelLogo);
            panelSelecao.Controls.Add(buttonSair);
            panelSelecao.Dock = DockStyle.Left;
            panelSelecao.Location = new Point(0, 0);
            panelSelecao.Name = "panelSelecao";
            panelSelecao.Size = new Size(270, 711);
            panelSelecao.TabIndex = 0;
            // 
            // buttonConfiguracoes
            // 
            buttonConfiguracoes.BackColor = Color.FromArgb(27, 38, 59);
            buttonConfiguracoes.Cursor = Cursors.Hand;
            buttonConfiguracoes.Dock = DockStyle.Top;
            buttonConfiguracoes.FlatAppearance.BorderColor = Color.FromArgb(13, 27, 42);
            buttonConfiguracoes.FlatAppearance.BorderSize = 0;
            buttonConfiguracoes.FlatAppearance.MouseDownBackColor = Color.FromArgb(119, 141, 169);
            buttonConfiguracoes.FlatAppearance.MouseOverBackColor = Color.FromArgb(88, 140, 199);
            buttonConfiguracoes.FlatStyle = FlatStyle.Flat;
            buttonConfiguracoes.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConfiguracoes.ForeColor = Color.FromArgb(224, 225, 221);
            buttonConfiguracoes.Image = (Image)resources.GetObject("buttonConfiguracoes.Image");
            buttonConfiguracoes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConfiguracoes.ImeMode = ImeMode.NoControl;
            buttonConfiguracoes.Location = new Point(0, 440);
            buttonConfiguracoes.Name = "buttonConfiguracoes";
            buttonConfiguracoes.Padding = new Padding(10, 0, 0, 0);
            buttonConfiguracoes.Size = new Size(270, 80);
            buttonConfiguracoes.TabIndex = 6;
            buttonConfiguracoes.Text = "   Configurações";
            buttonConfiguracoes.TextAlign = ContentAlignment.MiddleLeft;
            buttonConfiguracoes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonConfiguracoes.UseVisualStyleBackColor = false;
            buttonConfiguracoes.Click += buttonConfiguracoes_Click;
            // 
            // buttonRelatorios
            // 
            buttonRelatorios.BackColor = Color.FromArgb(27, 38, 59);
            buttonRelatorios.Cursor = Cursors.Hand;
            buttonRelatorios.Dock = DockStyle.Top;
            buttonRelatorios.FlatAppearance.BorderColor = Color.FromArgb(13, 27, 42);
            buttonRelatorios.FlatAppearance.BorderSize = 0;
            buttonRelatorios.FlatAppearance.MouseDownBackColor = Color.FromArgb(119, 141, 169);
            buttonRelatorios.FlatAppearance.MouseOverBackColor = Color.FromArgb(88, 140, 199);
            buttonRelatorios.FlatStyle = FlatStyle.Flat;
            buttonRelatorios.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRelatorios.ForeColor = Color.FromArgb(224, 225, 221);
            buttonRelatorios.Image = (Image)resources.GetObject("buttonRelatorios.Image");
            buttonRelatorios.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRelatorios.ImeMode = ImeMode.NoControl;
            buttonRelatorios.Location = new Point(0, 360);
            buttonRelatorios.Name = "buttonRelatorios";
            buttonRelatorios.Padding = new Padding(10, 0, 0, 0);
            buttonRelatorios.Size = new Size(270, 80);
            buttonRelatorios.TabIndex = 5;
            buttonRelatorios.Text = "   Relatórios";
            buttonRelatorios.TextAlign = ContentAlignment.MiddleLeft;
            buttonRelatorios.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRelatorios.UseVisualStyleBackColor = false;
            buttonRelatorios.Click += buttonRelatorios_Click;
            // 
            // buttonAnalises
            // 
            buttonAnalises.BackColor = Color.FromArgb(27, 38, 59);
            buttonAnalises.Cursor = Cursors.Hand;
            buttonAnalises.Dock = DockStyle.Top;
            buttonAnalises.FlatAppearance.BorderColor = Color.FromArgb(13, 27, 42);
            buttonAnalises.FlatAppearance.BorderSize = 0;
            buttonAnalises.FlatAppearance.MouseDownBackColor = Color.FromArgb(119, 141, 169);
            buttonAnalises.FlatAppearance.MouseOverBackColor = Color.FromArgb(88, 140, 199);
            buttonAnalises.FlatStyle = FlatStyle.Flat;
            buttonAnalises.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAnalises.ForeColor = Color.FromArgb(224, 225, 221);
            buttonAnalises.Image = (Image)resources.GetObject("buttonAnalises.Image");
            buttonAnalises.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAnalises.ImeMode = ImeMode.NoControl;
            buttonAnalises.Location = new Point(0, 280);
            buttonAnalises.Name = "buttonAnalises";
            buttonAnalises.Padding = new Padding(10, 0, 0, 0);
            buttonAnalises.Size = new Size(270, 80);
            buttonAnalises.TabIndex = 4;
            buttonAnalises.Text = "   Análises";
            buttonAnalises.TextAlign = ContentAlignment.MiddleLeft;
            buttonAnalises.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAnalises.UseVisualStyleBackColor = false;
            buttonAnalises.Click += buttonAnalises_Click;
            // 
            // buttonProdutos
            // 
            buttonProdutos.BackColor = Color.FromArgb(27, 38, 59);
            buttonProdutos.BackgroundImageLayout = ImageLayout.Zoom;
            buttonProdutos.Cursor = Cursors.Hand;
            buttonProdutos.Dock = DockStyle.Top;
            buttonProdutos.FlatAppearance.BorderColor = Color.FromArgb(13, 27, 42);
            buttonProdutos.FlatAppearance.BorderSize = 0;
            buttonProdutos.FlatAppearance.MouseDownBackColor = Color.FromArgb(119, 141, 169);
            buttonProdutos.FlatAppearance.MouseOverBackColor = Color.FromArgb(88, 140, 199);
            buttonProdutos.FlatStyle = FlatStyle.Flat;
            buttonProdutos.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProdutos.ForeColor = Color.FromArgb(224, 225, 221);
            buttonProdutos.Image = (Image)resources.GetObject("buttonProdutos.Image");
            buttonProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProdutos.ImeMode = ImeMode.NoControl;
            buttonProdutos.Location = new Point(0, 200);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Padding = new Padding(10, 0, 0, 0);
            buttonProdutos.Size = new Size(270, 80);
            buttonProdutos.TabIndex = 3;
            buttonProdutos.Text = "   Produtos";
            buttonProdutos.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProdutos.UseVisualStyleBackColor = false;
            buttonProdutos.Click += buttonProdutos_Click;
            // 
            // buttonInicio
            // 
            buttonInicio.BackColor = Color.FromArgb(27, 38, 59);
            buttonInicio.BackgroundImageLayout = ImageLayout.Zoom;
            buttonInicio.Cursor = Cursors.Hand;
            buttonInicio.Dock = DockStyle.Top;
            buttonInicio.FlatAppearance.BorderColor = Color.FromArgb(13, 27, 42);
            buttonInicio.FlatAppearance.BorderSize = 0;
            buttonInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(119, 141, 169);
            buttonInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(88, 140, 199);
            buttonInicio.FlatStyle = FlatStyle.Flat;
            buttonInicio.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInicio.ForeColor = Color.FromArgb(224, 225, 221);
            buttonInicio.Image = (Image)resources.GetObject("buttonInicio.Image");
            buttonInicio.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInicio.ImeMode = ImeMode.NoControl;
            buttonInicio.Location = new Point(0, 120);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Padding = new Padding(10, 0, 0, 0);
            buttonInicio.Size = new Size(270, 80);
            buttonInicio.TabIndex = 2;
            buttonInicio.Text = "   Inicio";
            buttonInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonInicio.UseVisualStyleBackColor = false;
            buttonInicio.Click += buttonInicio_Click;
            // 
            // panelLogo
            // 
            panelLogo.AutoScroll = true;
            panelLogo.Controls.Add(labelTitle);
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(270, 120);
            panelLogo.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(224, 225, 221);
            labelTitle.Location = new Point(12, 28);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(171, 75);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "PQC";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImage = (Image)resources.GetObject("pictureBoxLogo.BackgroundImage");
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Location = new Point(189, 28);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(64, 64);
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.FromArgb(27, 38, 59);
            buttonSair.Cursor = Cursors.Hand;
            buttonSair.Dock = DockStyle.Bottom;
            buttonSair.FlatAppearance.BorderSize = 0;
            buttonSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(119, 141, 169);
            buttonSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(165, 55, 55);
            buttonSair.FlatStyle = FlatStyle.Flat;
            buttonSair.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSair.ForeColor = Color.FromArgb(224, 225, 221);
            buttonSair.ImeMode = ImeMode.NoControl;
            buttonSair.Location = new Point(0, 631);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(270, 80);
            buttonSair.TabIndex = 8;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(270, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(994, 711);
            panelContent.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 90, 119);
            ClientSize = new Size(1264, 711);
            Controls.Add(panelContent);
            Controls.Add(panelSelecao);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Paint Quality Compass";
            TransparencyKey = Color.White;
            panelSelecao.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSelecao;
        private Button buttonSair;
        private Button buttonInicio;
        private Button buttonRelatorios;
        private Button buttonAnalises;
        private Panel panelLogo;
        private PictureBox pictureBoxLogo;
        private Label labelTitle;
        private Panel panelContent;
        private Button buttonConfiguracoes;
        private Button buttonProdutos;
    }
}