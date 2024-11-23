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
    public partial class EditarTelefono : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime tomowrrowDate = DateTime.Now;
            DateTime fechaCreacionValue = DateTime.ParseExact(tomowrrowDate.ToString(), "d/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            string maxDate = fechaCreacionValue.ToString("yyyy-MM-dd");

            txtTelefonoFechaLanzamiento.Attributes.Add("max", maxDate);
            string idTelefonoQueryParam = Request.QueryString["id"];
            if (idTelefonoQueryParam == null) return;


            int idTelefono = Int16.Parse(idTelefonoQueryParam);

            if (!IsPostBack)
            {
                using (PV_Quiz02Entities quiz02Entities = new PV_Quiz02Entities())
                {
                    spConsultarTelefonoPorId_Result  resultGetTelefono = quiz02Entities.spConsultarTelefonoPorId(idTelefono).First();
                    txtTelefonoMarca.Text = resultGetTelefono.marca;
                    txtTelefonoNombre.Text = resultGetTelefono.nombre;
                    txtTelefonoAnnoFabricacion.Text = resultGetTelefono.anhoFabricacion.ToString();
                    txtTelefonoPrecio.Text = resultGetTelefono.precio.ToString();
                    

                   try
                    {
                        DateTime fechaCreacionValue = DateTime.ParseExact(resultGetTelefono.fechaLanzamiento.ToString(), "d/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                        txtTelefonoFechaLanzamiento.Text = fechaCreacionValue.ToString("yyyy-MM-dd");
                   }
                   catch { }

                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string idTelefonoQueryParam = Request.QueryString["id"];
            if (idTelefonoQueryParam == null) return;

            int idTelefono = Int16.Parse(idTelefonoQueryParam);

            string telefonoMarcaValue = txtTelefonoMarca.Text;
            string telefonoNombreValue = txtTelefonoNombre.Text;
            int telefonoPrecioValue = Int16.Parse(txtTelefonoPrecio.Text);
            int telefonoAnnoFabricacionValue = int.Parse(txtTelefonoAnnoFabricacion.Text);
            DateTime telefonoFechaLanzamientoValue = DateTime.Parse(txtTelefonoFechaLanzamiento.Text);

            using (PV_Quiz02Entities quiz02Entities = new PV_Quiz02Entities())
            {
                quiz02Entities.spEditarTelefono(idTelefono, telefonoMarcaValue, telefonoNombreValue, telefonoAnnoFabricacionValue, telefonoFechaLanzamientoValue, telefonoPrecioValue);
                Response.Redirect("/Pages/Resultado.aspx?action=U");
            }

            
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string idTelefonoQueryParam = Request.QueryString["id"];
            if (idTelefonoQueryParam == null) return;

            int idTelefono = Int16.Parse(idTelefonoQueryParam);
            using (PV_Quiz02Entities quiz02Entities = new PV_Quiz02Entities())
            {
                quiz02Entities.spEliminarTelefono(idTelefono);
                Response.Redirect("/Pages/Resultado.aspx?action=D");
            }
                
        }
    }
}