using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Note
{
    public int Id { get; set; }
    
    [MaxLength(30)]
    public string Title { get; set; }
    
    [MaxLength(300)]
    public string Description { get; set; }
    
    public User User { get; set; }
}