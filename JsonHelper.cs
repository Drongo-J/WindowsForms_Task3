using Newtonsoft.Json;
using System.IO;
using WindowsForms_Task3;

namespace Helper
{
    public class JsonSerialization
    {
        public static void SerializeUser(User user)
        {
            var serializer = new JsonSerializer();

            string jSonFile = user.Email + ".json";
            using (var sw = new StreamWriter(jSonFile))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, user);
                }
            }
        }

        public static User DeserializeUser(string filename)
        {
            User user;
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(filename))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    user = serializer.Deserialize<User>(jr);
                }
            }
            return user;
        }
    }
}
