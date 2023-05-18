using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vista_Apadrinar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {




            // Obtener el valor de la variable de sesión
            string campoSeleccionado = Request.QueryString["campo"];

            // Realizar acciones con el valor de la selección
          
            Label1.Text = campoSeleccionado;

       
         
                // La conversión fue exitosa, el valor se encuentra en id
                caninos datos = new caninos();
                CANINO caninodatos = datos.apadrinar(campoSeleccionado);


            id_l.Text = campoSeleccionado;
            nom_l.Text = caninodatos.Nom_Can;
            vacu_l.Text = caninodatos.Vacu_Can;
            edad_l.Text = caninodatos.Eda_Can;
            desc_l.Text = caninodatos.Desc_Can;
            if (caninodatos.Estd_Can.Equals("1")){


                estado_l.Text = "Para adoptar";

            }
            if (caninodatos.Estd_Can.Equals("2"))
            {


                estado_l.Text = "enfermo";
            }
              
                
      

        }


    }

    protected void B_subir_Click(object sender, EventArgs e)
    {
        if (Archivo_pago.HasFile == true)
        {

            string nombre = Archivo_pago.FileName;
            string ruta = "~/comprobantes/" + nombre;
            Archivo_pago.SaveAs(Server.MapPath(ruta));

            new caninos().insertaruta(ruta);

            Response.Redirect("ver_can.aspx");




        }


    }

    protected void Bvoler_Click(object sender, EventArgs e)
    {

        Response.Redirect("ver_can.aspx");
    }
}