using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static System.Data.Entity.Infrastructure.Design.Executor;

public class caninos
{
    public void insertarCaninos(CANINO caninos)
    {
        conexion conexion = new conexion();
        conexion.conectar();

    

        string SQL = "INSERT INTO Tuko.dbo.[CANINO] (Nom_Can ,Vacu_Can, Eda_Can, Desc_Can ,  Estd_Can , Id_Raz_Can) " +
               "VALUES ('" + caninos.Nom_Can + "','" + caninos.Vacu_Can + "','" + caninos.Eda_Can + "','"  + caninos.Desc_Can + "','" + caninos.Estd_Can + "'," + caninos.Id_Raz_Can + "); ";

        using (SqlCommand command = new SqlCommand(SQL, conexion.CONN()))
        {
            int comando = command.ExecuteNonQuery();
            if (comando == 1)
            {
                Console.WriteLine("bien  CANINO");
            }
            else
            {
                Console.WriteLine("mal CANINO");
            }
        }
        conexion.desconectar();
    
    }

    public void caninocambiar(string nombre,string edad  , string campocambio,string valorcambio)
    {

        conexion conexion = new conexion();
        conexion.conectar();

       

        string SQL = "UPDATE Tuko.dbo.[CANINO] SET " + campocambio + " = '" + valorcambio + "' WHERE Nom_Can = '" + nombre + "' AND Eda_Can = '" + edad + "';";

      
        using (SqlCommand command = new SqlCommand(SQL, conexion.CONN()))
        {
            int comando = command.ExecuteNonQuery();
            if (comando == 1)
            {
                Console.WriteLine("bien cambio");
            }
            else
            {
                Console.WriteLine("mal cambio");
            }
        }
        conexion.desconectar();


    }

    public CANINO apadrinar (string id)
    {

        //consulta SQL
        string SQL = "SELECT * FROM Tuko.dbo.[CANINO] WHERE Id_Can = " + id + ";";
     
        conexion conexion = new conexion();
        conexion.conectar();
        CANINO Ncan = new CANINO();
        using (SqlCommand command = new SqlCommand(SQL, conexion.CONN()))
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Ncan.Id_Can = reader.GetInt32(0);
                    Ncan.Nom_Can = reader.GetString(1);
                    Ncan.Vacu_Can = reader.GetString(2);
                    Ncan.Eda_Can = reader.GetString(3);
                    Ncan.Desc_Can = reader.GetString(4);
                    Ncan.Estd_Can = reader.GetString(5);
                   
                }
            }
        }
        conexion.desconectar();
        return Ncan;


    
    }
    public void insertaruta( string ruta)
    {
        conexion conexion = new conexion();
        conexion.conectar();


       
        string SQL = "INSERT INTO Tuko.dbo.[ARCHIVO] (FechaSubida_Archivo , Banco_Archivo) " +
               "VALUES ('"+ DateTime.Now + "','" + ruta +"');";

        using (SqlCommand command = new SqlCommand(SQL, conexion.CONN()))
        {
            int comando = command.ExecuteNonQuery();
            if (comando == 1)
            {
                Console.WriteLine("bien  Archivo");
            }
            else
            {
                Console.WriteLine("mal archcvo");
            }
        }
        conexion.desconectar();

    }
}
   

