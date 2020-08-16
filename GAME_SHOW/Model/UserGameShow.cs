using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_SHOW.Model
{
    public class UserGameShow
    {
        public int Score { get; set; } = 0;
        public int UserId { get; set; }
        public int GameshowId { get; set; }
    }
}
