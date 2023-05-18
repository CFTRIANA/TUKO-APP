using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ARCHIVO", Schema = "dbo")]

public class ARCHIVO

{
    [Key]
    public int Id_Archivo { get; set; }
    public string FechaSubida_Archivo { get; set; }
    public string Banco_Archivo { get; set; }
    public ICollection<APADRINAMIENTO> APADRINAMIENTOs { get; set; }


}