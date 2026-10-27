using Microsoft.AspNetCore.Mvc;
using NoteAPI.Core.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
[ApiExplorerSettings(IgnoreApi = false)]
// [ApiVersion("1.0")]
public class NotesController : ControllerBase
{
    private readonly INotesService notesService;
    public NotesController(INotesService _notesService)
    {
        notesService = _notesService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllNotes()
    {
        var notes = await notesService.GetAllNotes();
        return Ok(notes);
    }
}

