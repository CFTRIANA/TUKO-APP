using System;
using System.Web.UI.WebControls;

public partial class vista_cambio_rol : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Benviar_Click(object sender, EventArgs e)
    {

        string rol = Seleccion_rol.SelectedValue;
        string nombre = Txt_nombre.Text;
        string apellido = txt_apellido.Text;
        string correo = txt_correo.Text;
        string clave = txt_clave.Text;

        if (clave.Equals("534379"))
        {
            new usuarios().cambiarRol(nombre,apellido,correo,rol);
            string script = "alert('¡cambio correcto¡');window.location.href='cambio_rol.aspx'"; 
            ClientScript.RegisterStartupScript(this.GetType(), "alerta", script, true);
            //Response.Redirect("cambio_rol.aspx");
        }
        else
        {
            string script = "alert('¡CODIGO INCORRECTO! ingresa de nuevo la clave');";
            ClientScript.RegisterStartupScript(this.GetType(), "alerta", script, true);
        }
        
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