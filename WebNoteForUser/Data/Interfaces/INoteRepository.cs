using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNoteForUser.Data.Models;

namespace WebNoteForUser.Data.Interfaces
{
    public interface INoteRepository
    {
        IEnumerable<Note> Notes { get; }
        Note GetNote(int id);
        void RemoveNote(int id);
    }
}
