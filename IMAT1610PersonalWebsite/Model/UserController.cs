using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMAT1610PersonalWebsite.Model
{
    public class UserController
    {
        public bool AddNewUser(tbl_UserInfo newUser, string password)
        {
            bool response = false;
            try
            {
                using (IMAT1610Entities2 db = new IMAT1610Entities2())
                {
                    newUser.SourcePnumber = "P260YOU"; // First3numbers of your Pnumber and firt 3 letters of ur firstname
                    db.tbl_UserInfo.Add(newUser);
                    db.SaveChanges();
                }

                tbl_UserLogin newLoginInfo = new tbl_UserLogin { Password = password, Username = newUser.Email };
                using (IMAT1610Entities2 db = new IMAT1610Entities2())
                {
                    db.tbl_UserLogin.Add(newLoginInfo);
                    db.SaveChanges();
                }
                response = true;
            }
            catch (Exception ex)
            {
                response = false;
            }
            return response;
        }

        public tbl_UserInfo SelectUser(string email)
        {
            tbl_UserInfo returnUser = new tbl_UserInfo();
            try
            {
                using (IMAT1610Entities2 db = new IMAT1610Entities2())
                {
                    var user = db.tbl_UserInfo
                        .Where(p => p.Email.ToLower().Trim() == email.ToLower().Trim())
                        .Select(p => new { p.ID, p.Email, p.Firstname, p.Lastname, p.SourcePnumber }).FirstOrDefault();

                    if (user != null)
                    {
                        returnUser.ID = user.ID;
                        returnUser.Email = user.Email;
                        returnUser.Lastname = user.Lastname;
                        returnUser.Firstname = user.Firstname;
                        returnUser.SourcePnumber = user.SourcePnumber;
                    }
                    else
                    {
                        returnUser.ID = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                returnUser.ID = -1;
            }
            return returnUser;
        }
        public bool checkUsernameAndPassword(string username, string password, ref string firstname)
        {
            bool isLoginValid = false;
            string fname = "";
            try
            {
                using (IMAT1610Entities2 db = new IMAT1610Entities2())
                {
                    var login = db.tbl_UserLogin
                        .Where(p => p.Username.ToLower().Trim() == username.ToLower().Trim())
                        .Select(p => new { p.ID, p.Username, p.Password }).FirstOrDefault();

                    if (login != null)
                    {
                        isLoginValid = true;
                    }
                }

                if (isLoginValid)
                {
                    using (IMAT1610Entities2 db = new IMAT1610Entities2())
                    {
                        var user = db.tbl_UserInfo
                            .Where(p => p.Email.ToLower().Trim() == username.ToLower().Trim())
                            .Select(p => new { p.ID, p.Firstname, p.Lastname }).FirstOrDefault();

                        if (user != null)
                        {
                            fname = user.Firstname;
                        }
                    }
                }

                firstname = fname;
            }
            catch (Exception ex)
            {
                fname = ex.Message.ToString();
                firstname = fname;
                return false;
            }

            return isLoginValid;
        }
    }
}