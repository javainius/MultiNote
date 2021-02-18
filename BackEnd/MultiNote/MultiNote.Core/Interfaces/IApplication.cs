using MultiNote.Core.Models;
using MultiNote.Core.ViewModels;

namespace MultiNote.Core.Interfaces
{
    public interface IApplication
    {
        void AddNote(NoteModel note);
    }
}
