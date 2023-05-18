using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vista_usuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_cambiar_Click(object sender, EventArgs e)
    {
        Response.Redirect("cambio_usu.aspx");
    }

    protected void B_caninos_Click(object sender, EventArgs e)
    {
        Response.Redirect("ver_can.aspx");
    }


}