using System.ComponentModel.DataAnnotations;

namespace Domain;

public class User
{
    public int Id { get; set; }
    
    [MaxLength(30)]
    public string Email { get; set; }
    
    [MaxLength(30)]
    public string Name { get; set; }
    
    [MaxLength(30)]
    public string Surname { get; set; }    
    
    public ICollection<Note> Notes { get; set; }

}
