using NuevasCarrerasApp1.AccesoDB;
using NuevasCarrerasApp1.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevasCarrerasApp1
{
    public partial class NuevoPlan : Form
    {
        AccesoDatos aDB = new AccesoDatos();
        Carrera nueva;
        public NuevoPlan()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NuevoPlan_Load(object sender, EventArgs e)
        {
            CargarAsignaturas();
            nueva = new Carrera();
        }

        private void CargarAsignaturas()
        {
            DataTable tabla = new DataTable();
            tabla = aDB.consultarDB("SP_CONSULTAR_Asignaturas");
            cboAsignatura.DataSource = tabla;
            cboAsignatura.ValueMember = tabla.Columns[0].ColumnName;
            cboAsignatura.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void lblNuevoPl_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Asignatura asignatura = new Asignatura();
            asignatura.AsignaturaNro = Convert.ToInt32(cboAsignatura.SelectedValue);
            asignatura.Nombre = cboAsignatura.Text;
            int anioCursado = int.Parse(txtAnio.Text);
            string cuatri= Convert.ToString(txtCuatri.Text);


            DetalleCarrera detCarrera = new DetalleCarrera(anioCursado, cuatri, asignatura);
            nueva.AgregarDetalle(detCarrera);
            dgvDetalles.Rows.Add(new Object[] { asignatura.AsignaturaNro, asignatura.Nombre, anioCursado, cuatri });

        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                nueva.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                //click button:
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
              

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //if (txtNombre.Text == "")
            //{
            //    MessageBox.Show("Ingrese el nombre de la carrera",
            //    "Atención", MessageBoxButtons.OK,
            //    MessageBoxIcon.Exclamation);
            //    return;
            //}

            //AccesoDatos.AltaCarrera(nueva);

            //MessageBox.Show("La carrera ha sido agregada", "Información",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
