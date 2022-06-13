using Microsoft.EntityFrameworkCore;

public class Context:DbContext
{
  public Context(DbContextOptions<Context> options):base(options)
  {
    
  }
    public DbSet<Tbl_Doctor> Tbl_Doctors { get; set; }
    public DbSet<Tbl_Question> tbl_Questions { get; set; }
    public DbSet<Tbl_Category> Tbl_Categories { get; set; }
    public DbSet<Tbl_Choice> Tbl_Choices { get; set; }
    
     
    
    
    
    


    
    
    
}