using Jose;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Handlers.Auth
{
    public static class AuthenticationHandler
    {

        private static AppSettings AppSettings { get; set; }
        public static void ConfigSettings(IOptions<AppSettings> settings)
        {
            AppSettings = settings.Value;
        }


        public static string Authenticate(string username, string password)
        {
            var payload = new Dictionary<string, string>()
            {
                { "username", username },
                { "password", password }
            };

            var secretKey = new byte[] { 164, 60, 194, 0, 161, 189, 41, 38, 130, 89, 141, 164, 45, 170, 159, 209, 69, 137, 243, 216, 191, 131, 47, 250, 32, 107, 231, 117, 37, 158, 225, 234 };

            string token = Jose.JWT.Encode(payload, secretKey, JwsAlgorithm.HS256);
            return token;
        }

        public static string Decode(string token)
        {

            var secretKey = new byte[] { 164, 60, 194, 0, 161, 189, 41, 38, 130, 89, 141, 164, 45, 170, 159, 209, 69, 137, 243, 216, 191, 131, 47, 250, 32, 107, 231, 117, 37, 158, 225, 234 };

            var decodedToken = Jose.JWT.Decode(token, secretKey);
            
            //AppSettings.DBConnection;
            return decodedToken;
        }
    }
}
