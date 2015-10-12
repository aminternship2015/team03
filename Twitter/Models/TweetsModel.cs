using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class TweetsModel
    {
        public int id_tweet { get; set; }
        public int id_user { get; set; }

        [Required]
        public string Tweet { get; set; }
    }
}
