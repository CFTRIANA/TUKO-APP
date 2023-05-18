using System.Data.Entity;


public class TESTContext : DbContext
{
    public TESTContext() : base("TEST")
    {

    }

    public DbSet<APADRINAMIENTO> APADRINAMIENTOs { get; set; }
    public DbSet<ARCHIVO> ARCHIVOSs { get; set; }
    public DbSet<AUDITORIA> AUDITORIAs { get; set; }
    public DbSet<CAN_VAC> CAN_VACs { get; set; }
    public DbSet<CANINO> CANINOs { get; set; }
    public DbSet<ESTADO> ESTADOs { get; set; }
    public DbSet<RAZA> RAZAs { get; set; }
    public DbSet<ROL> ROLs { get; set; }
    public DbSet<USUARIO> USUARIOs { get; set; }
    public DbSet<VACUNA> VACUNAs { get; set; }
  

    public static TESTContext Create()
    {
        return new TESTContext();
    }
}