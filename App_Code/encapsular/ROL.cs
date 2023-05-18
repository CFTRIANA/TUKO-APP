using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.EnterpriseServices.Internal;

[Table("ROL", Schema = "dbo")]

public class ROL

{
    [Key]
    public int Id_Rol { get; set; }
    public string Nombre { get; set; }
    public ICollection<USUARIO> USUARIOs { get; set; }


}