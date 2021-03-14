using AutoMapper;
using MultiNote.Core.Entities;
using MultiNote.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiNote.Core.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NoteEntity, NoteDTO>();
        }
    }
}
