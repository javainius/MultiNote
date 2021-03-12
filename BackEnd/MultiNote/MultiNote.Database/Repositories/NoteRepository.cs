using Microsoft.EntityFrameworkCore;
using MultiNote.Core.Entities;
using MultiNote.Core.Interfaces;
using MultiNote.Database.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiNote.Database.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private MultiNoteDbContext _context;

        public NoteRepository(MultiNoteDbContext context)
        {
            _context = context;
        }

        public void AddNote(NoteEntity note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
        }

        public void DeleteNote(int id)
        {
            _context.Remove(_context.Notes.Where(note => note.Id.Equals(id)).FirstOrDefault());
            _context.SaveChanges();
        }

        public async Task<IEnumerable<NoteEntity>> GetNotesAsync() => await _context.Notes.ToListAsync();

        public async Task UpdateNote(NoteEntity note)
        {
            var noteToUpdate = _context.Notes.SingleOrDefault(noteInList => noteInList.Id.Equals(note.Id));

            if (noteToUpdate != null)
            {
                noteToUpdate.Content = note.Content;
                noteToUpdate.Title = note.Title;
                await _context.SaveChangesAsync();
            }
        }
    }
}
