using System;
using System.Collections.Generic;
using System.Text;

namespace MultiNote.Core.ViewModels
{
    public class NoteView
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public NoteView() { }

        public NoteView(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}

