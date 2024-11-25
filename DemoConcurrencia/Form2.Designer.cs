namespace DemoConcurrencia
{
    partial class FrmBloqueos
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
            btnIncrementar = new Button();
            LblContador = new Label();
            btnDisminuir = new Button();
            splitContainer1 = new SplitContainer();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIncrementar
            // 
            btnIncrementar.BackColor = Color.FromArgb(255, 128, 0);
            btnIncrementar.Cursor = Cursors.AppStarting;
            btnIncrementar.FlatAppearance.BorderSize = 0;
            btnIncrementar.FlatStyle = FlatStyle.Flat;
            btnIncrementar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncrementar.ForeColor = Color.White;
            btnIncrementar.Location = new Point(32, 30);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(99, 23);
            btnIncrementar.TabIndex = 0;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = false;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // LblContador
            // 
            LblContador.AutoSize = true;
            LblContador.BackColor = Color.FromArgb(0, 0, 64);
            LblContador.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblContador.ForeColor = Color.WhiteSmoke;
            LblContador.Location = new Point(41, 168);
            LblContador.Name = "LblContador";
            LblContador.Size = new Size(74, 86);
            LblContador.TabIndex = 1;
            LblContador.Text = "0";
       
            // 
            // btnDisminuir
            // 
            btnDisminuir.BackColor = Color.FromArgb(255, 128, 0);
            btnDisminuir.Cursor = Cursors.AppStarting;
            btnDisminuir.FlatAppearance.BorderSize = 0;
            btnDisminuir.FlatStyle = FlatStyle.Flat;
            btnDisminuir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisminuir.ForeColor = Color.White;
            btnDisminuir.Location = new Point(32, 121);
            btnDisminuir.Name = "btnDisminuir";
            btnDisminuir.Size = new Size(99, 23);
            btnDisminuir.TabIndex = 2;
            btnDisminuir.Text = "Disminuir";
            btnDisminuir.UseVisualStyleBackColor = false;
            btnDisminuir.Click += btnDisminuir_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnDisminuir);
            splitContainer1.Panel1.Controls.Add(LblContador);
            splitContainer1.Panel1.Controls.Add(btnIncrementar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(599, 293);
            splitContainer1.SplitterDistance = 199;
            splitContainer1.TabIndex = 3;
            // 
            // TxtResultado
            // 
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(396, 293);
            TxtResultado.TabIndex = 1;
            // 
            // FrmBloqueos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(621, 318);
            Controls.Add(splitContainer1);
            Name = "FrmBloqueos";
            Text = "Bloqueos";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnIncrementar;
        private Label LblContador;
        private Button btnDisminuir;
        private SplitContainer splitContainer1;
        private TextBox TxtResultado;
    }
}