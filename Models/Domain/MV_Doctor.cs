using System.ComponentModel.DataAnnotations;

public class MV_Doctor
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public string Gender { get; set; }
    public string States { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
   
    
}