namespace DemoConcurrencia
{
    partial class FrmRastreoDeTareas
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
            splitContainer1 = new SplitContainer();
            lblContador1 = new Label();
            btnDisminuir = new Button();
            btnIncrementar = new Button();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(255, 128, 0);
            splitContainer1.Panel1.Controls.Add(lblContador1);
            splitContainer1.Panel1.Controls.Add(btnDisminuir);
            splitContainer1.Panel1.Controls.Add(btnIncrementar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(685, 324);
            splitContainer1.SplitterDistance = 228;
            splitContainer1.TabIndex = 0;
            // 
            // lblContador1
            // 
            lblContador1.AutoSize = true;
            lblContador1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContador1.Location = new Point(68, 190);
            lblContador1.Name = "lblContador1";
            lblContador1.Size = new Size(72, 86);
            lblContador1.TabIndex = 2;
            lblContador1.Text = "0";
            // 
            // btnDisminuir
            // 
            btnDisminuir.BackColor = Color.FromArgb(128, 255, 255);
            btnDisminuir.Location = new Point(68, 113);
            btnDisminuir.Name = "btnDisminuir";
            btnDisminuir.Size = new Size(83, 23);
            btnDisminuir.TabIndex = 1;
            btnDisminuir.Text = "Disminuir";
            btnDisminuir.UseVisualStyleBackColor = false;
            // 
            // btnIncrementar
            // 
            btnIncrementar.BackColor = Color.Lime;
            btnIncrementar.Location = new Point(68, 66);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(83, 23);
            btnIncrementar.TabIndex = 0;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = false;
            // 
            // TxtResultado
            // 
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(453, 324);
            TxtResultado.TabIndex = 2;
            // 
            // FrmRastreoDeTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 324);
            Controls.Add(splitContainer1);
            Name = "FrmRastreoDeTareas";
            Text = "RastreoDeTareas";

            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnDisminuir;
        private Button btnIncrementar;
        private Label lblContador1;
        private TextBox TxtResultado;
        private Button btnReset;
    }
}