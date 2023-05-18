using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("VACUNA", Schema = "dbo")]
public class VACUNA
{
    [Key]
    public int Id_Vacu { get; set; }
    public string Nom_cient { get; set; }
    public string Finalidad { get; set; }
    public string Fecha_Crea { get; set; }
    public string Fecha_Vence { get; set; }
    public int Num_Invima { get; set; }
    public int Dosis { get; set; }
  
    public ICollection<CAN_VAC> CAN_VACs { get; set; }
}