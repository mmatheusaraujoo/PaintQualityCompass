namespace PaintQualityCompass.Views.Components
{
    partial class UserControlRelatorios
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
            panel1 = new Panel();
            labelTitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 27, 42);
            panel1.Controls.Add(labelTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 120);
            panel1.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(994, 120);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Relatórios";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserControlRelatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 90, 119);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(224, 224, 221);
            Name = "UserControlRelatorios";
            Size = new Size(994, 711);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelTitle;
    }
}
