using System.Collections.Generic;
using System.Data.Entity;
using XNOTE.Domain.Entities;

namespace XNOTE.DataAccess
{
    public class XnoteContext : DbContext
    {
        public XnoteContext() : base("XnoteDB")
        {
            Database.SetInitializer<XnoteContext>(null);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
