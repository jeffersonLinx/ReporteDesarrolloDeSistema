using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Actividad Informe con bakup
// Nombre: Jefferson Fiorilo Chavarria
// Materia: Desarrollo de sistemas 1
// Docente: David Serrudo Terrazas

namespace ReporteForm
{
    public partial class Form1 : Form
    {
        //private string cadenaDeConexion;
        //cadenaDeConexion = ConfigurationManager.ConnectionStrings["GaleriaFotograficaWeb"].ConnectionString;
        SqlConnection conexion = new SqlConnection("server=DESKTOP-1UHVG6J; database=GaleriaFotografica2;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'galeriaFotografica2DataSet.View_ProyectoCategoria' Puede moverla o quitarla según sea necesario.
            this.view_ProyectoCategoriaTableAdapter1.Fill(this.galeriaFotografica2DataSet.View_ProyectoCategoria);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
