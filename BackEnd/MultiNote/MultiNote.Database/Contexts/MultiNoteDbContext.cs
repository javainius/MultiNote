using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MultiNote.Core.Entities;

namespace MultiNote.Database.Contexts
{
    public class MultiNoteDbContext : DbContext
    {
        public DbSet<NoteEntity> Notes { get; set; }

        public MultiNoteDbContext(DbContextOptions<MultiNoteDbContext> optionsBuilder) : base(optionsBuilder) { }
    }
}
