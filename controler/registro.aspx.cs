using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI;

public partial class vista_registro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
                                     
    }

    protected void B_registrar_Click(object sender, EventArgs e)
    {

        ClientScriptManager cm = this.ClientScript;


       
        int state = 1;
        string Nusu = Txt_nombre.Text;
        string Ncon = Txt_contraseña.Text;
        string Ccon = Txt_contraseñaCon.Text;
        string Unum = Txt_telefono.Text;
        string Napell = Txt_apellido.Text;
        string Ndirec = Txt_Direccion.Text;
        string Ncorr = Txt_Correo.Text;
         
        USUARIO guardar = new USUARIO();
        guardar.Nom_Usu = Nusu;
        guardar.Apell_Usu = Napell;
        guardar.Direcc_Usu = Ndirec;
        guardar.Correo_Usu = Ncorr;
        guardar.Telef_Usu = Unum;

        //CONFIRMACION DE CONTRASEÑA
        if (Ccon.Equals(Ncon))
        {
            guardar.Contra_Usu = GetSHA256(Ncon);

        }
        else
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Error CONTRASEÑAS NO COINCIDEN');</script>");

        }
      

        //CODIGO PARA INSERTAR ADMINISTRADOR

        int role;

        string Crole = Txt_rol.Text;
        if (Crole.Equals("2509"))
        {
            role = 2;
        }
        else
        {
            role = 1;
        }
        guardar.Id_Rol = role;
        guardar.Id_Est = state;

        // crea el usuario para guardar 

        new usuarios().insertarUsuario(guardar);


        Response.Redirect("login.aspx");
        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('REGISTRO EXITOSO');</script>");
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

    protected void TB_Uregistro_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Txt_contraseña_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }

    protected void Txt_rol_TextChanged(object sender, EventArgs e)
    {

    }
}