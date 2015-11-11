using System;
using System.Collections.Generic;

namespace XNOTE.Domain.Entities
{
    public class User
    {
        // Entity Framework сам шукає змінну зі словом Id і робить її первинним ключем
        public int UserId { get; set; }
        public string Email { get; set; }
        //[MinLength(6)]
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public byte[] Photo { get; set; }
        public virtual List<Category> Categories { get; set; }
    }
}
