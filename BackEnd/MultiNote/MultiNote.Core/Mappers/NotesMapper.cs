using AutoMapper;
using MultiNote.Core.Entities;
using MultiNote.Core.Models;
using MultiNote.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiNote.Core.Mappers
{
    public class NotesMapper
    {
        private IMapper _iMapperNoteEntityToNoteView { get; set; }
        private IMapper _iMapperNoteModelToNoteEntity { get; set; }


        public NotesMapper()
        {
            _iMapperNoteEntityToNoteView = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<NoteEntity, NoteView>();
            }).CreateMapper();

            _iMapperNoteModelToNoteEntity = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<NoteModel, NoteEntity>();
            }).CreateMapper();
        }

        public List<NoteView> EntityListToViewModelList(List<NoteEntity> notes)
        {
            var list = new List<NoteView>();

            list.AddRange(notes.Select(note => _iMapperNoteEntityToNoteView
            .Map<NoteEntity, NoteView>(note)));

            return list;
        }

        public NoteView EntityToView(NoteEntity note) => _iMapperNoteEntityToNoteView.Map<NoteEntity, NoteView>(note);

        public NoteEntity ModelToEntity(NoteModel note) => _iMapperNoteModelToNoteEntity.Map<NoteModel, NoteEntity>(note);
    }
}
