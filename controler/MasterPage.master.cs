using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vista_MasterPage : System.Web.UI.MasterPage
{
    public static bool carga = true;
    protected void Page_Load(object sender, EventArgs e)
    {
        USUARIO datos = (USUARIO)Session["usuario"];

        string numero = datos.Telef_Usu;
        if (datos != null)
        {
            USUARIO user = new usuarios().login(datos.Nom_Usu, datos.Contra_Usu);
            if (user == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                if (user.Id_Est == 1)
                {
                    Session["usuario"] = user;
                }
                else
                {
                    Session["usuario"] = null;
                    Response.Redirect("login.aspx");
                }
                if (user.Id_Rol == 2 && carga)
                {
                    carga = false;
                    //NAME == USER NAME
                    L_info.Text = "Bienvenido Admin " + datos.Nom_Usu;
                    Response.Write("<script>alert('bienvenido administrador " + datos.Nom_Usu + "');window.location = 'administrador.aspx';</script>");
                }
                if (user.Id_Rol == 1 && carga)
                {
                    //NAME == USER NAME
                    carga = false;
                    L_info.Text = "Bienvenido User " + datos.Nom_Usu;
                    Response.Write("<script>alert('bienvenido usuario " + datos.Nom_Usu + "');window.location = 'usuario.aspx';</script>");
                }
            }
        }
        else
        {
            Response.Redirect("login.aspx");
        }
    }

    protected void B_cerrar_Click(object sender, EventArgs e)
    {
        Session["usuario"] = null;
        carga = true;
        Response.Write("<script>alert('regresa pronto');window.location = 'login.aspx';</script>");
    }
}
