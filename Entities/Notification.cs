using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int UserID { get; set; }
        public bool Statement { get; set; }
        public string Type { get; set; }

        public User User { get; set; }

    }
}
