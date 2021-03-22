using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNoteForUser.Data.Interfaces;
using WebNoteForUser.Data.Models;
using WebTest.Data;

namespace WebNoteForUser.Data.Repository
{
    public class UserAccountRepository : IUserAccountRepository
    {
        private readonly AppDBContent appDBContent;

        public UserAccountRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<UserAccount> Users => appDBContent.Users;

        public UserAccount GetUser(int id) => appDBContent.Users.FirstOrDefault(x => x.Id == id);

        public void RemoveUser(int id)
        {
            appDBContent.Users.Remove(appDBContent.Users.FirstOrDefault(x => x.Id == id));
        }
    }
}
