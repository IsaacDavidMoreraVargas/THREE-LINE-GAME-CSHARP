using System;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ServidorTresEnRayaForm
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
 
        private Thread[] subprocesosJugadores; // subprocesos de los clientes
        private byte[] paneles; // paneles del tablero del juego
        private ConfigurarJugador[] jugadores; // dos jugadores Jugador

        private TcpListener oyenEnEspera; // escucha en espera de la conexión del cliente
        private Thread obtenerJugadores; // proceso obtener las conexiones de los clientes

        private int jugadorActual; // lleva la cuenta de quién sigue
        internal bool desconectado = false; // verdadero si el servidor se cierra

        private void Server_Load(object sender, EventArgs e)
        {

            paneles = new byte[9];
            jugadores = new ConfigurarJugador[2];
            subprocesosJugadores = new Thread[2];
            jugadorActual = 0;

            // acepta conexiones en un subproceso distinto
            obtenerJugadores = new Thread(new ThreadStart(Establecer));
            obtenerJugadores.Start();
            
        }

        
        private void ServidorTresEnRayaForm_FormClosing(object sender, FormClosingEventArgs e)// desconecta a los jugadores 
        {
            desconectado = true;
            System.Environment.Exit(System.Environment.ExitCode);
        } 

        private delegate void DisplayDelegate(string message);//mantiene actulizando los mensajes


        internal void MostrarMensaje(string mensaje)//muiestra mensaje y asegura el proceso de errores
        {
            if (mostrarTextBox.InvokeRequired)
            {

                Invoke(new DisplayDelegate(MostrarMensaje), new object[] { mensaje });
            } 
            else
            
                mostrarTextBox.Text += mensaje;
        }


        public void Establecer()//Establece conexiones para los jugadores
        {
            try
            {
                MostrarMensaje("\nEsperando a que conecten los dos jugadores...\r\n");

                oyenEnEspera = new TcpListener(IPAddress.Parse("127.0.0.1"), 6001);//crea conexion
                oyenEnEspera.Start();

                jugadores[0] = new ConfigurarJugador(oyenEnEspera.AcceptSocket(), this, 0);// inicia jugador 0 en server
                subprocesosJugadores[0] = new Thread(new ThreadStart(jugadores[0].Ejecutar));
                subprocesosJugadores[0].Start();

                // acepta el segundo jugador e inicia otro subproceso jugador
                jugadores[1] = new ConfigurarJugador(oyenEnEspera.AcceptSocket(), this, 1);// inicia jugador 1 en server
                subprocesosJugadores[1] = new Thread(new ThreadStart(jugadores[1].Ejecutar));
                subprocesosJugadores[1].Start();

                
                lock (jugadores[0])// hace esperar en el hilo hasta el otro jugador
                {
                    jugadores[0].subprocesoSuspendido = false;
                    Monitor.Pulse(jugadores[0]);
                } // fin de lock

            } catch (Exception e)
            {
                MostrarMensaje("Sucedio algun problema");
            }
        } 

         
        public bool MovimientoValido(int ubicacion, int jugador)// determina si un movimiento es válido recibe ubicacion y jugador
        {

            lock (this)
            {
                while (jugador != jugadorActual)//mientras el jugador no sea el jugador que esta jugando
                
                    Monitor.Wait(this);//sincroniza los objetos

                    if (!EstaOcupado(ubicacion))//si el panel apretado no esta ocupado
                    {
                        paneles[ubicacion] = (byte)(jugadorActual == 0 ? 'X' : 'O');//elector ternario para mantener los dibujos en los paneles
                        jugadorActual = (jugadorActual + 1) % 2;
                        jugadores[jugadorActual].OtroJugadorMovio(ubicacion);
                        Monitor.Pulse(this);
                        return true;
                    }
                    else
                        return false;
                
            } 
        } 

        
        public bool EstaOcupado(int ubicacion)//si el panel especificado esta ocupado
        {
            if (paneles[ubicacion] == 'X' || paneles[ubicacion] == 'O')//si el panel de la ubicacion tiene o no X o O
                return true; //devuelve verdadero
            else
                return false;
            

        } 

        public bool JuegoTerminado()
        {
            return false;
        } 

    } 

}

