namespace PaintQualityCompass.Views.Components
{
    partial class UserControlAnalises
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTitle = new Panel();
            labelTitle = new Label();
            panelContent = new Panel();
            dataGridView1 = new DataGridView();
            buttonCadastrarNovaAnalise = new Button();
            panelTitle.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(labelTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(994, 120);
            panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.FromArgb(13, 27, 42);
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(994, 120);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Análises";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(dataGridView1);
            panelContent.Controls.Add(buttonCadastrarNovaAnalise);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 120);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(994, 591);
            panelContent.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(716, 438);
            dataGridView1.TabIndex = 2;
            // 
            // buttonCadastrarNovaAnalise
            // 
            buttonCadastrarNovaAnalise.BackColor = Color.FromArgb(13, 27, 42);
            buttonCadastrarNovaAnalise.FlatStyle = FlatStyle.Flat;
            buttonCadastrarNovaAnalise.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCadastrarNovaAnalise.Location = new Point(33, 36);
            buttonCadastrarNovaAnalise.Name = "buttonCadastrarNovaAnalise";
            buttonCadastrarNovaAnalise.Size = new Size(180, 90);
            buttonCadastrarNovaAnalise.TabIndex = 1;
            buttonCadastrarNovaAnalise.Text = "Cadastrar Nova Análise";
            buttonCadastrarNovaAnalise.UseVisualStyleBackColor = false;
            buttonCadastrarNovaAnalise.Click += buttonCadastrarNovaAnalise_Click;
            // 
            // UserControlAnalises
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(65, 90, 119);
            Controls.Add(panelContent);
            Controls.Add(panelTitle);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(224, 225, 221);
            Name = "UserControlAnalises";
            Size = new Size(994, 711);
            panelTitle.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private Label labelTitle;
        private Panel panelContent;
        private DataGridView dataGridView1;
        private Button buttonCadastrarNovaAnalise;
    }
}
