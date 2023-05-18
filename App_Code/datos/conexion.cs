using System;
using System.Data.SqlClient;

class conexion
{
    static string servidor = "LAPTOP-4LDJI85N";
    static string BD = "Tuko";
    static string usuario = "tuko";
    static string clave = "cftr2208";

    static string conn = "server=" + servidor + ";database=" + BD + ";user id=" + usuario + ";password=" + clave + ";MultipleActiveResultSets=true";
    //mi conexion:
    SqlConnection con = new SqlConnection(conn);

    //procedimiento que abre la conexion sqlsever
    public void conectar()
    {
        try
        {
            con.Open();
        }
        catch (Exception ex)
        {
        }
    }

    //procedimiento que cierra la conexion sqlserver
    public void desconectar()
    {
        con.Close();
    }

    //funcion que devuelve la conexion sqlserver
    public SqlConnection CONN()
    {
        return con;
    }
}