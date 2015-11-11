using System;
using System.Collections.Generic;

namespace XNOTE.Domain.Entities
{
    public class Tag
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public int Color { get; set; }
        public List<Note> Notes { get; set; }
    }
}
