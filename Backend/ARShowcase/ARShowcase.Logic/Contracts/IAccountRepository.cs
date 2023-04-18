using ARShowcase.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ARShowcase.Logic.Contracts
{
    public interface IAccountRepository
    {
        void AddAccount(int userId, User user);
        User GetUserById();
        IEnumerable<Model> GetModelsListOfUser();
    }
}
