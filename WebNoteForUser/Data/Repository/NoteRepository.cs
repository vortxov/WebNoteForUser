using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNoteForUser.Data.Interfaces;
using WebNoteForUser.Data.Models;
using WebTest.Data;

namespace WebNoteForUser.Data.Repository
{
    public class NoteRepository : INoteRepository
    {
        private readonly AppDBContent appDBContent;

        public NoteRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Note> Notes => appDBContent.Notes.Include(x => x.Users);

        public Note GetNote(int id) => appDBContent.Notes.FirstOrDefault(x => x.Id == id);

        public void RemoveNote(int id)
        {
            appDBContent.Notes.Remove(appDBContent.Notes.FirstOrDefault(x => x.Id == id));
        }
    }
}
