using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMAT1610PersonalWebsite.Model
{
    public class InputValidator
    {
        public string validateSignUp(string firstname, string lastname, string address, string email, string password)
        {
            try
            {
                if (firstname == "" || firstname.Length < 3)
                {
                    return "Firstname can't be less than 3 characters";
                }

                if (lastname == "" || lastname.Length < 3)
                {
                    return "Lastname can't be less than 3 characters";
                }

                if (address == "" || address.Length < 10)
                {
                    return "Address can't be less than 10 characters";
                }

                if (email == "" || email.Length < 3)
                {
                    return "Email can't be less than 3 characters";
                }

                if (password == "" || password.Length < 5)
                {
                    return "Password can't be less than 3 characters";
                }

                return "1";
            }
            catch (Exception ex)
            {
                return "Unknown error occured";
            }
        }
    }
}