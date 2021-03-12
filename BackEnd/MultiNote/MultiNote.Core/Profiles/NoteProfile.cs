using AutoMapper;
using MultiNote.Core.Entities;
using MultiNote.Core.Models;
using MultiNote.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiNote.Core.Profiles
{
    class NoteProfile : Profile
    {
        public NoteProfile()
        {
            //CreateMap<NoteModel, NoteView>();
            CreateMap<NoteEntity, NoteView>();

        }
    }
}
