using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("APADRINAMIENTO", Schema = "dbo")]
public class APADRINAMIENTO
{
    [Key]
    public int Id_Apadri { get; set; }
    public string Nom_Can { get; set; }
    public string Fecha_Apadri { get; set; }

    [ForeignKey("USUARIO")]
    public int Id_Usu { get; set; }
    
    [ForeignKey("CANINO")]
    public int Id_Can { get; set; }
    
    [ForeignKey("ARCHIVO")]
    public int Id_Archivo { get; set; }
   

    //tablas referenciadas
    public ARCHIVO ARCHIVO { get; set; }
    public CANINO CANINO { get; set; }
    public USUARIO USUARIO{ get; set; }

    public ICollection<CANINO> CANINOs { get; set; }
}