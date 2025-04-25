using System;

namespace Nota.Data;

public enum NoteType
{
    TextNote,
    ImageNote,
    VideoNote
}
public class Note
{
    public int NoteId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public NoteType NoteType { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

}
