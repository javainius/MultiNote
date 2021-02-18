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
        private readonly IApplication _application;

        public NotesController(IApplication application)
        {
            _application = application;
        }
        
        // GET: api/Notes
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST: api/Notes
        [HttpPost]
        public void Post([FromBody] NoteModel note)
        {
            _application.AddNote(note);
        }

        // PUT: api/Notes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
