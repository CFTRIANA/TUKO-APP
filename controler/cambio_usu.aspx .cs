using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI.WebControls;

public partial class vista_cambio_usu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Benviar_Click(object sender, EventArgs e)
    {


        string valorSeleccionado = Seleccion_cambio.SelectedValue;
        string contraseña;
        string cambio = Txt_cambio.Text;
        string nom_usu = txt_usu_nombre.Text;
        string apell_usu = txt_usu_apelli.Text;
        string correo_usu = txt_usu_correo.Text;

        if (valorSeleccionado.Equals("Contra_Usu")){
            contraseña = GetSHA256(cambio);
            new usuarios().cambiarusuario(nom_usu, apell_usu, correo_usu, valorSeleccionado, contraseña);

            USUARIO datos = (USUARIO)Session["usuario"];
            Session["usuario"] = null;
            Response.Redirect("login.aspx");
        }
        else
        {
            new usuarios().cambiarusuario(nom_usu, apell_usu, correo_usu, valorSeleccionado, cambio);

        }
    
        Response.Redirect("cambio_usu.aspx");
    }

    protected void Txt_cambio_TextChanged(object sender, EventArgs e)
    {

    }



    protected void Seleccion_cambio_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    public string GetSHA256(string str)
    {
        SHA256 sha256 = SHA256Managed.Create();
        ASCIIEncoding encoding = new ASCIIEncoding();
        byte[] stream = null;
        StringBuilder sb = new StringBuilder();
        stream = sha256.ComputeHash(encoding.GetBytes(str));
        for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
        return sb.ToString();
    }

  
    protected void Bvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("usuario.aspx");
    }
}