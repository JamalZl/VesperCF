using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesterrCFDatabase.Models
{
    public class SiteEntrance
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string GetStarted { get; set; }
        public string Image { get; set; }

        //public SiteEntrance SiteEntrancess { get; set; }
    }
}
