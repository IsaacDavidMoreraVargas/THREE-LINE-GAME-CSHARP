namespace ServidorTresEnRayaForm
{
    partial class Jugador1
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
            this.idLabel = new System.Windows.Forms.Label();
            this.mostrarTextBox = new System.Windows.Forms.TextBox();
            this.Abandonar = new System.Windows.Forms.Button();
            this.tablero0Panel = new System.Windows.Forms.Panel();
            this.tablero1Panel = new System.Windows.Forms.Panel();
            this.tablero2Panel = new System.Windows.Forms.Panel();
            this.tablero6Panel = new System.Windows.Forms.Panel();
            this.tablero3Panel = new System.Windows.Forms.Panel();
            this.tablero4Panel = new System.Windows.Forms.Panel();
            this.tablero5Panel = new System.Windows.Forms.Panel();
            this.tablero7Panel = new System.Windows.Forms.Panel();
            this.tablero8Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(160, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(131, 17);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "Usted es el jugador";
            // 
            // mostrarTextBox
            // 
            this.mostrarTextBox.Location = new System.Drawing.Point(63, 298);
            this.mostrarTextBox.Multiline = true;
            this.mostrarTextBox.Name = "mostrarTextBox";
            this.mostrarTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mostrarTextBox.Size = new System.Drawing.Size(312, 65);
            this.mostrarTextBox.TabIndex = 15;
            // 
            // Abandonar
            // 
            this.Abandonar.Location = new System.Drawing.Point(390, 272);
            this.Abandonar.Name = "Abandonar";
            this.Abandonar.Size = new System.Drawing.Size(112, 91);
            this.Abandonar.TabIndex = 16;
            this.Abandonar.Text = "Abandonar Juego";
            this.Abandonar.UseVisualStyleBackColor = true;
            this.Abandonar.Click += new System.EventHandler(this.Abandonar_Click);
            // 
            // tablero0Panel
            // 
            this.tablero0Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablero0Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablero0Panel.Location = new System.Drawing.Point(65, 69);
            this.tablero0Panel.Name = "tablero0Panel";
            this.tablero0Panel.Size = new System.Drawing.Size(100, 71);
            this.tablero0Panel.TabIndex = 19;
            this.tablero0Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cuadro_MouseUp);
            // 
            // tablero1Panel
            // 
            this.tablero1Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablero1Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.tablero1Panel.Location = new System.Drawing.Point(171, 69);
            this.tablero1Panel.Name = "tablero1Panel";
            this.tablero1Panel.Size = new System.Drawing.Size(100, 71);
            this.tablero1Panel.TabIndex = 18;
            this.tablero1Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cuadro_MouseUp);
            // 
            // tablero2Panel
            // 
            this.tablero2Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablero2Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.tablero2Panel.Location = new System.Drawing.Point(277, 69);
            this.tablero2Panel.Name = "tablero2Panel";
            this.tablero2Panel.Size = new System.Drawing.Size(100, 71);
            this.tablero2Panel.TabIndex = 20;
            this.tablero2Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cuadro_MouseUp);
            // 
            // tablero6Panel
            // 
            this.tablero6Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablero6Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.tablero6Panel.Location = new System.Drawing.Point(65, 146);
            this.tablero6Panel.Name = "tablero6Panel";
            this.tablero6Panel.Size = new System.Drawing.Size(100, 71);
            this.tablero6Panel.TabIndex = 19;
            this.tablero6Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cuadro_MouseUp);
            // 
            // tablero3Panel
            // 
            this.tablero3Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablero3Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.tablero3Panel.Location = new System.Drawing.Point(170, 146);
            this.tablero3Panel.Name = "tablero3Panel";
            this.tablero3Panel.Size = new System.Drawing.Size(100, 71);
            this.tablero3Panel.TabIndex = 19;
            this.tablero3Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cuadro_MouseUp);
            // 
            // tablero4Panel
            // 
            this.tablero4Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablero4Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.tablero4Panel.Location = new System.Drawing.Point(277, 146);
            this.tablero4Panel.Name = "tablero4Panel";
            this.tablero4Panel.Size = new System.Drawing.Size(100, 71);
            this.tablero4Panel.TabIndex = 19;
            this.tablero4Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cuadro_MouseUp);
            // 
            // tablero5Panel
            // 
            this.tablero5Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablero5Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.tablero5Panel.Location = new System.Drawing.Point(65, 221);
            this.tablero5Panel.Name = "tablero5Panel";
            this.tablero5Panel.Size = new System.Drawing.Size(100, 71);
            this.tablero5Panel.TabIndex = 19;
            this.tablero5Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cuadro_MouseUp);
            // 
            // tablero7Panel
            // 
            this.tablero7Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablero7Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.tablero7Panel.Location = new System.Drawing.Point(171, 221);
            this.tablero7Panel.Name = "tablero7Panel";
            this.tablero7Panel.Size = new System.Drawing.Size(100, 71);
            this.tablero7Panel.TabIndex = 21;
            this.tablero7Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cuadro_MouseUp);
            // 
            // tablero8Panel
            // 
            this.tablero8Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablero8Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.tablero8Panel.Location = new System.Drawing.Point(277, 221);
            this.tablero8Panel.Name = "tablero8Panel";
            this.tablero8Panel.Size = new System.Drawing.Size(100, 71);
            this.tablero8Panel.TabIndex = 22;
            this.tablero8Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cuadro_MouseUp);
            // 
            // Jugador1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 389);
            this.Controls.Add(this.tablero0Panel);
            this.Controls.Add(this.tablero1Panel);
            this.Controls.Add(this.Abandonar);
            this.Controls.Add(this.tablero2Panel);
            this.Controls.Add(this.mostrarTextBox);
            this.Controls.Add(this.tablero6Panel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.tablero3Panel);
            this.Controls.Add(this.tablero8Panel);
            this.Controls.Add(this.tablero4Panel);
            this.Controls.Add(this.tablero7Panel);
            this.Controls.Add(this.tablero5Panel);
            this.Location = new System.Drawing.Point(1000, 50);
            this.Name = "Jugador1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Jugador1";
            this.Load += new System.EventHandler(this.Jugador1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox mostrarTextBox;
        private System.Windows.Forms.Button Abandonar;
        private System.Windows.Forms.Panel tablero0Panel;
        private System.Windows.Forms.Panel tablero1Panel;
        private System.Windows.Forms.Panel tablero2Panel;
        private System.Windows.Forms.Panel tablero6Panel;
        private System.Windows.Forms.Panel tablero3Panel;
        private System.Windows.Forms.Panel tablero4Panel;
        private System.Windows.Forms.Panel tablero5Panel;
        private System.Windows.Forms.Panel tablero7Panel;
        private System.Windows.Forms.Panel tablero8Panel;
    }
}