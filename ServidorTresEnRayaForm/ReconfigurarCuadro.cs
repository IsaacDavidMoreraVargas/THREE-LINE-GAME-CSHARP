using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace ServidorTresEnRayaForm
{
    public class ReconfigurarCuadro
    {
        private Panel panel; // panel de la GUI que representa este Cuadro
        private char marca; // la marca del jugador en este Cuadro (si la hay)
        private int ubicacion; // ubicacion en el tablero de este Cuadro

        // constructor
        public ReconfigurarCuadro(Panel nuevoPanel, char nuevaMarca, int nuevaUbicacion)
        {
            panel = nuevoPanel;
            marca = nuevaMarca;
            ubicacion = nuevaUbicacion;
        } // fin del constructor

        // propiedad PanelCuadros; el panel que representa el cuadro
        public Panel PanelCuadros
        {
            get
            {
                return panel;
            } // fin de get
        } // fin de la propiedad PanelCuadros

        // propiedad Marca; la marca en el cuadro
        public char Marca
        {

            get
            {
                return marca;
            } // fin de get


            set
            {
                marca = value;
            } // fin de set
        } // fin de la propiedad Marca

        // propiedad Ubicacion; la ubicación del cuadro en el tablero
        public int Ubicacion
        {
            get
            {
                return ubicacion;
            } // fin de get
        } // fin de la propiedad Ubicacion
    }// fin de la clase Cuadro
}
