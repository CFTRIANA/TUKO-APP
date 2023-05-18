using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("CANINO", Schema = "dbo")]
public class CANINO
{
    [Key]
    public int Id_Can { get; set; }
    public string Nom_Can { get; set; }
    public string Vacu_Can { get; set; }
    public string Eda_Can { get; set; }
    public string Desc_Can { get; set; }
    public string Estd_Can { get; set; }
    
    [ForeignKey("RAZA")]
    public int Id_Raz_Can { get; set; }
 

    //tablas referenciadas
    public RAZA RAZA { get; set; }

    public ICollection<CAN_VAC> CAN_VACs { get; set; }
    public ICollection<APADRINAMIENTO> APADRINAMIENTOs { get; set; }

}