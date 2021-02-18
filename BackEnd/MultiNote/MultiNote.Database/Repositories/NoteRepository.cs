using MultiNote.Core.Entities;
using MultiNote.Core.Interfaces;
using MultiNote.Database.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        } 

        public List<NoteEntity> GetNotes() =>_context.Notes.ToList();  
        
    }
}
