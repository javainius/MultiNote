using MultiNote.Core.Entities;
using MultiNote.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiNote.Core.Interfaces
{
    public interface INoteRepository
    {
        void AddNote(NoteEntity note);
    }
}
