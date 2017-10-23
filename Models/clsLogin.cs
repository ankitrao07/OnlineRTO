using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineRTO.ViewModel;
namespace OnlineRTO.Models
{
    public class clsLogin
    {
        public static eRTOEntities dbContext = new eRTOEntities();
        public static bool IsAuthenticate(vmLogin _LoginDetails)
        {
            var user = (from l in dbContext.Logins
                        where l.UserName == _LoginDetails.UserName && l.Password == _LoginDetails.Password && l.IsActive == true
                        select new AuthenticatedUser
                        {
                           UID =l.LoginId,
                           Role=l.Role
                        }).ToList();
            if(user.Count>0)
            {
                HttpContext.Current.Session["UID"] = Convert.ToInt32(user[0].UID);
                HttpContext.Current.Session["Role"]=Convert.ToString(user[0].Role);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static void GetUserDetails(int uid, string role)
        {
            if (role == Role.Dealer.ToString())
            {
                var user = (from d in dbContext.Dealers
                            where d.LoginID == uid
                            select new AuthenticatedUser
                            {
                                Name = d.DealerName,
                                Role = role,
                                UID = d.Id
                            }).ToList();
                if (user.Count > 0)
                {
                    HttpContext.Current.Session["Name"] = user[0].Name;
                    HttpContext.Current.Session["Role"] = user[0].Role;
                    HttpContext.Current.Session["UID"] = Convert.ToInt32(user[0].UID);

                }

            }
            else
            {
                if (role == Role.RTO.ToString())
                {
                    var user = (from r in dbContext.RTOes
                                where r.LoginID == uid
                                select new AuthenticatedUser
                                {
                                    Name = r.Name,
                                    Role = role,
                                    UID = r.RTOId
                                }).ToList();
                    if (user.Count > 0)
                    {
                        HttpContext.Current.Session["Name"] = user[0].Name;
                        HttpContext.Current.Session["Role"] = user[0].Role;
                        HttpContext.Current.Session["UID"] = Convert.ToInt32(user[0].UID);

                    }

                }


            }
        }
    }
    public enum Role
    {
        Dealer=1,
        RTO=2
    }
}