using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

//Nombre: Isaac Morera Vargas
//Cedula: 116200798
//Proyecto 1
//Grupo 1
//Catedra ciencias exactas y naturales
//Ingenieria de software
//-APA-
//Harvey M. & Paul J.Deitel(2006).Como programar en C#.Estados Unidos.Pearson Educación de México, S.A. de C.V.


namespace ServidorTresEnRayaForm
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Panelnicio());
        }
    }
}
