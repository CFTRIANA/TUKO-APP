using System;
using System.Data.SqlClient;
using System.Linq;

public class usuarios
{

    public void cambiarusuario(string nombre, string apellido, string correo,string seleccion, string valorcambio)
    {

        conexion conexion = new conexion();
        conexion.conectar();



        string SQL = "UPDATE Tuko.dbo.[USUARIO] SET " + seleccion + " = '" + valorcambio + "' WHERE Nom_Usu = '" + nombre 
            + "' AND Apell_Usu = '" + apellido + "' AND Correo_Usu = '" + correo + "';";

        // string SQL = "UPDATE Tuko.dbo[CANINO] SET "+ columna + " = '"+ valorcambio +"' WHERE Nom_Can = '" + nombre + "'AND Eda_Can ='"+ edad +"';";

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

    public void cambiarRol(string nombre, string apellido, string correo, string rol)
    {

        conexion conexion = new conexion();
        conexion.conectar();




        string SQL = "UPDATE Tuko.dbo.[USUARIO] SET Id_Rol = " + rol + " WHERE Nom_Usu = '" + nombre + 
            "' AND Apell_Usu = '" + apellido + "' AND Correo_Usu = '" + correo + "';";

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
    public void insertarUsuario(USUARIO usuarios)
    {
        conexion conexion = new conexion();
        conexion.conectar();
        //consulta SQL
        /*  string SQL = "INSERT INTO Tuko.dbo.[USUARIO] (id_role,id_state,name,username,password,Direcc_Usu) "
        +"VALUES (" + usuarios.Id_Rol + "," + usuarios.Id_Est + ",'" + usuarios.Nom_Usu +
        "','" + usuarios.Apell_Usu + "','" + usuarios.Contra_Usu + "');";*/

        //talvez error de comilla
        /*string SQL = "INSERT INTO Tuko.dbo.[USUARIO] (Nom_Usu , Apell_Usu , Direcc_Usu , Correo_Usu , Contra_Usu ,Telef_Usu,Id_Rol,Id_Est) "
                    + "VALUES (" + usuarios.Nom_Usu + "," + usuarios.Apell_Usu + ",'" + usuarios.Direcc_Usu +
                    "','" + usuarios.Correo_Usu + "','" + usuarios.Contra_Usu + "','" + usuarios.Telef_Usu + "','" + usuarios.Id_Rol +
                     "','" + usuarios.Id_Est + "');";*/

        string SQL = "INSERT INTO Tuko.dbo.[USUARIO] (Nom_Usu , Apell_Usu , Direcc_Usu , Correo_Usu , Contra_Usu ,Telef_Usu,Id_Rol,Id_Est) " +
                    "VALUES ('"+ usuarios.Nom_Usu+"','"+usuarios.Apell_Usu+"','"+usuarios.Direcc_Usu+"','"+usuarios.Correo_Usu+"','"+usuarios.Contra_Usu+
                    "','"+usuarios.Telef_Usu+ "',"+usuarios.Id_Rol+","+ usuarios.Id_Est+"); ";
    
        using (SqlCommand command = new SqlCommand(SQL, conexion.CONN()))
        {
            int comando = command.ExecuteNonQuery();
            if (comando == 1)
            {
                Console.WriteLine("bien");
            }
            else
            {
                Console.WriteLine("mal");
            }
        }
        conexion.desconectar();
        /*using (var db = new TESTContext())
        {
            db.USUARIOs.Add(usuarios);
            db.SaveChanges();
        }*/

    }


    public USUARIO login(string usuario, string contrasena)
    {
        
        //consulta SQL
        string SQL = "SELECT * FROM Tuko.dbo.[USUARIO] WHERE Nom_Usu = '" + usuario + "' AND Contra_Usu = '" + contrasena + "';";
        conexion conexion = new conexion();
        conexion.conectar();
        USUARIO eusuario = new USUARIO();
        using (SqlCommand command = new SqlCommand(SQL, conexion.CONN()))
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    eusuario.Id_Usu = reader.GetInt32(0);
                    eusuario.Nom_Usu = reader.GetString(1);
                    eusuario.Apell_Usu = reader.GetString(2);
                    eusuario.Direcc_Usu = reader.GetString(3);
                    eusuario.Correo_Usu = reader.GetString(4);
                    eusuario.Contra_Usu = reader.GetString(5);
                    eusuario.Telef_Usu = reader.GetString(6);
                    eusuario.Id_Rol = reader.GetInt32(7);
                    eusuario.Id_Est = reader.GetInt32(8);
                }
            }
        }
        conexion.desconectar();
        return eusuario;
        
        
/*      /*
        using (var db = new TESTContext())
        {
            var user = (USUARIO)db.USUARIOs.Where(u => u.Nom_Usu.Equals(usuario)).Where(c => c.Contra_Usu.Equals(contrasena)).FirstOrDefault();
            return user;
        }*/
    }


}