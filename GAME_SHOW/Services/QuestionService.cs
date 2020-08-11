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
    public class QuestionService
    {
        public List<Question> GetQuestions(string userId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GlobalInfo.BaseUrl);
                var result = client.GetStringAsync($"question/list/{userId}");
                result.Wait();
                var data = result.Result;

                return JsonConvert.DeserializeObject<List<Question>>(data); 
            }
        }
        public void Delete(string id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GlobalInfo.BaseUrl);
                var result = client.GetStringAsync($"question/remove/{id}");
                result.Wait();
            }
        }

        public bool Update(Question question)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GlobalInfo.BaseUrl);
                var result = client.PostAsJsonAsync($"question/update", question);
                result.Wait();
                var data = result.Result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                return data == null ? false : true;
            }
        }

    }
}
