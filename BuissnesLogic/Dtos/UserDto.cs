namespace BuissnesLogic.Dtos;

public class UserDto
{
    public int Id{ get; set; }
    
    public string Email;
    
    public string Name;
    
    public string Surname;
    
    public ICollection<NoteDto> Notes { get; set; }
    
}