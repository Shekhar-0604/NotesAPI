using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Notes.API.Data;
using Notes.API.Models.Entities;

namespace Notes.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class NotesController : Controller
	{
		private readonly NotesDbContext notesDbContext1;
		public NotesController(NotesDbContext notesDbContext)
		{
			this.notesDbContext1 = notesDbContext;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllNotes()
		{
			//Get the Notes from Database
			return Ok(await notesDbContext1.Notes.ToListAsync());
		}

		[HttpGet]
		[Route("{id:Guid}")]
		[ActionName("GetNoteById")]
		public async Task<IActionResult> GetNoteById([FromRoute] Guid id)
		{
			//await notesDbContext1.Notes.FirstOrDefaultAsync(x => x.Id == id);
			//or

			var note = await notesDbContext1.Notes.FindAsync(id);

			if (note == null)
			{
				return NotFound();
			}
			return Ok(note);
		}

		[HttpPost]
		public async Task<IActionResult> AddNote(Note note)
		{
			note.Id = Guid.NewGuid();
			await notesDbContext1.Notes.AddAsync(note);

			await notesDbContext1.SaveChangesAsync();

			return CreatedAtAction(nameof(GetNoteById), new { id = note.Id }, note);

		}

		[HttpPut]
		[Route("{id:Guid}")]
		public async Task<IActionResult> UpdateNote([FromRoute] Guid id, [FromBody] Note updateNote)
		{
			var existingNote = await notesDbContext1.Notes.FindAsync(id);

			if(existingNote == null)
			{
				return NotFound();
			}

			existingNote.Title = updateNote.Title;
			existingNote.Description = updateNote.Description;
			existingNote.IsVisible = updateNote.IsVisible;

			await notesDbContext1.SaveChangesAsync();

			return Ok(existingNote);
		}

		[HttpDelete]
		[Route("{id:Guid}")]

		public async Task<IActionResult> DeleteNote([FromRoute] Guid id)
		{
			var existingNote = await notesDbContext1.Notes.FindAsync(id);

			if( existingNote == null)
			{
				return NotFound();
			}

			notesDbContext1.Notes.Remove(existingNote);
			await notesDbContext1.SaveChangesAsync();

			return Ok();
		}
	}
}
