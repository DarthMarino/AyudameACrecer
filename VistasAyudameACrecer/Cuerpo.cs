using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DataModel;

namespace VistasAyudameACrecer
{
    public partial class Cuerpo : Form
    {
        public Cuerpo()
        {
            InitializeComponent();
        }

        private void TimePickerAsistencia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DataGridAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void BotonListar_Click(object sender, EventArgs e) //Este boton no sirve
        {
            
        }

        private void DataGridNiños_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotonListar_Click_1(object sender, EventArgs e)
        {
            //Para llenar el datagrid con datos de los niños.

            var personas = new List<Persona>();
            SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["GabrielDataBase"].ConnectionString);
            Conexion.Open();
            SqlCommand Comando = new SqlCommand("stpListarNiños", Conexion);
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "stpListarNiños";
            SqlDataReader Reader = Comando.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(Reader);
            dataGridNiños.DataSource = dataTable;
            dataGridNiños.Update();
        }

        private void Label3_Click(object sender, EventArgs e) //Ignorar esto
        {

        }

        #region Pestañas.Click

        private void TabAsistencia_Click(object sender, EventArgs e)
        {
        }

        private void TabNinos_Click(object sender, EventArgs e)
        {
        }

        private void TabColaboradores_Click(object sender, EventArgs e)
        {
        }

        private void TabPatrocinadores_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region Pesataña Niños
        private void BotonAñadirN_Click(object sender, EventArgs e)
        {
            ConfirmaciónN.Visible = true;
        }

        private void ConfirmaciónN_Click(object sender, EventArgs e)
        {
            //Aquí va el código para añadir niños
        }
        #endregion

        #region Pestaña Colaboradores
        private void AñadirColaborador_Click(object sender, EventArgs e)
        {
            ConfirmacionC.Visible = true;
        }

        private void ConfirmacionC_Click(object sender, EventArgs e)
        {
            //Aquí va el código para añadir colaboradores
        }

        #endregion

        #region Pestaña Patrocinadores
        private void AñadirPatrocinador_Click(object sender, EventArgs e)
        {
            ConfirmacionP.Visible = true;
        }

        private void ConfirmacionP_Click(object sender, EventArgs e)
        {
            //Aquí va el código para añadir Patrocinadores
        }
        #endregion
    }
}
