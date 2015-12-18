using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace HappyWorkEveryday.Helper
{
    public static class AppHelper
    {
        public static async Task<string> getCurrentUserName()
        {
            var currentUser = await User.FindAllAsync(UserType.LocalUser);

            return currentUser[0].ToString();
        }
    }
}
