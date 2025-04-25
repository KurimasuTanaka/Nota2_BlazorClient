using System;
using System.Security.Cryptography.X509Certificates;
using Nota.Data;
using System.Net.Http;
using System.Net;

namespace Nota2.Services.NotaAPI;

public class NotaApi : INotaApi
{
    static HttpClient client = new HttpClient();

    string basePath = "http://localhost:5000/";

    public async Task<HttpStatusCode> DeleteNote(int noteId)
    {
        HttpResponseMessage response = await client.DeleteAsync(
            $"notes/{noteId}"
        );
        return response.StatusCode;
    }

    public async Task<Note?> GetNote(int noteId)
    {
        Note? note = null;

        string requestString = basePath + "notes/" + noteId.ToString();
        HttpResponseMessage response = await client.GetAsync(requestString);

        if (response.IsSuccessStatusCode)
        {
            note = await response.Content.ReadAsAsync<Note>();
        }

        return note;
    }

    public async Task<List<Note?>> GetNotes(string[]? tags = null)
    {
        List<Note?> notes = new();
        HttpResponseMessage response;

        if (tags is null)
        {
            string requestString = basePath + "notes";

            response = await client.GetAsync(requestString);

            if (response.IsSuccessStatusCode)
            {
                notes = await response.Content.ReadAsAsync<List<Note?>>();
            }
        }
        else
        {
            string requestString = basePath + "notes/tagged/";

            response = await client.GetAsync(requestString);

            if (response.IsSuccessStatusCode)
            {
                notes = await response.Content.ReadAsAsync<List<Note?>>();
            }

        }

        return notes;
    }

    public Task<Note> UpdateNote(Note note)
    {
        throw new NotImplementedException();
    }
}
