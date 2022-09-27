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
        public int varIndice = 0;
        Libros[] vecBiblioteca = new Libros[21];
        int varIndiceRecorrido = 0;
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
            StreamReader objLectorLibros = new StreamReader("./LIBRO.txt");
            while (!objLectorLibros.EndOfStream)
            {
                string varLibro = objLectorLibros.ReadLine();
                string[] vecLibros = varLibro.Split(',');

                for (int pos = 0; pos < vecLibros.Length; pos++)
                {
                    //En la posicion del vector lo que hace es sacar los espacios en blanco y dejar solo el texto
                    //Regex.Replace esa funcion hace que elimine los espacios en blanco
                    vecLibros[pos] = Regex.Replace(vecLibros[pos], @"\t", "");
                }


                vecBiblioteca[varIndice].varCodigoLibro = vecLibros[0];
                vecBiblioteca[varIndice].varNombre = vecLibros[1];
                vecBiblioteca[varIndice].varCodigoEditorial = vecLibros[2];
                vecBiblioteca[varIndice].varCodigoAutor = vecLibros[3];
                vecBiblioteca[varIndice].varCodigoDistribuidor = vecLibros[4];

                NombreEditorial(varIndice);
                NombreDistribuidora(varIndice);
                varIndice++;
            }
            objLectorLibros.Close();
        }

        private void btnSiguente_Click(object sender, EventArgs e)
        {      
            if (varIndiceRecorrido < vecBiblioteca.Length)
            {
                txtCodigoLibro.Text = vecBiblioteca[varIndiceRecorrido].varCodigoLibro;
                txtNombreLibro.Text = vecBiblioteca[varIndiceRecorrido].varNombre;
                txtCodigoEditorial.Text = vecBiblioteca[varIndiceRecorrido].varCodigoEditorial;
                txtAutor.Text = vecBiblioteca[varIndiceRecorrido].varCodigoAutor;
                txtDistribuidor.Text = vecBiblioteca[varIndiceRecorrido].varCodigoDistribuidor;
                varIndiceRecorrido++;
            }
            if (varIndiceRecorrido == vecBiblioteca.GetLength(0) -1)
            {
                btnSiguente.Enabled = false;
            }


        }

 
        private void btnAtras_Click(object sender, EventArgs e)
        {
            varIndiceRecorrido--;
            if (varIndiceRecorrido >= 0)
            {
                txtCodigoLibro.Text = vecBiblioteca[varIndiceRecorrido].varCodigoLibro;
                txtNombreLibro.Text = vecBiblioteca[varIndiceRecorrido].varNombre;
                txtCodigoEditorial.Text = vecBiblioteca[varIndiceRecorrido].varCodigoEditorial;
                txtAutor.Text = vecBiblioteca[varIndiceRecorrido].varCodigoAutor;
                txtDistribuidor.Text = vecBiblioteca[varIndiceRecorrido].varCodigoDistribuidor;
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

        private void NombreEditorial(int index)
        {
            StreamReader srLeerEditorial = new StreamReader("./EDITORIAL.txt");
            while (!srLeerEditorial.EndOfStream)
            {
                string[] vecEditorial = srLeerEditorial.ReadLine().Split(',');
                for (int pos = 0; pos < vecEditorial.Length; pos++)
                {
                    vecEditorial[pos] = Regex.Replace(vecEditorial[pos], @"\t", "");
                }
                if (vecEditorial[0] == vecBiblioteca[index].varCodigoEditorial)
                {
                    vecBiblioteca[index].varCodigoEditorial = vecEditorial[1];
                }              
            }
            srLeerEditorial.Close();
        }
        
        //Indice interno el index
        private void NombreDistribuidora(int index)
        {
            StreamReader srLeerDistribuidora = new StreamReader("./DISTRIBUIDORA.txt");
            while (!srLeerDistribuidora.EndOfStream)
            {
                string[] vecDistribuidora = srLeerDistribuidora.ReadLine().Split(',');
                for (int pos = 0; pos < vecDistribuidora.Length; pos++)
                {
                    vecDistribuidora[pos] = Regex.Replace(vecDistribuidora[pos], @"\t", "");
                }
                if (vecDistribuidora[0] == vecBiblioteca[index].varCodigoDistribuidor)
                {
                    vecBiblioteca[index].varCodigoDistribuidor = vecDistribuidora[1];
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
