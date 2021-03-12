using MultiNote.Core.Entities;
using MultiNote.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MultiNote.Core.Interfaces
{
    public interface INoteRepository
    {
        void AddNote(NoteEntity note);
        Task<IEnumerable<NoteEntity>> GetNotesAsync();
        void DeleteNote(int id);
        Task UpdateNote(NoteEntity note);
    }
}
