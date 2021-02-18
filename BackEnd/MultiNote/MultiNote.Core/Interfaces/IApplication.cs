using MultiNote.Core.Models;
using MultiNote.Core.ViewModels;
using System.Collections.Generic;

namespace MultiNote.Core.Interfaces
{
    public interface IApplication
    {
        void AddNote(NoteModel note);
        List<NoteView> GetListOfNotes();
        void DeleteNote(int id);

    }
}
