using MultiNote.Core.Models;
using MultiNote.Core.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MultiNote.Core.Interfaces
{
    public interface IAppRunner
    {
        void AddNote(NoteModel note);
        Task<IEnumerable<NoteDTO>> GetListOfNotes();
        void DeleteNote(int id);
        void UpdateNote(NoteModel note);
    }
}
