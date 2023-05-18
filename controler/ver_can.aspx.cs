using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vista_ver_can : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GridView1.SelectedIndex >= 0)
        {
            // Obtener el valor del campo seleccionado
            string campoSeleccionado = GridView1.SelectedRow.Cells[1].Text; // Reemplaza 0 por el índice de la columna del campo que deseas guardar

            // Guardar el valor en una variable de sesión
            Session["CampoSeleccionado"] = campoSeleccionado;
        }
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        string campoSeleccionado = Session["CampoSeleccionado"] as string;

        // Redirigir a la otra vista y pasar el valor como parámetro en la URL
        Response.Redirect("Apadrinar.aspx?campo=" + campoSeleccionado);


    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("usuario.aspx");
    }

}