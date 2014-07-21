using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class User
    {
        private string _login;
        private string _name;
        private string _surname;
        private int _age;
        private readonly DateTime _fillInDate;

        public User(string login, string userName, string userSurname, int userAge)
        {
            this._login = login;
            this._name = userName;
            this._surname = userSurname;
            this._age = userAge;
            this._fillInDate = DateTime.Today;
        }

        public override string ToString()
        {
            return String.Format("User login:{0} \n Username:{1} \n Surname:{2} \n User age:{3} \n First log in date:{4:dd/MM/yyyy}",this._login, this._name, this._surname,this._age,this._fillInDate);
        }
    }
}
