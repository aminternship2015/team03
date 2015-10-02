using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FollowersModel
    {
        public int id_follower { get; set; }
        public int id_followedUser { get; set; }
        public int id_subscriber { get; set; }
    }
}
