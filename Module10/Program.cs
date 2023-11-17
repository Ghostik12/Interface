using System;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            var account = new Account();

            IUpdater<Account> updater = new UserService();
            IUpdater<User> userService = new UserService();
            userService.Update(user);
            updater.Update(account);
        }
    }

    class User
    {

    }

    class Account : User 
    { 

    }

    public interface IUpdater <in T>
    {
        void Update (T entity);
    }

    class UserService : IUpdater<User>
    {
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}