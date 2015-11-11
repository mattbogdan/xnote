using System;
using System.Collections.Generic;

namespace XNOTE.Domain.Entities
{
    public class Note
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfChange { get; set; }
        public Category Category { get; set; }
        public virtual List<Tag> Tags { get; set; }
    }
}
