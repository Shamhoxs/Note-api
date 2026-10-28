using Microsoft.AspNetCore.Mvc;
using NoteAPI.Core.Dtos;
using NoteAPI.Core.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
[ApiExplorerSettings(IgnoreApi = false)]
// [ApiVersion("1.0")]
public class NotesController : ControllerBase
{
    private readonly INoteService notesService;
    public NotesController(INoteService _notesService)
    {
        notesService = _notesService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllNotes()
    {
        IReadOnlyList<NoteDto> notes = await notesService.GetAllNotes();
        return Ok(notes);
    }
}

