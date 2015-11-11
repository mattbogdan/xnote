using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using XNOTE.Domain.Entities;

namespace XNOTE.DataAccess.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<XNOTE.DataAccess.XnoteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "XNOTE.DataAccess.XnoteContext";
        }

        protected override void Seed(XnoteContext context)
        {
            SeedXnote(context);
        }

        private void SeedXnote(XnoteContext context)
        {
            User user = new User
            {
                DateOfBirth = DateTime.Now,
                DateOfRegistration = DateTime.Now,
                Email = "email 1",
                Name = "name 1",
                Password = "pass 1",
                Surname = "sname 1"
            };
            AddUser(context, user);

            Category category = new Category
            {
                DateOfCreation = DateTime.Now,
                Name = "cat 1"
            };
            AddCategory(context, category, 1);

            Note note = new Note
            {
                Category = category,
                DateOfChange = DateTime.Now,
                DateOfCreation = DateTime.Now,
                Text = "text",
                Title = "title"
            };
            AddNote(context, note, 1);

            Tag tag = new Tag
            {
                Color = 1,
                Name = "work"
            };

            
            //context.Tags.Add(tag);

            List<Tag> tags = new List<Tag>
            {
                    new Tag { Name = "t1" },
                    new Tag { Name = "t2" },
                    new Tag { Name = "t3" }
                    // ...
            };
        }

        private void AddUser(XnoteContext context, User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        private void AddCategory(XnoteContext context, Category category, int userId)
        {
            User user = context.Users.Find(userId);
            category.User = user;
            if (user != null)
                context.Categories.Add(category);
            context.SaveChanges();
        }

        private void AddNote(XnoteContext context, Note note, int categoryId)
        {
            Category category = context.Categories.Find(categoryId);
            note.Category = category;
            if (category != null)
                context.Categories.Add(category);
            context.SaveChanges();
        }

    }
}
