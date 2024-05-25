using Domain;

namespace BuissnesLogic.Dtos;

public class NoteDto
{
    public int Id{ get; set; }
    
    public string Title;
    
    public string Description;
    
    public UserDto? User { get; set; }

    public NoteDto(Note note)
    {
        Id = note.Id;
        Title = note.Title;
        Description = note.Description;
    }
    
}