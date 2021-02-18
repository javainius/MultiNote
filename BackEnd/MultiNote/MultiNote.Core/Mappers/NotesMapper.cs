using AutoMapper;
using MultiNote.Core.Entities;
using MultiNote.Core.Models;
using MultiNote.Core.ViewModels;
using System;
using System.Collections.Generic;
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

        public NoteView EntityToView(NoteEntity point) => _iMapperNoteEntityToNoteView.Map<NoteEntity, NoteView>(point);

        public NoteEntity ModelToEntity(NoteModel point) => _iMapperNoteModelToNoteEntity.Map<NoteModel, NoteEntity>(point);
    }
}
