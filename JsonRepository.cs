using System.Collections.Generic;

namespace DotnetDB_MovieLibraryInterface_HeilAdam
{
    public class JsonRepository : IRepository
    {
        public void Add(MovieJson movie)
        {
            throw new System.NotImplementedException();
        }
        public List<MovieJson> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
    public interface IRepository
    {
        public void Add(MovieJson movie);
        public List<MovieJson> GetAll(); 
    }
}