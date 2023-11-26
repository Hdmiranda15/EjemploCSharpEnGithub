using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TresEnUno
{
    public partial class Form1 : Form//public=clase, acceible en cualquier parte
                                     //partial=esta clase es solo una parte de la clase completa
                                     // class Form1= una clase parcial que tiene acceso a metodos y propiedades de la clase base"Form"
                                     //Form= Clase, Representa una ventana o cuadro de diálogo que conforma la interfaz de usuario de una aplicación

    /// <summary>
    ///Representa la clase de formulario principal de la aplicación.
    /// </summary>
    {
        public Form1()
        {
            /// <summary>
            /// Constructor de la clase Form1.
            /// Inicializa los componentes de la interfaz de usuario.
            /// </summary>
            InitializeComponent(); //metodo,inicializar los componentes de la forma
        }
        /// <summary>
        /// Evento que se dispara cuando se hace clic en el botón "Ejecutar".
        /// Muestra un cuadro de mensaje con el texto "Hola mundo".
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void ButpagarIVA_Click(object sender, EventArgs e) //private=metodo, accesible internamente
                                                                  //void=este metodo, no devuelve valor
                     //controlName_Event=buttoin1_Click          // button1=nombre del botón  
                     //NombreBoton_Metodo(parametros)           // Click=Evento,activa cuando usuario hace clic en el boton
        {
            double precioNeto, Total;//declaracion de variables tipos Decimal

            precioNeto = Convert.ToDouble(textProduNeto.Text);    //convert=clase, convierto tipo de dato base a otro tipo de dato base
                         //clase.metodo(NombreCaja.Propiedad)    // ToDouble:metodo , punto flotante (decimal ) a Double
                                                                // Text=propiedad,obtiene el texto asociado al TextBox

            Total = 1.13 * precioNeto;//declaracion de variables tipos Decimal

            MessageBox.Show(string.Format("total a pagar con IVA es:{0}", Total));//MessageBox:clase,muestra ventana modal, que bloquea
               //Clase.Metodo(Clase.Metodo)                                       //otras acciones en la aplicación hasta que el usuario la cierra
        }

        private void BotDescue_Click(object sender, EventArgs e) //private=metodo, accesible internamente
                                                                 //void=este metodo, no devuelve valor
                 //controlName_Event=buttoin1_Click          // button1=nombre del botón  
                 //NombreBoton_Metodo(parametros)           // Click=Evento,activa cuando usuario hace clic en el boton
        {
            double sueldo, descuento, TotalDescue;//declaracion de variables tipos Decimal

            sueldo = Convert.ToDouble(textSueldo.Text); //convert=clase, convierto tipo de dato base a otro tipo de dato base
                                                       //clase.metodo(NombreCaja.Propiedad)    // ToDouble:metodo , punto flotante (decimal ) a Double
                                                      // Text=propiedad,obtiene el texto asociado al TextBox
            descuento = Convert.ToDouble(textDescue.Text);//convert=clase, convierto tipo de dato base a otro tipo de dato base
                                                         //clase.metodo(NombreCaja.Propiedad)    // ToDouble:metodo , punto flotante (decimal ) a Double
                                                        // Text=propiedad,obtiene el texto asociado al TextBox

            TotalDescue = (descuento/100) * sueldo;//declaracion de variables tipos Decimal

            MessageBox.Show(string.Format("total de descuento:{0}", TotalDescue));//MessageBox:clase,muestra ventana modal, que bloquea
                                                                                  //Clase.Metodo(Clase.Metodo)                                       //otras acciones en la aplicación hasta que el usuario la cierra
        }

        private void TablaPrecios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butLimpio_Click(object sender, EventArgs e)
        {
            

        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();// cerrar la aplicacion
            //Class.metodo
        }
    }
}
