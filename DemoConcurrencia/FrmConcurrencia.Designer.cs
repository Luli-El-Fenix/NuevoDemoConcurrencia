namespace DemoConcurrencia
{
    partial class FrmConcurrencia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnIniciarSecuencial = new Button();
            BtnIniciarHilo = new Button();
            BtnIniciarTarea = new Button();
            splitContainer1 = new SplitContainer();
            BtnCancelarHilo = new Button();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnIniciarSecuencial
            // 
            BtnIniciarSecuencial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnIniciarSecuencial.BackColor = Color.White;
            BtnIniciarSecuencial.FlatAppearance.BorderSize = 0;
            BtnIniciarSecuencial.FlatStyle = FlatStyle.Flat;
            BtnIniciarSecuencial.Location = new Point(42, 47);
            BtnIniciarSecuencial.Name = "BtnIniciarSecuencial";
            BtnIniciarSecuencial.Size = new Size(117, 23);
            BtnIniciarSecuencial.TabIndex = 0;
            BtnIniciarSecuencial.Text = "Iniciar Secuencial";
            BtnIniciarSecuencial.UseVisualStyleBackColor = false;
            BtnIniciarSecuencial.Click += BtnIniciarSecuencial_Click;
            // 
            // BtnIniciarHilo
            // 
            BtnIniciarHilo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnIniciarHilo.BackColor = Color.White;
            BtnIniciarHilo.FlatAppearance.BorderSize = 0;
            BtnIniciarHilo.FlatStyle = FlatStyle.Flat;
            BtnIniciarHilo.Location = new Point(42, 129);
            BtnIniciarHilo.Name = "BtnIniciarHilo";
            BtnIniciarHilo.Size = new Size(117, 23);
            BtnIniciarHilo.TabIndex = 1;
            BtnIniciarHilo.Text = "Iniciar Hilo";
            BtnIniciarHilo.UseVisualStyleBackColor = false;
            BtnIniciarHilo.Click += BtnIniciarHilo_Click;
            // 
            // BtnIniciarTarea
            // 
            BtnIniciarTarea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnIniciarTarea.BackColor = Color.White;
            BtnIniciarTarea.FlatAppearance.BorderSize = 0;
            BtnIniciarTarea.FlatStyle = FlatStyle.Flat;
            BtnIniciarTarea.Location = new Point(42, 200);
            BtnIniciarTarea.Name = "BtnIniciarTarea";
            BtnIniciarTarea.Size = new Size(117, 23);
            BtnIniciarTarea.TabIndex = 2;
            BtnIniciarTarea.Text = "Iniciar Tarea";
            BtnIniciarTarea.UseVisualStyleBackColor = false;
            BtnIniciarTarea.Click += BtnIniciarTarea_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BtnCancelarHilo);
            splitContainer1.Panel1.Controls.Add(BtnIniciarTarea);
            splitContainer1.Panel1.Controls.Add(BtnIniciarSecuencial);
            splitContainer1.Panel1.Controls.Add(BtnIniciarHilo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(772, 426);
            splitContainer1.SplitterDistance = 206;
            splitContainer1.TabIndex = 3;
            // 
            // BtnCancelarHilo
            // 
            BtnCancelarHilo.Location = new Point(42, 261);
            BtnCancelarHilo.Name = "BtnCancelarHilo";
            BtnCancelarHilo.Size = new Size(117, 23);
            BtnCancelarHilo.TabIndex = 3;
            BtnCancelarHilo.Text = "Canselar Hilo";
            BtnCancelarHilo.UseVisualStyleBackColor = true;
            BtnCancelarHilo.Click += BtnCancelarHilo_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(562, 426);
            TxtResultado.TabIndex = 0;
            TxtResultado.TextChanged += TxtResultado_TextChanged;
            // 
            // FrmConcurrencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 426);
            Controls.Add(splitContainer1);
            Name = "FrmConcurrencia";
            Text = "FrmConcurrencia";
            Load += FrmConcurrencia_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnIniciarSecuencial;
        private Button BtnIniciarHilo;
        private Button BtnIniciarTarea;
        private SplitContainer splitContainer1;
        private TextBox TxtResultado;
        private Button BtnCancelarHilo;
    }
}
