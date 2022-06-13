using System.ComponentModel.DataAnnotations;

public class Tbl_Question
{
    [Key]
   public int Id { get; set; }
    public int Id_Category { get; set; }
    public string Question { get; set; }
    public string Question_Type { get; set; }
    public bool Status { get; set; }
    public bool Request { get; set; }
    public string Access { get; set; }
    public int Question_Number { get; set; }
    public int ParentId { get; set; }
    
    
    
    
   
    
}