using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vista_administrador : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Session["id_rol_usu"].Equals("2"))
        {

            Response.Redirect("usuario.aspx");
        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("registro_can.aspx");
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("cambio_can.aspx");
    }

    protected void Re_modif_Click(object sender, EventArgs e)
    {
        Response.Redirect("cambio_rol.aspx");
    }
}