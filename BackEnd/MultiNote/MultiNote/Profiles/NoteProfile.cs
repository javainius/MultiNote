﻿using AutoMapper;
using MultiNote.Core.Entities;
using MultiNote.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiNote.API.Profiles
{
    public class NoteProfile : Profile
    {
        public NoteProfile()
        {
            CreateMap<NoteEntity, NoteView>();
        }
    }
}
