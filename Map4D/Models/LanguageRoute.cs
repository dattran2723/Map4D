using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Map4D.Models
{
    public class LanguageRoute
    {
        public Contact Contact { get; set; }
        public string CurrentController { get; set; }
        public string CurrentAction { get; set; }
    }
}