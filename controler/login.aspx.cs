using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI;

public partial class vista_login : System.Web.UI.Page
{
  
    // back up de base de datos  en carpeta utilidad
    protected void Page_Load(object sender, EventArgs e)
    {
      
 
    }

    protected void B_login_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        Encriptar enc = new Encriptar();

        string nombre = Usu_nametxt.Text;
        string contraseña = enc.GetSHA256(Password.Text);
        usuarios datos = new usuarios();
        USUARIO usuariolog = datos.login(nombre, contraseña);
      


        //NAME == USER NAME
        if (usuariolog.Nom_Usu != null)
        {//NAME == USER NAME
            if (!usuariolog.Nom_Usu.Equals(""))
            {
                Session["usuario"] = usuariolog;
               
                int rol = usuariolog.Id_Rol;

                Session["id_rol_usu"] = rol;

                try
                {
                   

                    if (usuariolog.Id_Rol == 2)
                    {

                        Response.Redirect("administrador.aspx");
                    }
                    if (usuariolog.Id_Rol == 1)
                    {
                        Response.Redirect("usuario.aspx");

                    }
                }
                catch (Exception)
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Error enviando correo electronico');</script>");
                }
            }
            else
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('usuario o contraseña incorrectos');</script>");
            }

        }
        else
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('usuario o contraseña incorrectos');</script>");
        }
    }

    protected void B_registrar_Click(object sender, EventArgs e)
    {
        Response.Redirect("registro.aspx");
    }
    
}