using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeezerApp.Service.Domain
{
    public class Song
    {
        public string title { get; set; }
        public int duration { get; set; }
        public Artist artist { get; set; }
        public Album album { get; set; }
    }
}
