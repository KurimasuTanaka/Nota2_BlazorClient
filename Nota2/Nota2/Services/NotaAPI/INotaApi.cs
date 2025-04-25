using System;
using System.Net;
using Nota.Data;

namespace Nota2.Services.NotaAPI;

public interface INotaApi
{
    public Task<List<Note>> GetNotes(string[]? tags = null);
    public Task<Note?> GetNote(int noteId);
    public Task<Note> UpdateNote(Note note);
    public Task<HttpStatusCode> DeleteNote(int noteId);
}
