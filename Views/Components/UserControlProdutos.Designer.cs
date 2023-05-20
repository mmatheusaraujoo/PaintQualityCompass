namespace PaintQualityCompass.Views.Components
{
    partial class UserControlProdutos
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            labelTitle = new Label();
            buttonCadastrarNovoProduto = new Button();
            produtoBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            buttonApagar = new Button();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.FromArgb(13, 27, 42);
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(994, 120);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Produtos";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCadastrarNovoProduto
            // 
            buttonCadastrarNovoProduto.BackColor = Color.FromArgb(13, 27, 42);
            buttonCadastrarNovoProduto.FlatStyle = FlatStyle.Flat;
            buttonCadastrarNovoProduto.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCadastrarNovoProduto.Location = new Point(3, 152);
            buttonCadastrarNovoProduto.Name = "buttonCadastrarNovoProduto";
            buttonCadastrarNovoProduto.Size = new Size(200, 90);
            buttonCadastrarNovoProduto.TabIndex = 2;
            buttonCadastrarNovoProduto.Text = "Cadastrar Novo Produto";
            buttonCadastrarNovoProduto.UseVisualStyleBackColor = false;
            buttonCadastrarNovoProduto.Click += buttonCadastrarNovoProduto_Click;
            // 
            // produtoBindingSource
            // 
            produtoBindingSource.DataSource = typeof(Models.Produto);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(119, 141, 169);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(225, 224, 221);
            dataGridViewCellStyle1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(13, 27, 42);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(225, 224, 221);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(13, 27, 42);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 27, 42);
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 225, 221);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(119, 141, 169);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(13, 27, 41);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(209, 152);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(225, 224, 221);
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(13, 27, 42);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(225, 224, 221);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(13, 27, 42);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(774, 546);
            dataGridView1.TabIndex = 3;
            // 
            // buttonApagar
            // 
            buttonApagar.BackColor = Color.FromArgb(165, 55, 55);
            buttonApagar.FlatStyle = FlatStyle.Flat;
            buttonApagar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonApagar.Location = new Point(2, 248);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(200, 59);
            buttonApagar.TabIndex = 4;
            buttonApagar.Text = "Apagar Produto";
            buttonApagar.UseVisualStyleBackColor = false;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // UserControlProdutos
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 90, 119);
            Controls.Add(buttonApagar);
            Controls.Add(dataGridView1);
            Controls.Add(buttonCadastrarNovoProduto);
            Controls.Add(labelTitle);
            DoubleBuffered = true;
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(224, 225, 221);
            Margin = new Padding(4);
            Name = "UserControlProdutos";
            Size = new Size(994, 711);
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Button buttonCadastrarNovoProduto;
        private BindingSource produtoBindingSource;
        private DataGridView dataGridView1;
        private Button buttonApagar;
    }
}
