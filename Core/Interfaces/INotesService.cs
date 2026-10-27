using NoteAPI.Core.Entities;

namespace NoteAPI.Core.Interfaces;

public interface INotesService
{
    Task<IReadOnlyList<Note>> GetAllNotes();
}