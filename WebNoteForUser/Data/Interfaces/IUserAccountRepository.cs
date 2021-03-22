using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNoteForUser.Data.Models;

namespace WebNoteForUser.Data.Interfaces
{
    public interface IUserAccountRepository
    {
        IEnumerable<UserAccount> Users { get; }
        UserAccount GetUser(int id);
        void RemoveUser(int id);
    }
}
