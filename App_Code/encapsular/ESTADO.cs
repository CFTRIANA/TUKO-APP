using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ESTADO", Schema = "dbo")]
public class ESTADO
{
    [Key]
    public int Id_Est { get; set; }
    public string Descrip_Est { get; set; }

    public ICollection<USUARIO> USUARIOs { get; set; }
}