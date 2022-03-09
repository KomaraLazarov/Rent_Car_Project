using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class RentACarBusiness
    {
        private RentACarContext rentACarContext;

        public bool LogIn(string username, string password)
        {
            using (rentACarContext = new RentACarContext())
            {
                if (this.rentACarContext.Users.Any(x => x.Username == username))
                {
                    User currUser = this.rentACarContext.Users.First(x => x.Username == username);

                    if (currUser.Password == password)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
        public bool SignUp(User user)
        {
            using (this.rentACarContext = new RentACarContext())
            {
                if (this.rentACarContext.Users.Any(x => x.Username == user.Username))
                {
                    return false;
                }
                else
                {
                    this.rentACarContext.Users.Add(user);
                    this.rentACarContext.SaveChanges();

                    return true;
                }
            }
        }
    }
}
