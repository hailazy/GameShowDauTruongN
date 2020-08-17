using GAME_SHOW.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GAME_SHOW.Services
{
    public class GameShowService
    {
        public bool Start(string gameShowId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GlobalInfo.BaseUrl);
                var result = client.GetStringAsync($"gameshow/start/{gameShowId}");
                result.Wait();
                var data = result.Result;

                return data.Contains("Ok");
            }
        }

        public string Open(string name)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GlobalInfo.BaseUrl);
                var result = client.GetStringAsync($"gameshow/open/{name}");
                result.Wait();
                var data = result.Result;

                return data;
            }
        }
        public List<UserJoinGameShow> GetJoinedUsers(string gameShowId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GlobalInfo.BaseUrl);
                var result = client.GetStringAsync($"gameshow/joined/{gameShowId}");
                result.Wait();
                var data = result.Result;

                return JsonConvert.DeserializeObject<List<UserJoinGameShow>>(data); 
            }
        }
        public bool Join(string userId, string gameShowId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GlobalInfo.BaseUrl);
                var model = new UserGameShow
                {
                    UserId = Int32.Parse(userId),
                    GameshowId = Int32.Parse(gameShowId)
                };
                var result = client.PostAsJsonAsync($"gameshow/join", model);
                result.Wait();
                var data = result.Result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                return data.Contains("Ok");
            }
        }
        public bool Close(string gameShowId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GlobalInfo.BaseUrl);
                var result = client.GetStringAsync($"gameshow/close/{gameShowId}");
                result.Wait();
                var data = result.Result;

                return data.Contains("Ok");
            }
        }

        public bool AddQuestion(string gameShowId,string questionId)
        {
            using (var client = new HttpClient())
            {
                var model = new QuestionGameShow
                {
                    GameshowId = Int32.Parse(gameShowId),
                    QuestionId = Int32.Parse(questionId)
                };
                client.BaseAddress = new Uri(GlobalInfo.BaseUrl);
                var result = client.PostAsJsonAsync($"gameshow/add-question", model);
                result.Wait();
                var data = result.Result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                return data.Contains("Ok");
            }
        }

        public List<GameShow> Find() 
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GlobalInfo.BaseUrl);
                var result = client.GetStringAsync($"gameshow/find");
                result.Wait();
                var data = result.Result;

                return JsonConvert.DeserializeObject<List<GameShow>>(data);
            }
        }
    }
}
