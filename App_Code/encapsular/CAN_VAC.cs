using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("CAN_VAC", Schema = "dbo")]
public class CAN_VAC
{
    [Key]
    public int Id_Can_Vac { get; set; }
    public string Fecha { get; set; }
    public string Doctor { get; set; }
    public int Dosis { get; set; }
    
    [ForeignKey("CANINO")]
    public int Id_Can { get; set; }
    
    [ForeignKey("VACUNA")]
    public int Id_Vacu { get; set; }
   

    //TABALS REFERENCIADAS
    
    public CANINO CANINO { get; set; }
    public CANINO VACUNA { get; set; }

}