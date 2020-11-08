using System.Net.Sockets;
using System.Threading;
using System.IO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ServidorTresEnRayaForm
{
    public partial class Jugador1 : Form
    {
        public Jugador1()
        {
            InitializeComponent();
        }

        private ReconfigurarCuadro[,] Gato; // Gato
        private ReconfigurarCuadro PanelActual; // panel actual del gato
        private Thread hilorecibeServer; // hilo maneja datos del server
        private TcpClient conexion; // conexion cliente
        private NetworkStream flujoDatosServer; // maneja datos server
        private BinaryWriter escritorServer; // escribe en server
        private BinaryReader lectorServer; // lee en server
        private char MarcaXO; // marca con X o O
        private bool Turno; // turnos
        private SolidBrush brocha; // brocha para dibujar Xs y Os
        private bool SalirJuego = false; // verdadero cuando se termina el juego

        private void Jugador1_Load(object sender, EventArgs e)
        {

            Gato = new ReconfigurarCuadro[3, 3];//da posiciones al tablero
            Gato[0, 0] = new ReconfigurarCuadro(tablero0Panel, ' ', 0);
            Gato[0, 1] = new ReconfigurarCuadro(tablero1Panel, ' ', 1);
            Gato[0, 2] = new ReconfigurarCuadro(tablero2Panel, ' ', 2);
            Gato[1, 0] = new ReconfigurarCuadro(tablero3Panel, ' ', 3);
            Gato[1, 1] = new ReconfigurarCuadro(tablero4Panel, ' ', 4);
            Gato[1, 2] = new ReconfigurarCuadro(tablero5Panel, ' ', 5);
            Gato[2, 0] = new ReconfigurarCuadro(tablero6Panel, ' ', 6);
            Gato[2, 1] = new ReconfigurarCuadro(tablero7Panel, ' ', 7);
            Gato[2, 2] = new ReconfigurarCuadro(tablero8Panel, ' ', 8);

            
            brocha = new SolidBrush(Color.Black);// crea una broca para escribir en los paneles

            conexion = new TcpClient("127.0.0.1", 6001);//conecta a ip y puerto

                flujoDatosServer = conexion.GetStream();//recibe y envia datos
                escritorServer = new BinaryWriter(flujoDatosServer);//escribe en server
                lectorServer = new BinaryReader(flujoDatosServer);//lee en server

                hilorecibeServer = new Thread(new ThreadStart(Ejecutar));//inicia nuevo hilo con
                hilorecibeServer.Start();//inicia hilo

        }

        private void ClienteTresEnRayaForm_FormClosing(object sender, FormClosingEventArgs e)//cierra form
        {
            SalirJuego = true;//sale del juego
            System.Environment.Exit(0);
        }

        private void ClienteTresEnRayaForm_Paint(object sender, PaintEventArgs e)//llama a pintar panel
        {
            PintarCuadros();//pinta
        }

        private delegate void DisplayDelegate(string message);//mantiene hilo funcionando

        private void MostrarMensaje(string mensaje)//recibe para mostrartexto y  asegura  el subproceso
        {

            if (mostrarTextBox.InvokeRequired)
            {

                Invoke(new DisplayDelegate(MostrarMensaje), new object[] { mensaje });
            }
            else
                mostrarTextBox.Text += mensaje;
        }


        private delegate void ChangeIdLabelDelegate(string message);//mantiene cambio de id

        private void CambiarIdLabel(string etiqueta)//da datos a label y asegura el proceso
        {
            if (idLabel.InvokeRequired)
            {

                Invoke(new ChangeIdLabelDelegate(CambiarIdLabel), new object[] { etiqueta });
            }
            else
                idLabel.Text = etiqueta;
        }


        public void PintarCuadros() // dibuja para paneles
        {
            Graphics g;
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    g = Gato[fila, columna].PanelCuadros.CreateGraphics();//obtiene panel con coodenadas


                    g.DrawString(Gato[fila, columna].Marca.ToString(), tablero0Panel.Font, brocha, 10, 8);// dibuja X o O con brocha
                }
            }
        }

        public void Ejecutar()//actualiza textebox
        {
            // primero obtiene la marca del jugador (X o O) usando bool ternario
            MarcaXO = lectorServer.ReadChar();
            CambiarIdLabel("\nUsted es el jugador \"" + MarcaXO + "\"");
            Turno = (MarcaXO == 'X' ? true : false);

            try
            {

                while (!SalirJuego)//mientras el juego se mantenga seguira leyendo
                    ProcesarMensaje(lectorServer.ReadString());
            }catch (IOException)
            {
                MessageBox.Show("\nServidor desconectado, el juego terminó"+ "Error"+ MessageBoxButtons.OK+ MessageBoxIcon.Error);
            }
        }

        private void cuadro_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)// envía al servidor la ubicación del cuadro en el que se hizo clic
        {

            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    if (Gato[fila, columna].PanelCuadros == sender)
                    {
                        CuadroActual = Gato[fila, columna];//enviar a constructor datos

                        EnviarCuadradoClic(Gato[fila, columna].Ubicacion);//enviar movimiento al constructor luego al servidor ,ademas cambia turno
                    }
                }
            }
        }

        public void EnviarCuadradoClic(int ubicacion)//envia coordinada del panel elegido
        {

            if (Turno)//turno
            {
                escritorServer.Write(ubicacion);// envía la ubicación
                Turno = false;//cambia turno
            }
        }

        public void ProcesarMensaje(string mensaje)// procesa los mensajes 
        {

            if (mensaje == "Movimiento válido.")//movimiento valido
            {
                MostrarMensaje("\nMovimiento válido, \r\nEspere el movimiento enemigo.\r\n");
                PanelActual.Marca = MarcaXO;//envia al otro jugador dato
                PintarCuadros();//pinta
            }
            else if (mensaje == "Movimiento inválido intente de nuevo.")//si movimiento invalido se repite turnno
            {
                MostrarMensaje(mensaje + "\r\n");
                Turno = true;
            }
            else if (mensaje == "\nEl oponente movió.")//aviso sobre movimiento
            {
                int ubicacion = lectorServer.ReadInt32();//recibe ubicacion

                Gato[ubicacion / 3, ubicacion % 3].Marca = (MarcaXO == 'X' ? 'O' : 'X');// calcula cuadro para que tenga la marca del oponente y vuelve a pintar el tablero
                PintarCuadros();//pinta

                MostrarMensaje("\nEl oponente movió. \r\nEs su turno.\r\n");

                // ahora es el turno de este jugador
                Turno = true;
            } // fin de else if
            else
                MostrarMensaje(mensaje + "\r\n"); // muestra el mensaje
        }

        public ReconfigurarCuadro CuadroActual//da el valor a cuadro actual
        {
            set
            {
                PanelActual = value;//valor a panel
            }
        }

        private void Abandonar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}

