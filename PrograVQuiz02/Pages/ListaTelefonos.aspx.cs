using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrograVQuiz02.Data;

namespace PrograVQuiz02.Pages
{
    public partial class ListaTelefonos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (PV_Quiz02Entities quiz02Entities = new PV_Quiz02Entities())
            {
                gv_Telefonos.DataSource = quiz02Entities.spConsultarTelefonos();
                gv_Telefonos.DataBind();
            }                 
        }

        protected void gv_Telefonos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType != DataControlRowType.DataRow) return;

            Label fechaLanzamientoLbl = (Label)e.Row.FindControl("fechaLanzamientoLbl");
            Label precioLbl = (Label)e.Row.FindControl("precioLbl");

            string fechaLanzamientoValue = DataBinder.Eval(e.Row.DataItem, "fechaLanzamiento").ToString();
            string precioValue = DataBinder.Eval(e.Row.DataItem, "precio").ToString();

            string formatedPrice = string.Format(new CultureInfo("en-US"), "{0:C0}", Int32.Parse(precioValue)).Replace(",", " ");

            string formatedDate = "";
            try
            {
                DateTime fechaCreacionValue = DateTime.ParseExact(fechaLanzamientoValue, "d/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                formatedDate = fechaCreacionValue.ToString("dd/MM/yyyy");
            }
            catch { }

            precioLbl.Text = formatedPrice;
            fechaLanzamientoLbl.Text = formatedDate;



        }
    }
}