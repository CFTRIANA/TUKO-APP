using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("USUARIO", Schema = "dbo")]
public class USUARIO
{
    [Key]
    public int Id_Usu { get; set; }
    public string Nom_Usu { get; set; }
    public string Apell_Usu { get; set; }
    public string Direcc_Usu { get; set; }
    public string Correo_Usu { get; set; }
    public string Contra_Usu { get; set; }
    public string Telef_Usu { get; set; }
    
    //foranea
    [ForeignKey("ROL")]
    public int Id_Rol { get; set; }
    [ForeignKey("ESTADO")]
    public int Id_Est { get; set; }


    //tablas referenciadas
    public ROL ROLs { get; set; }
    public ESTADO ESTADOs { get; set; }

    public ICollection<APADRINAMIENTO> APADRINAMIENTOs { get; set; }
}