using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI;

public partial class vista_registro_can : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
                                     
    }

    protected void B_registrar_Click(object sender, EventArgs e)
    {

        ClientScriptManager cm = this.ClientScript;


       
      
        string Ncan = Txt_nomcan.Text;
        int Craza = Int16.Parse(Txt_razacan.Text);
        // int Cvacun = Int16.Parse(Txt_vacu.Text);
        string Cvacun = Txt_vacu.Text;
        string Cedad = Txt_Edad.Text;
        string Cdesc = Txt_Descan.Text;
        string Cest = Txt_estcan.Text;
     

         
        CANINO guardarcan = new CANINO();
        guardarcan.Nom_Can = Ncan;
        guardarcan.Vacu_Can = Cvacun;
        guardarcan.Eda_Can = Cedad;
        guardarcan.Id_Raz_Can = Craza;
        guardarcan.Desc_Can = Cdesc;   
        guardarcan.Estd_Can = Cest;
      


        new caninos().insertarCaninos(guardarcan);

        // new usuarios().insertarUsuario(guardar)   ;window.location = 'administrador.aspx';;
       // Response.Write("<script>alert('el canino " + Ncan + " fue registrado EXITOSAMENTE');window.location = 'administrador.aspx'</script>");
       // cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('REGISTRO DE CANINO EXITOSO');window.location = 'registro_can.aspx';</script>");

        Response.Redirect("registro_can.aspx");
        //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('REGISTRO DE CANINO EXITOSO');</script>");
    }
  

    protected void TB_Uregistro_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Txt_contraseña_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        Response.Redirect("administrador.aspx");
    }

    protected void Txt_rol_TextChanged(object sender, EventArgs e)
    {

    }
}