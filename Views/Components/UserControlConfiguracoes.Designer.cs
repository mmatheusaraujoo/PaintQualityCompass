namespace PaintQualityCompass.Views.Components
{
    partial class UserControlConfiguracoes
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
            labelCaminhoDoBanco = new Label();
            textBoxDbPath = new TextBox();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(13, 27, 42);
            panelTitle.Controls.Add(labelTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(994, 120);
            panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(994, 120);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Configurações";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCaminhoDoBanco
            // 
            labelCaminhoDoBanco.AutoSize = true;
            labelCaminhoDoBanco.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelCaminhoDoBanco.Location = new Point(148, 214);
            labelCaminhoDoBanco.Name = "labelCaminhoDoBanco";
            labelCaminhoDoBanco.Size = new Size(85, 24);
            labelCaminhoDoBanco.TabIndex = 1;
            labelCaminhoDoBanco.Text = "DbPath:";
            // 
            // textBoxDbPath
            // 
            textBoxDbPath.BackColor = SystemColors.InactiveBorder;
            textBoxDbPath.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDbPath.Location = new Point(239, 211);
            textBoxDbPath.Name = "textBoxDbPath";
            textBoxDbPath.Size = new Size(523, 29);
            textBoxDbPath.TabIndex = 2;
            // 
            // UserControlConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 90, 119);
            Controls.Add(textBoxDbPath);
            Controls.Add(labelCaminhoDoBanco);
            Controls.Add(panelTitle);
            ForeColor = Color.FromArgb(224, 224, 221);
            Name = "UserControlConfiguracoes";
            Size = new Size(994, 711);
            Load += UserControlConfiguracoes_Load;
            panelTitle.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTitle;
        private Label labelTitle;
        private Label labelCaminhoDoBanco;
        private TextBox textBoxDbPath;
    }
}
