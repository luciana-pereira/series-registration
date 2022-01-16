using System.Collections.Generic;
using series.registration.Interfaces;

namespace series.registration
{
    public class SerieRepositorio : Interfaces.IRepositorio<Serie>
    {
        private List<Serie> seriesList = new List<Serie>();
        public void Delet(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Serie entidade)
        {
            throw new System.NotImplementedException();
        }

        public List<Serie> Lista()
        {
            throw new System.NotImplementedException();
        }

        public int NextId()
        {
            throw new System.NotImplementedException();
        }

        public Serie ReturnById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, Serie entidade)
        {
            throw new System.NotImplementedException();
        }
    }

}