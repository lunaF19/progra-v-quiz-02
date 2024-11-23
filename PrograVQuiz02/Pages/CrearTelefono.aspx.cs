using PrograVQuiz02.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrograVQuiz02.Pages
{
    public partial class CrearTelefono : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime tomowrrowDate = DateTime.Now;
            DateTime fechaCreacionValue = DateTime.ParseExact(tomowrrowDate.ToString(), "d/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            string maxDate = fechaCreacionValue.ToString("yyyy-MM-dd");
            txtTelefonoFechaLanzamiento.Attributes.Add("max", maxDate);
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            string telefonoMarcaValue = txtTelefonoMarca.Text;
            string telefonoNombreValue = txtTelefonoNombre.Text;
            int telefonoPrecioValue = Int16.Parse(txtTelefonoPrecio.Text);
            int telefonoAnnoFabricacionValue = int.Parse(txtTelefonoAnnoFabricacion.Text);
            DateTime telefonoFechaLanzamientoValue = DateTime.Parse(txtTelefonoFechaLanzamiento.Text);

            using (PV_Quiz02Entities quiz02Entities = new PV_Quiz02Entities())
            {
                quiz02Entities.spCrearTelefono(telefonoMarcaValue, telefonoNombreValue, telefonoAnnoFabricacionValue, telefonoFechaLanzamientoValue, telefonoPrecioValue);
                Response.Redirect("/Pages/Resultado.aspx?action=C");
            }
        }
    }
}