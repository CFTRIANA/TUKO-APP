using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("AUDITORIA", Schema = "dbo")]
public class AUDITORIA
{
    [Key]
    public int Id_Auditoria { get; set; }
    public string Descrip { get; set; }
    public string Fecha_Hora { get; set; }
    public int Id_Usu { get; set; }
   

    public ICollection<USUARIO> USUARIOs { get; set; }
}