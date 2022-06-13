using System.ComponentModel.DataAnnotations;

public class Tbl_Choice
{
    [Key]
    public int Id { get; set; }
    public string ItemName { get; set; }

    public int NumberQuestion { get; set; }
    public int CategoryId { get; set; }
    public int SubquestionId { get; set; }
    
    
}