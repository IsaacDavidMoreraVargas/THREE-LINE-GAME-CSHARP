using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace ServidorTresEnRayaForm
{
    public class ConfigurarJugador
    {
        internal Socket conexion; // Socket para aceptar una conexión private NetworkStream socketStream; // flujo de datos de red
        private NetworkStream socketStream;
        private Server servidor; // referencia al servidor
        private BinaryWriter escritor; // facilita la escritura en el flujo
        private BinaryReader lector; // facilita la lectura del flujo
        private int numero; // número de jugador
        private char marca; // marca del jugador en el tablero
        internal bool subprocesoSuspendido = true; // si está esperando al otro jugador 
                                                   // constructor que requiere objetos Socket, ServidorTresEnRayaForm
                                                   // e int como argumentos 

        public ConfigurarJugador(Socket socket, Server valorServidor, int nuevoNumero)
        {
            marca = (nuevoNumero == 0 ? 'X' : 'O');
            conexion = socket;
            servidor = valorServidor;
            numero = nuevoNumero;

            // crea objeto NetworkStream para Socket
            socketStream = new NetworkStream(conexion);

            
            escritor = new BinaryWriter(socketStream);//LEE BYTES RECIBIDOS
            lector = new BinaryReader(socketStream);//ESCRIBE BYTES RECIBIDOS

        } // fin del constructor

        // indica la jugada al otro jugador
        public void OtroJugadorMovio(int ubicacion)
        {
            // signal that opponent moved
            escritor.Write("El oponente hizo un movimiento...");
            escritor.Write(ubicacion); // envía la ubicación del movimiento
        } // fin del método OtroJugadorMovio

        // permite a los jugadores hacer movimientos y recibir los movimientos
        // del otro jugador
        public void Ejecutar()
        {
            bool listo = false;

            // muestra en el servidor que se hizo una conexión
            servidor.MostrarMensaje("\nJugador " + (numero == 0 ? '1' : '2') + " conectado...\r\n");

            // envía la marca del jugador actual al cliente
            escritor.Write(marca);

            // si el número es igual a 0, entonces este jugador es X,
            // en caso contrario, 0 debe esperar el primer movimiento de X 
            escritor.Write("\nJugador(TU) " + (numero == 0 ? "X conectado.\r\n" : "O conectado, por favor espere\r\n"));

            // X debe esperar a que llegue otro jugador
            if (marca == 'X')
            {
                escritor.Write("\nEsperando al otro jugador");

                // espera la notificación del servidor, de que
                // se conectó el otro jugador
                lock (this)
                {
                    while (subprocesoSuspendido)
                        Monitor.Wait(this);
                } // fin de lock

                escritor.Write("Se conectó el otro jugador.Es tu turno");
            } // fin de if

            // iniciar el juego
            while (!listo)
            {
                // espera a que haya datos disponibles
                while (conexion.Available == 0)
                {
                    Thread.Sleep(1000);
                    if (servidor.desconectado)
                        return;
                } // fin de while

                // recibe los datos
                int ubicacion = lector.ReadInt32();

                if (servidor.MovimientoValido(ubicacion, numero))
                {
                    servidor.MostrarMensaje("Coordenada: " + ubicacion + "\r\n");
                    escritor.Write("Movimiento válido.");
                }
                else // indica que el movimiento es inválido  
                    escritor.Write("Movimiento inválido intente de nuevo.");     
                if (servidor.JuegoTerminado())
                
                    listo = true; 
            } // fin de ciclo while


            // cierra la conexión de los sockets
            escritor.Close();
            lector.Close();
            socketStream.Close();
            conexion.Close();
        } // fin del método Ejecutar
    } // fin de la clase Jugador
}
