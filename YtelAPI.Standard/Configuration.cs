using YtelAPI.Standard.Models;
namespace YtelAPI.Standard
{
    public partial class Configuration
    {

        //The base Uri for API calls
        public static string BaseUri = "https://api.ytel.com/api/v3";

        //The username to use with basic authentication
        //TODO: Replace the BasicAuthUserName with an appropriate value
        public static string BasicAuthUserName = "";

        //The password to use with basic authentication
        //TODO: Replace the BasicAuthPassword with an appropriate value
        public static string BasicAuthPassword = "";

    }
}