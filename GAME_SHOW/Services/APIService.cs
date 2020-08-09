using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using GAME_SHOW.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GAME_SHOW.Services
{
    public class APIService
    {
        static readonly HttpClient client = new HttpClient();
        static readonly string URL = "https://localhost:44317/api/";

        public static User Login(string email, string password)
        {
            using (client)
            {
                var account = new Account(email, password);
                client.BaseAddress = new Uri(URL);
                var result = client.PostAsJsonAsync("auth/login", account);
                result.Wait();

                var data = result.Result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                User user = JsonConvert.DeserializeObject<User>(data);
                return user;
            }
        }

        public static bool SignUp(string email, string fullName, string role , string password, string rePassword)
        {
            using (client)
            {
                var account = new Account(email, fullName, role, password, rePassword );
                client.BaseAddress = new Uri(URL);
                var result = client.PostAsJsonAsync("auth/sign-up", account);
                result.Wait();

                var data = result.Result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                return data == null ? false : true;
            }
        }

        public static bool AddQuestion(string userId, string content, string answerA, string answerB, string answerC, string answerD, int rightAnswer)
        {
            using (client)
            {
                var question = new Question(userId, content, answerA, answerB, answerC, answerD, rightAnswer);
                client.BaseAddress = new Uri(URL);
                var result = client.PostAsJsonAsync("auth/sign-up", question);
                result.Wait();

                var data = result.Result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                return data == null ? false : true;
            }
        }
    }
}


