namespace ServidorTresEnRayaForm
{
    partial class Panelnicio
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
            this.Server = new System.Windows.Forms.Button();
            this.IniciarJugador1 = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.IniciarJugador2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Server
            // 
            this.Server.Location = new System.Drawing.Point(60, 66);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(103, 53);
            this.Server.TabIndex = 0;
            this.Server.Text = "Server";
            this.Server.UseVisualStyleBackColor = true;
            this.Server.Click += new System.EventHandler(this.Server_Click);
            // 
            // IniciarJugador1
            // 
            this.IniciarJugador1.Location = new System.Drawing.Point(169, 36);
            this.IniciarJugador1.Name = "IniciarJugador1";
            this.IniciarJugador1.Size = new System.Drawing.Size(103, 53);
            this.IniciarJugador1.TabIndex = 1;
            this.IniciarJugador1.Text = "Iniciar Jugador1";
            this.IniciarJugador1.UseVisualStyleBackColor = true;
            this.IniciarJugador1.Click += new System.EventHandler(this.Jugadores_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(278, 66);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(103, 53);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // IniciarJugador2
            // 
            this.IniciarJugador2.Location = new System.Drawing.Point(169, 95);
            this.IniciarJugador2.Name = "IniciarJugador2";
            this.IniciarJugador2.Size = new System.Drawing.Size(103, 53);
            this.IniciarJugador2.TabIndex = 3;
            this.IniciarJugador2.Text = "Iniciar Jugador2";
            this.IniciarJugador2.UseVisualStyleBackColor = true;
            this.IniciarJugador2.Click += new System.EventHandler(this.IniciarJugador2_Click);
            // 
            // Panelnicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 178);
            this.Controls.Add(this.IniciarJugador2);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.IniciarJugador1);
            this.Controls.Add(this.Server);
            this.Location = new System.Drawing.Point(350, 350);
            this.Name = "Panelnicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panelnicio";
            this.Load += new System.EventHandler(this.Panelnicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Server;
        private System.Windows.Forms.Button IniciarJugador1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button IniciarJugador2;
    }
}