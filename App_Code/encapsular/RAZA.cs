using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("RAZA", Schema = "dbo")]

public class RAZA

{
    [Key]
    public int Id_Raz_Can { get; set; }
    public string Nom_Can_Raz { get; set; }

    public ICollection<CANINO> CANINOs { get; set; }


}