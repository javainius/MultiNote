using System;
using System.Collections.Generic;
using System.Text;

namespace MultiNote.Core.Models
{
    public class NoteModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public NoteModel() { }

        public NoteModel(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
