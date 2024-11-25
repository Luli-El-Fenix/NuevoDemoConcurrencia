namespace DemoConcurrencia
{
    partial class FrmPatronSingleton
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
            btnAsignar = new Button();
            btnObtener = new Button();
            txtCadenaConexion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblCadenaConexionRecuperada = new Label();
            SuspendLayout();
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(12, 89);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(121, 59);
            btnAsignar.TabIndex = 0;
            btnAsignar.Text = "Asignar cadena de conexion";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnObtener
            // 
            btnObtener.Location = new Point(12, 148);
            btnObtener.Name = "btnObtener";
            btnObtener.Size = new Size(121, 59);
            btnObtener.TabIndex = 1;
            btnObtener.Text = "Obtener cadena de conexion";
            btnObtener.UseVisualStyleBackColor = true;
            btnObtener.Click += btnObtener_Click;
            // 
            // txtCadenaConexion
            // 
            txtCadenaConexion.Location = new Point(12, 40);
            txtCadenaConexion.Name = "txtCadenaConexion";
            txtCadenaConexion.Size = new Size(257, 23);
            txtCadenaConexion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 3;
            label1.Text = "Cadena de conexion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // lblCadenaConexionRecuperada
            // 
            lblCadenaConexionRecuperada.AutoSize = true;
            lblCadenaConexionRecuperada.Location = new Point(186, 205);
            lblCadenaConexionRecuperada.Name = "lblCadenaConexionRecuperada";
            lblCadenaConexionRecuperada.Size = new Size(16, 15);
            lblCadenaConexionRecuperada.TabIndex = 5;
            lblCadenaConexionRecuperada.Text = "...";
            // 
            // FrmPatronSingleton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 270);
            Controls.Add(lblCadenaConexionRecuperada);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCadenaConexion);
            Controls.Add(btnObtener);
            Controls.Add(btnAsignar);
            Name = "FrmPatronSingleton";
            Text = "FrmPatronSingleton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAsignar;
        private Button btnObtener;
        private TextBox txtCadenaConexion;
        private Label label1;
        private Label label2;
        private Label lblCadenaConexionRecuperada;
    }
}