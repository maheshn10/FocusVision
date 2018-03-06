using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FocusVision
{
    public class LoginSecurity
    {
        public static bool Login(string username, string password)
        {
            using (FocusVisionEntities2 entities = new FocusVisionEntities2())
            {
                return entities.Users.Any(user =>
                       user.Username.Equals(username, StringComparison.OrdinalIgnoreCase)
                                          && user.Password == password);
            }
        }
    }
}