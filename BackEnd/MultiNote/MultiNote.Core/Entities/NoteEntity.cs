using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace MultiNote.Core.Entities
{
    [Table("Notes")]
    public class NoteEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public NoteEntity() { }

        public NoteEntity(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
