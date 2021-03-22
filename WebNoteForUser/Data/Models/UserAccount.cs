using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNoteForUser.Data.Models
{
    public class UserAccount
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public List<Note> Notes { get; set; }
    }
}
