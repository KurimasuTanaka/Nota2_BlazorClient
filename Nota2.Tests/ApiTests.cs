using Nota.Data;
using Nota2.Services.NotaAPI;

namespace Nota2.Tests;

public class ApiTests
{
    [Fact]
    public async Task GetNoteByIdAsync()
    {
        //Arrange
        
        INotaApi notaApi = new NotaApi();

        int noteId = 1;
        //Act

        Note? recivedNote = await notaApi.GetNote(noteId);

        //Assert
    
        Assert.NotNull(recivedNote);
        Assert.Equal("Title 1", recivedNote.Title);
    }
}
