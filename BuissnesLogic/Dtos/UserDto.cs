using Domain;

namespace BuissnesLogic.Dtos;

public class UserDto
{
    public int Id;
    
    public string Email = string.Empty;

    public string Name = string.Empty;
    
    public string Surname = string.Empty;

    public List<NoteDto>? Notes = new List<NoteDto>();
    
    public UserDto(User u)
    {
        Id = u.Id;
        Email = u.Email;
        Name = u.Name;
        Surname = u.Surname;
        if (u.Notes != null) Notes = u.Notes.ToList().ConvertAll(n => new NoteDto(n));
    }

    public UserDto()
    {
        
    }
}