using MultiNote.Core.Entities;
using MultiNote.Core.Interfaces;
using MultiNote.Database.Contexts;
using System;
using System.Collections.Generic;
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
    }
}
