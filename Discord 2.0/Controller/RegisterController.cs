using Discord_2._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_2._0.Controller
{
    class RegisterController
    {
        public void AddUser(Users s)
        {
            using (CommunicationSoftwareDBEntities ex = new CommunicationSoftwareDBEntities())
            {
                var lastUser = ex.Users.ToList().LastOrDefault();
                if (lastUser == null)
                {
                    lastUser = new Users();
                    lastUser.Id = 0;
                }

                s.Id = lastUser.Id + 1;
                ex.Users.Add(s);
                ex.SaveChanges();
            }
        }

        public string Login(string email, string pass)
        {
            using (CommunicationSoftwareDBEntities cs = new CommunicationSoftwareDBEntities())
            {
                var Login = cs.Users.Where(s => s.Email == email).FirstOrDefault();
                if (Login != null)
                {
                    if (Login.Email == email && Login.Password == pass)
                    {
                        return null;
                    }
                    else
                    {
                        return "The Username or password is incorect, please try again";
                    }
                }
                else
                {
                    return "No suck user!";
                }
            }
        }
    }
}
