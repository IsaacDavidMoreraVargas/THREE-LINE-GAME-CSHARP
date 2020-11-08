using System;
using System.Windows.Forms;

namespace ServidorTresEnRayaForm
{
    public partial class Panelnicio : Form
    {
        public Panelnicio()
        {
            InitializeComponent();
        }

        int contador = 0;

        private void Server_Click(object sender, EventArgs e)
        {
            contador++;

            if (contador <= 1)
            {
                Server llamado = new Server();
                llamado.Visible = true;
            }
            else
            {
                MessageBox.Show("Servidor ya esta ocupado");
            }
        }

        private void Jugadores_Click(object sender, EventArgs e)
        {

            if (contador != 0)
            {

                Jugador1 llamado1 = new Jugador1();
                llamado1.Visible = true;

            }
            else
            {
                MessageBox.Show("Se intento jugar sin haber iniciado el servidor");
            }

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panelnicio_Load(object sender, EventArgs e)
        {

        }

        private void IniciarJugador2_Click(object sender, EventArgs e)
        {
            if (contador != 0)
            {
                Jugador2 llamado2 = new Jugador2();
                llamado2.Visible = true;

            }
            else
            {
                MessageBox.Show("Se intento jugar sin haber iniciado el servidor");
            }
        }
    }
}
