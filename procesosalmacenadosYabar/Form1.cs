using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace procesosalmacenadosYabar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static private string cadena = "Server=dataepis.uandina.pe,49157;Database=BDAcademicoYabar;Uid=yabarr;Pwd=iori190105";
        static private SqlConnection conexion = new SqlConnection(cadena);

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void Asignaturas_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("spListarAsignatura", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvAlumnos.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("spListarDocente", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvAlumnos.DataSource = table;
        }

        private void btnCarreras_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("spListarCarrera", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvAlumnos.DataSource = table;
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("spListarAlumno", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvAlumnos.DataSource = table;

        }
    }
}
