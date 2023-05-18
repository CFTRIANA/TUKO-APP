using System;
using System.Web.UI.WebControls;

public partial class vista_cambio_can : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Benviar_Click(object sender, EventArgs e)
    {

        string valorSeleccionado = Seleccion_cambio.SelectedValue;
        string cambio = Txt_cambio.Text;
        string nom_can = txt_can_nom.Text;
        string edad_can = txt_can_edad.Text;

        new caninos().caninocambiar(nom_can, edad_can,valorSeleccionado, cambio);

        Response.Redirect("cambio_can.aspx");
    }

    protected void Txt_cambio_TextChanged(object sender, EventArgs e)
    {

    }



    protected void Seleccion_cambio_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Bvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("administrador.aspx");
    }
}