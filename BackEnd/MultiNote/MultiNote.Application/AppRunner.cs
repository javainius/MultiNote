using AutoMapper;
using MultiNote.Core.Interfaces;
using MultiNote.Core.Mappers;
using MultiNote.Core.Models;
using MultiNote.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MultiNote.Application
{
    public class AppRunner : IAppRunner
    {
        private INoteRepository _noteRepository;
        private readonly IMapper _mapper;

        public AppRunner(INoteRepository noteRepository, /*NotesMapper notesMapper,*/ IMapper mapper)
        {
            _noteRepository = noteRepository;
            //_notesMapper = notesMapper;
            _mapper = mapper;
        }

        public void AddNote(NoteModel note) => _noteRepository.AddNote(_notesMapper.ModelToEntity(note));

        public void DeleteNote(int id) => _noteRepository.DeleteNote(id);

        public async Task<IEnumerable<NoteDTO>> GetListOfNotes() 
        {
            var notes = await _noteRepository.GetNotesAsync();

            return _mapper.Map<IEnumerable<NoteDTO>>(notes);
        } 

        public void UpdateNote(NoteModel note) => _noteRepository.UpdateNote(_notesMapper.ModelToEntity(note));
    }
}
