using NoteAPI.Core.Dtos;
using NoteAPI.Core.Interfaces;

namespace NoteAPI.Core.Services;

public class NoteService: INoteService
{
    private readonly INoteService noteService;

    public NoteService(INoteService _notesService)
    {
        noteService = _notesService;
    }

    public async Task<IReadOnlyList<NoteDto>> GetAllNotes()
    {
        return await noteService.GetAllNotes();
    }
}
