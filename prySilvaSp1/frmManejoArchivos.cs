using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//libreria que me permita manejar archivos
using System.IO;

namespace prySilvaSp1
{
    public partial class frmManejoArchivos : Form
    {
        public frmManejoArchivos()
        {
            InitializeComponent();
        }

        private void frmManejoArchivos_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            StreamWriter swArchivo = new StreamWriter(txtNombreArchivo.Text, true);

            if (File.Exists(txtNombreArchivo.Text) == true)
            {
                MessageBox.Show("Archivo " + txtNombreArchivo.Text + " fue Creado");

                swArchivo.WriteLine("Ejemplo de escritura");

                swArchivo.Close();
            }

            //StreamWriter swArchivo = new StreamWriter("EJEMPLO", true);

            //if (File.Exists("EJEMPLO"))
            //{
            //    MessageBox.Show("Archivo Creado");

            //    swArchivo.WriteLine("Ejemplo de escritura");

            //    swArchivo.Close();
            //}

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //leer la carpeta y ver de utilizar un archivo

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.ShowDialog();

            StreamReader srArchivos = new StreamReader(openFileDialog.FileName.ToString());

            while (srArchivos.EndOfStream == false)
            {
               lblLectura.Text += srArchivos.ReadLine() + Environment.NewLine;
            }
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {

            StreamWriter swArchivo = new StreamWriter("EJEMPLO", true);

            if (File.Exists("EJEMPLO") == true)
            {
                swArchivo.WriteLine(txtEscribir.Text);

                swArchivo.Close();
            }
        }
    }
}
