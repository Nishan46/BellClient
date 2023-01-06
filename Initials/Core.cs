using System;
using System.Collections.Generic;
using System.Text;
using Initials.Data;
using Jose;
using Newtonsoft.Json;

namespace Initials
{
    public class Core
    {
        public string Get_Token(string Pass_Key)
        {
            return JWT.Encode(GetPayload(DateTime.Now, Pass_Key), GetSecretKeyAsBytes("JWT_zA6mF2wA88XMpcMXf_RtcBpbw98-AC-Bvx5"), JwsAlgorithm.HS256);
        }

        public object Auth(string token , string Password)
        {
            AuthData authData = new AuthData();

            foreach (KeyValuePair<string , LoginData> login_data in JsonConvert.DeserializeObject<Dictionary<string, LoginData>>(JWT.Decode(token, GetSecretKeyAsBytes("JWT_zA6mF2wA88XMpcMXf_RtcBpbw98-AC-Bvx5"), JwsAlgorithm.HS256)))
            {
                if (login_data.Key == "data")
                {
                    
                    if(login_data.Value.LOGIN_KEY == Password)
                    {

                        authData.is_auth = true;
                        authData.genarated = Convert.ToDateTime(login_data.Value.GENARATED);
                    }
                    else
                    {
                        authData.is_auth = false;
                        authData.genarated = Convert.ToDateTime(login_data.Value.GENARATED);
                    }
                }
                else
                {
                    return null;
                }
            }
            return JsonConvert.SerializeObject(authData);
        }

        public object Sign(string token)
        {
            LoginData loginData = new LoginData();
            foreach (KeyValuePair<string, LoginData> login_data in JsonConvert.DeserializeObject<Dictionary<string, LoginData>>(JWT.Decode(token, GetSecretKeyAsBytes("JWT_zA6mF2wA88XMpcMXf_RtcBpbw98-AC-Bvx5"), JwsAlgorithm.HS256)))
            {
                if(login_data.Key == "data")
                {
                    loginData = login_data.Value;
                }
            }
            return JsonConvert.SerializeObject(loginData);
        }

        private static byte[] GetSecretKeyAsBytes(string secret)
        {
            return Encoding.UTF8.GetBytes(secret);
        }
        private static Dictionary<string, LoginData> GetPayload(DateTime utcNow, string Key)
        {
            LoginData data = new LoginData();
            data.APP = "Client";
            data.GENARATED = utcNow.ToString();
            data.LOGIN_KEY = Key;


            return new Dictionary<string, LoginData>()
            {
                { "data", data }
            };
        }
    }
}
