using NoteAPI.Core.Dtos;

namespace NoteAPI.Core.Interfaces;

public interface INoteService
{
    Task<IReadOnlyList<NoteDto>> GetAllNotes();
}