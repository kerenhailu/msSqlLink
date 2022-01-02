using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msSqlLink
{
    internal class Employees
    {
        string first_name;
        string last_name;
        int age;
        string birthday;
        string email;

        public Employees(string first_name, string last_name, int age, string birthday, string email)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.age = age;
            this.birthday = birthday;
            this.email = email;
        }
    }
}
