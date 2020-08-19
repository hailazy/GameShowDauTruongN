using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_SHOW.Model
{
    public static class GlobalInfo
    {
        public static User CurrentUser { get; set; }
        public static string BaseUrl { get; } = "https://doan.daily102.com/api/";
        public static string gameShowId { get; set; } = "";
    }
}
