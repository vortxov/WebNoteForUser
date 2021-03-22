using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNoteForUser.Data.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Tag { get; set; }
        public DateTime DateChange { get; set; }
        public List<UserAccount> Users { get; set; }
    }
}
