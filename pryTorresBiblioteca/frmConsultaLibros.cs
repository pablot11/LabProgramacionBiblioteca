using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryTorresBiblioteca
{
    public partial class frmConsultaLibros : Form
    {
        public int varIndice = 0; // Creo una variable publica
        Libros[] vecBiblioteca = new Libros[21]; //Creo un vector publico que se le asignara la estructura Libros
        int varIndiceRecorrido = 0; 
       
        //Creo una estructura con las siguientes variables para asignar al vector
        public struct Libros

        {
            public string varCodigoLibro;
            public string varNombre;
            public string varCodigoEditorial;
            public string varCodigoAutor;
            public string varCodigoDistribuidor;
        }



        public frmConsultaLibros()
        {
            InitializeComponent();
        }

 


        private void frmConsultaLibros_Load_1(object sender, EventArgs e)
        {
            //Streamreader permite abrir el archivo en modo lectura en el archivo especificado
            StreamReader objLectorLibros = new StreamReader("./LIBRO.txt");
            //Mientras sea distinto a EOF repite los siguiente
            while (!objLectorLibros.EndOfStream)
            {
                // Se crea una variable para que se asigne el renglon leido del archivo
                string varLibro = objLectorLibros.ReadLine();
                //Se crea un vector que toma el valor de la variable, el split separa la cadena en cada posicion del vector
                string[] vecLibros = varLibro.Split(',');
                //Estructura repetitiva
                for (int varIndiceVector = 0; varIndiceVector < vecLibros.Length; varIndiceVector++)
                {
                    //En la posicion del vector lo que hace es sacar los espacios en blanco y dejar solo el texto
                    //Regex.Replace es una propiedad que hace que elimine los espacios en blanco
                    vecLibros[varIndiceVector] = Regex.Replace(vecLibros[varIndiceVector], @"\t", "");
                }
                //Asigno en la posicion del varIndice, como esta la estructura voy a asignarle a cada variable dentro una posicion del vector
                vecBiblioteca[varIndice].varCodigoLibro = vecLibros[0];
                vecBiblioteca[varIndice].varNombre = vecLibros[1];
                vecBiblioteca[varIndice].varCodigoEditorial = vecLibros[2];
                vecBiblioteca[varIndice].varCodigoAutor = vecLibros[3];
                vecBiblioteca[varIndice].varCodigoDistribuidor = vecLibros[4];
                // Procedimientos del programador con sus respectivos parametros
                // Un parametro retorna un valor 0
                NombreEditorial(varIndice);
                NombreDistribuidora(varIndice);
                varIndice++;
            }
            objLectorLibros.Close();
            //Cuando abra el formulario va a aparecer la primera consulta
            txtCodigoLibro.Text = vecBiblioteca[0].varCodigoLibro;
            txtNombreLibro.Text = vecBiblioteca[0].varNombre;
            txtCodigoEditorial.Text = vecBiblioteca[0].varCodigoEditorial;
            txtAutor.Text = vecBiblioteca[0].varCodigoAutor;
            txtDistribuidor.Text = vecBiblioteca[0].varCodigoDistribuidor;

        }

        private void btnSiguente_Click(object sender, EventArgs e)
        {
            // Mientras la variable sea menor a la dimension del vector para lo siguiente
            if (varIndiceRecorrido < vecBiblioteca.Length)
            {
                //Asigno a cada textbox una variable de la estructura para que muestre los datos
                txtCodigoLibro.Text = vecBiblioteca[varIndiceRecorrido].varCodigoLibro;
                txtNombreLibro.Text = vecBiblioteca[varIndiceRecorrido].varNombre;
                txtCodigoEditorial.Text = vecBiblioteca[varIndiceRecorrido].varCodigoEditorial;
                txtAutor.Text = vecBiblioteca[varIndiceRecorrido].varCodigoAutor;
                txtDistribuidor.Text = vecBiblioteca[varIndiceRecorrido].varCodigoDistribuidor;
                varIndiceRecorrido++;
            }          
            //Si el varIndice es igual a la dimension del vector el boton se desactiva
            if (varIndiceRecorrido == vecBiblioteca.Length)
            {

                btnSiguente.Enabled = false;
            }



        }

 
        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Decrementa la variable 
            varIndiceRecorrido--;
            //Si la variable es menor o igual a 0 pasa lo siguiente
            if (varIndiceRecorrido >= 0)
            {
                //Muestra en cada textbok lo que contiene las variables de la estructura
                txtCodigoLibro.Text = vecBiblioteca[varIndiceRecorrido].varCodigoLibro;
                txtNombreLibro.Text = vecBiblioteca[varIndiceRecorrido].varNombre;
                txtCodigoEditorial.Text = vecBiblioteca[varIndiceRecorrido].varCodigoEditorial;
                txtAutor.Text = vecBiblioteca[varIndiceRecorrido].varCodigoAutor;
                //Si el varindice es igual a 0 se desactiva el boton
                if (varIndiceRecorrido == 0)
                {
                    btnAtras.Enabled = false;
                }
            }
            else
            {
                btnAtras.Enabled = false;
            }        
        }
        //Se declara una variable para reemplazar el nombre

        private void NombreEditorial(int varProcedimientoEditorial)
        {

            StreamReader srLeerEditorial = new StreamReader("./EDITORIAL.txt");
            while (!srLeerEditorial.EndOfStream)
            {
                //Se asigna um renglon del archivo al vector, el split serapara en cada posicion del vec
                string[] vecEditorial = srLeerEditorial.ReadLine().Split(',');
                //Elimina los espacios en blancos de las posiciones de memoria
                for (int varI = 0; varI < vecEditorial.Length; varI++)
                {
                    vecEditorial[varI] = Regex.Replace(vecEditorial[varI], @"\t", "");
                }
                // Si la posicion del vec es igual a la varcodigo, se cambia el numero por el nombre
                if (vecEditorial[0] == vecBiblioteca[varProcedimientoEditorial].varCodigoEditorial)
                {
                    //Se cambia el numero por el nombre 
                    vecBiblioteca[varProcedimientoEditorial].varCodigoEditorial = vecEditorial[1];
                }              
            }
            srLeerEditorial.Close();
        }
        
        //El parametro retoma el valor de la variable indice 
        private void NombreDistribuidora(int varIndiceNombreDistribuidora)
        {
            //
            StreamReader srLeerDistribuidora = new StreamReader("./DISTRIBUIDORA.txt");
            while (!srLeerDistribuidora.EndOfStream)
            {
                //Se asigna um renglon del archivo al vector, el split serapara en cada posicion del vec
                string[] vecDistribuidora = srLeerDistribuidora.ReadLine().Split(',');
                //Elimina los espacios en blancos de las posiciones de memoria
                for (int varI = 0; varI < vecDistribuidora.Length; varI++)
                {
                    vecDistribuidora[varI] = Regex.Replace(vecDistribuidora[varI], @"\t", "");
                }
                // Si la posicion del vec es igual a la varcodigo, se cambia el numero por el nombre
                if (vecDistribuidora[0] == vecBiblioteca[varIndiceNombreDistribuidora].varCodigoDistribuidor)
                {
                    //Se cambia el numero por el nombre 
                    vecBiblioteca[varIndiceNombreDistribuidora].varCodigoDistribuidor = vecDistribuidora[1];
                }
            }
            srLeerDistribuidora.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
