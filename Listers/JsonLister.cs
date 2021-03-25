using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DotnetDB_MovieLibraryInterface_HeilAdam
{
    public class JsonList
    {
        public string path { get; set; }
        public List<MovieJson> movieJsonList { get; set; }
        public JsonList(string path) {
            movieJsonList = new List<MovieJson>();
            this.path = path;
            using (StreamReader sr = new StreamReader(path))
            {
                var json = sr.ReadToEnd();
                
            }
        }
    }
}