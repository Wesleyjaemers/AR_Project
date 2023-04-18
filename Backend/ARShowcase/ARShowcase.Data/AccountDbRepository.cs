using System;
using System.Collections.Generic;
using System.Text;
using ARShowcase.Domain;
using ARShowcase.Logic.Contracts;

namespace ARShowcase.Data
{
    internal class AccountDbRepository : IAccountRepository
    {
        private readonly AccountContext _context;
        public void AddAccount(int userId, User user)
        {
            throw new NotImplementedException();
        }

        public User GetUserById()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model> GetModelsListOfUser()
        {
            throw new NotImplementedException();
        }

    }
}
