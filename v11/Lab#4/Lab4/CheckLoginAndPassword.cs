using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    class CheckLoginAndPassword<T> where T: IComputerOwnerInfo<User>, IComputerInfo
    {
        private bool LoginExistenceCheck(string login, List<Computer<User>> computers)
        {
            return computers.Any(item => item.Owner.Login == login);
        }
        public bool CheckPasswordForLogin(string login, string password, List<Computer<User>> computers)
        {
            var computer = new Computer<User>();
            if (LoginExistenceCheck(login, computers))
                computer = computers.Last(item => item.Owner.Login == login);
            if (computer == null)
                return false;
            if (LoginExistenceCheck(login, computers) && computer.Owner.Password == password)
                return true;
            else
                return false;
        }
    }
}