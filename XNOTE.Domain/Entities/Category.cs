using System;
using System.Collections.Generic;

namespace XNOTE.Domain.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
        public User User { get; set; }
        public virtual List<Note> Notes { get; set; }
    }
}
