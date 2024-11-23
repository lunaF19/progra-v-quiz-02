using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrograVQuiz02.Pages
{
    public partial class Resultado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Request.QueryString["action"];
            
            switch(action)
            {
                case "C":
                    {
                        lblMessage.Text = "Ha registrado correctamente un nuevo teléfono en la base de datos";
                        break;
                    }

                case "U":
                    {
                        lblMessage.Text = "Ha modificado correctamente un nuevo teléfono en la base de datos";
                        break;
                    }

                case "D":
                    {
                        lblMessage.Text = "Ha eliminado correctamente la información de un teléfono en la base de datos";
                        break;
                    }
                default:
                    {
                        lblMessage.Text = "Acción no valida";
                        break;
                    }
            }

            
            
        }
    }
}