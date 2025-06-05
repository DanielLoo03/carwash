using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocios;

namespace presentacion
{
    public partial class Bitacora : Form
    {

        private LogicaNegocios logicaNegocios = new LogicaNegocios();

        public Bitacora()
        {
            InitializeComponent();
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {

            //Se realiza consulta respecto al día actual 
            dtReap_ValueChanged(sender, e);

            //Se establece que la fecha máximo a elegir es el día actual
            dtReap.MaxDate = DateTime.Today;

        }

        private void dtReap_ValueChanged(object sender, EventArgs e)
        {

            //Se obtiene la fecha seleccionada en el DateTimePicker
            DateTime fecha = dtReap.Value.Date;

            //Se obtiene el resultado del query para consultar la reapertura según la fecha
            DataTable resultado = logicaNegocios.ConsBit(fecha);

            //Condición: Si se registró una reapertura en la fecha seleccionada
            if (resultado.Rows.Count != 0)
            {

                //Se cargan campos con los datos correspondientes de la reapertura
                txtAdmin.Text = logicaNegocios.ConsNomAdmin((int)resultado.Rows[0]["idAdmin"]).Rows[0]["nombreUsuario"].ToString();
                txtFechaHora.Text = resultado.Rows[0]["fechaHora"].ToString();
                txtDesc.Text = resultado.Rows[0]["descripcion"].ToString();

                //Se esconde mensaje, no es necesario 
                lblNoReap.Visible = false;

            }
            //Condición: Si no se registró una reapertura en la fecha seleccionada
            else
            {

                //Se limpian los campos, ya que no hay reapertura
                txtAdmin.Text = "";
                txtFechaHora.Text = "";
                txtDesc.Text = "";

                //Se muestra mensaje que avisa que no hay reapertura
                lblNoReap.Visible = true;

            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
