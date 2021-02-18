using MultiNote.Core.Interfaces;
using MultiNote.Core.Mappers;
using MultiNote.Core.Models;
using MultiNote.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiNote.Application
{
    public class Application : IApplication
    {
        private INoteRepository _noteRepository;
        private NotesMapper _notesMapper;

        public Application(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
            _notesMapper = new NotesMapper();
        }

        public void AddNote(NoteModel note) => _noteRepository.AddNote(_notesMapper.ModelToEntity(note));

        public void DeleteNote(int id) => _noteRepository.DeleteNote(id);

        public List<NoteView> GetListOfNotes() => _notesMapper.EntityListToViewModelList(_noteRepository.GetNotes());
    }
}
