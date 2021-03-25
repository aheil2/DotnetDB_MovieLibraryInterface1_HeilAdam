using System.Collections.Generic;

namespace DotnetDB_MovieLibraryInterface_HeilAdam
{
    public class MovieJson
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public List<string> Genres { get; set; }

        public MovieJson()
        {
            this.Genres = new List<string>();
        }
    }
}