using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.System;
using Windows.UI.Xaml.Media.Imaging;

namespace HappyWorkEveryday.Helper
{
    public static class LocalInformationHelper
    {
        /// <summary>
        /// Get Current User Domain Name,
        /// Return result format: (true, v-jamehe) or (false, error message)
        /// </summary>
        public static async Task<Tuple<bool,string>> getCurrentUserName()
        {
            var currentUsers = await User.FindAllAsync(UserType.LocalUser);
            var userName = await currentUsers[0].GetPropertyAsync(KnownUserProperties.DomainName);

            try
            {
                string[] userInfo = userName.ToString().Split('\\');
                if (userInfo[0] == "FAREAST.CORP.MICROSOFT.COM")
                {
                    return Tuple.Create(true, userInfo[1]);
                }

                return Tuple.Create(false, "Please use the microsoft domain.");
            }
            catch
            {
                return Tuple.Create(false, "Cannot get the user name, perhaps the setting does not enabled.");
            }
        }



    }
}
