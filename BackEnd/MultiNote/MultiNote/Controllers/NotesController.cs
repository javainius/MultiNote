using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiNote.Core.ViewModels;
using MultiNote.Core.Interfaces;
using static System.Net.Mime.MediaTypeNames;
using MultiNote.Core.Models;

namespace MultiNote.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly IAppRunner _application;

        public NotesController(IAppRunner application)
        {
            _application = application;
        }

        // GET: api/Notes
        [HttpGet]
        public async Task<IEnumerable<NoteView>> Get() => await _application.GetListOfNotes();

        // POST: api/Notes
        [HttpPost]
        public void Post([FromBody] NoteModel note) => _application.AddNote(note);

        // PUT: api/Notes
        [HttpPut]
        public StatusCodeResult Put([FromBody] NoteModel note)
        {
            _application.UpdateNote(note);
            return Ok();
        }

        // DELETE: api/Notes/5
        [HttpDelete("{id}")]
        public async Task<IEnumerable<NoteView>> Delete(int id)
        {
            _application.DeleteNote(id);
            return await _application.GetListOfNotes();
        }
    }
}
