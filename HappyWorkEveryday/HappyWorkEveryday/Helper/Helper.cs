using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace HappyWorkEveryday.Helper
{
    public static class AppHelper
    {
        /// <summary>
        /// Get Current User Domain Name
        /// "v-jamehe" is the output
        /// </summary>
        /// <returns></returns>
        public static async Task<string> getCurrentUserName()
        {
            var currentUsers = await User.FindAllAsync(UserType.LocalUser);
            string userName = (await currentUsers[0].GetPropertyAsync(KnownUserProperties.DomainName)).ToString();
            string[] userInfo = userName.Split('\\');
            if (userInfo[0] == "FAREAST.CORP.MICROSOFT.COM")
            {
                return userInfo[1];
            }
            else
            {
                return "incorrect user, please use the computer from domain";
            }
            
        }
    }
}
